import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { AngularFireAuth } from 'angularfire2/auth';
import { BehaviorSubject, Observable, ReplaySubject, forkJoin } from 'rxjs';
import { UserRegisterRequest } from '../../shared/models/user-register-request';
import { TokenService } from './token.service';
import { UserLoginRequest } from '../../shared/models/user-login-request';
import * as firebase from 'firebase';
import { UserInfoProfile } from '../../shared/models/user-info-profile';
import { User } from '../../shared/models/user.model';
import { distinctUntilChanged } from 'rxjs/operators';
import { Token } from '../../shared/models/token.model';
import { UserProfile} from '../../shared/models/user-profile';
import { JwtHelperService } from '@auth0/angular-jwt';
import { from } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private currentUserSubject = new BehaviorSubject<User>(this.getCurrentUserLS());
  public currentUser: Observable<User> = this.currentUserSubject.asObservable().pipe(distinctUntilChanged());

  private isAuthenticatedSubject = new ReplaySubject<boolean>(1);
  public isAuthenticated: Observable<boolean> = this.isAuthenticatedSubject.asObservable();

  private user: Observable<firebase.User>;
  private userDetails: firebase.User = null;
  public userRegisterRequest: UserRegisterRequest = null;

  private tokenHelper: JwtHelperService = new JwtHelperService();

  constructor(private _firebaseAuth: AngularFireAuth,
    private tokenService: TokenService,
    private router: Router,
    ) {
    this.user = _firebaseAuth.authState;
    this.user.subscribe(
      (user) => {
        if (user) {
          this.userDetails = user;
        } else {
          this.userDetails = null;
        }
      }
    );
  }

  // Verify JWT in localstorage with server & load user's info.
  // This runs once on application startup.
  async populate(): Promise<any> {
    console.log('POPULATE');
    // If JWT detected, attempt to get & store user's info
    const fToken = await this.getFirebaseToken();
    const wToken = await this.getWatcherToken();
    console.log(fToken);
    console.log(wToken);

    if (fToken && wToken) {
      return this.tokenService.getUserByTokens().toPromise()
        .then(currUser => {
          this.setAuth(currUser);
          return currUser;
        })
        .catch(err => {
          console.log(err);
          this.purgeAuth();
        });
    } else {
      // Remove any potential remnants of previous auth states
      this.purgeAuth();
    }
  }

  setAuth(token: Token): void {
    // Save User sent from server in localStorage
    localStorage.setItem('currentUser', JSON.stringify(token.user));
    localStorage.setItem('watcherToken', token.watcherJWT);
    // Set current user data into observable
    this.currentUserSubject.next(token.user);
    // Set isAuthenticated to true
    this.isAuthenticatedSubject.next(true);
  }

  purgeAuth(): void {
    // Remove JWT and current User from localstorage
    localStorage.removeItem('currentUser');
    localStorage.removeItem('watcherToken');

    // Set current user to an empty object
    this.currentUserSubject.next({} as User);
    // Set auth status to false
    this.isAuthenticatedSubject.next(false);
  }

  async login(credential: firebase.auth.UserCredential, provider: string): Promise<void> {
    let firstName;
    let lastName;
    const profile: UserProfile = (<UserProfile>credential.additionalUserInfo.profile);
    switch (provider) {
      case 'Google': {
        firstName = profile.given_name;
        lastName = profile.family_name;
        break;
      }
      case 'Facebook': {
        firstName = profile.first_name;
        lastName = profile.last_name;
        break;
      }
      case 'GitHub': {
        firstName = '';
        lastName = '';
        break;
      }
    }

    this.userRegisterRequest = {
      uid: credential.user.uid,
      email: credential.user.email,
      displayName: credential.user.displayName,
      refreshToken: credential.user.refreshToken,
      photoUrl: credential.user.photoURL,
      isNewUser: credential.additionalUserInfo.isNewUser,
      companyName: '',
      invitedOrganizationId: 0,
      firstName: firstName,
      lastName: lastName
    };

    if (!this.userRegisterRequest.email) {
      this.userRegisterRequest.email = (<UserInfoProfile>credential.additionalUserInfo.profile).email;
    }

    const request: UserLoginRequest = {
      uid: this.userRegisterRequest.uid,
      email: this.userRegisterRequest.email
    };
    const firebaseToken = await credential.user.getIdToken(true);

    localStorage.setItem('firebaseToken', firebaseToken);
    console.log('LOGIN');
    console.log(credential.user.photoURL);
    return this.tokenService.login(request).toPromise()
      .then(tokenDto => {
        this.setAuth(tokenDto);
      })
      .catch(err => {
        throw err;
      });
  }

  async register(): Promise<void> {
    await this.tokenService.register(this.userRegisterRequest).toPromise()
      .then(tokenDto => {
        this.setAuth(tokenDto);
      })
      .catch(err => {
        throw err;
      });
  }

  async signInWithGoogle(): Promise<boolean> {
    return await this._firebaseAuth.auth.signInWithPopup(new firebase.auth.GoogleAuthProvider().addScope('email'))
      .then(res => {
        console.log(res);
        return this.login(res, 'Google');
      })
      .then(() => {
        return true;
      })
      .catch(err => {
        if (err.status === 400) {
          throw err;
        }
        console.error(err);
        return false;
      });
  }

  async signInWithFacebook(): Promise<boolean> {
    return await this._firebaseAuth.auth.signInWithPopup(new firebase.auth.FacebookAuthProvider().addScope('email'))
      .then(res => {
        return this.login(res, 'Facebook');
      })
      .then(() => {
        return true;
      })
      .catch(err => {
        if (err.status === 400) {
          throw err;
        }
        console.error(err);
        return false;
      });
  }

  async signInWithGitHub(): Promise<boolean> {
    return await this._firebaseAuth.auth.signInWithPopup(new firebase.auth.GithubAuthProvider().addScope('email'))
      .then(res => {
        return this.login(res, 'GitHub');
      })
      .then(() => {
        return true;
      })
      .catch(err => {
        if (err.status === 400) {
          throw err;
        }
        console.error(err);
        return false;
      });
  }

  async signUpWithProvider(companyName: string, firstName: string, lastName: string, email: string,
                            inviitedOrganizationId: number = 0): Promise<void> {
    this.userRegisterRequest.companyName = companyName;
    this.userRegisterRequest.firstName = firstName;
    this.userRegisterRequest.lastName = lastName;
    this.userRegisterRequest.email = email;
    this.userRegisterRequest.invitedOrganizationId = inviitedOrganizationId;
    await this.register()
      .then(() => {
      })
      .catch(err => {
        throw err;
      });
  }

  isLoggedIn(): boolean {
    if (this.userDetails == null) {
      return false;
    } else {
      return true;
    }
  }

  isAuthorized(): boolean {
    const user = this.getCurrentUserLS();

    if (user != null) {
      return true;
    } else {
      return false;
    }
  }

  getCurrentUser(): User | null {
    return this.currentUserSubject.value;
  }

  getCurrentUserLS(): User {
    const userStr = localStorage.getItem('currentUser');
    const userDto = (<User>JSON.parse(userStr));
    return userDto;
  }

  updateCurrentUser(user: User) {
    localStorage.setItem('currentUser', JSON.stringify(user));
    // Set current user data into observable
    this.currentUserSubject.next(user);
  }

  getTokens() {
    return forkJoin(this.getFirebaseToken(), this.getWatcherToken());
  }

  async getFirebaseToken(): Promise<string> {
    const currentToken =  localStorage.getItem('firebaseToken');
    console.log(new Date());
    console.log(`Firebase token is expired: ${this.tokenHelper.isTokenExpired(currentToken)}`);
    if (this.tokenHelper.isTokenExpired(currentToken)) {
      await this.refreshFirebaseToken();
    }
    return localStorage.getItem('firebaseToken');
  }

  async getWatcherToken(): Promise<string> {
    const currentToken = localStorage.getItem('watcherToken');
    console.log(new Date());
    console.log(`Watcher token is expired: ${this.tokenHelper.isTokenExpired(currentToken)}`);
    if (this.tokenHelper.isTokenExpired(currentToken)) {
      await this.refreshWatcherToken();
    }
    return localStorage.getItem('watcherToken');
  }

  async refreshFirebaseToken() {
    const token = localStorage.getItem('firebaseToken');
    if (!token) {
      return;
    }
    if (!this.tokenHelper.isTokenExpired(token)) {
      return;
    }

    const firebaseToken = await this._firebaseAuth.auth.currentUser.getIdToken(true);
    localStorage.setItem('firebaseToken', firebaseToken);
  }

  async refreshWatcherToken() {
    console.log('REFRESH WATCHER TOKEN');
    const token = localStorage.getItem('watcherToken');
    if (!token) {
      return;
    }
    if (!this.tokenHelper.isTokenExpired(token)) {
      return;
    }
    console.log('IT IS EXPIRED');

    const userInfo = this.getCurrentUserLS();
     const req: UserLoginRequest = {
      uid: userInfo.id,
      email: userInfo.email
    };

    const tokenDto = await this.tokenService.login(req).toPromise();
    localStorage.setItem('watcherToken', tokenDto.watcherJWT);
  }

  logout(): boolean {
    this.purgeAuth();
    localStorage.removeItem('firebaseToken');

    this._firebaseAuth.auth.signOut()
      .then((res) => this.router.navigate(['/']))
      .catch(err => console.error(err));

    return true;
  }
}
