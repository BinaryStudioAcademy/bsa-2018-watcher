import {Injectable} from '@angular/core';
import {Router} from '@angular/router';
import {AngularFireAuth} from 'angularfire2/auth';
import {Observable} from 'rxjs';
import {UserRegisterRequest} from '../../shared/models/user-register-request';
import {TokenService} from './token.service';
import {UserDto} from '../../shared/models/user-dto';
import {UserLoginRequest} from '../../shared/models/user-login-request';
import * as firebase from 'firebase';
import {UserInfoProfile} from '../../shared/models/user-info-profile';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  // public currentUser: Observable<UserDto>;

  private user: Observable<firebase.User>;
  private userDetails: firebase.User = null;
  private userRegisterRequest: UserRegisterRequest = null;

  constructor(private _firebaseAuth: AngularFireAuth,
              private tokenService: TokenService,
              private router: Router) {
    this.user = _firebaseAuth.authState;
    this.user.subscribe(
      (user) => {
        if (user) {
          this.userDetails = user;
          console.log(this.userDetails);
        } else {
          this.userDetails = null;
        }
      }
    );
  }

  async login(credential: firebase.auth.UserCredential, provider: string): Promise<void> {
    this.userRegisterRequest = {
      uid: credential.user.uid,
      email: credential.user.email,
      displayName: credential.user.displayName,
      refreshToken: credential.user.refreshToken,
      photoURL: credential.user.photoURL,
      isNewUser: credential.additionalUserInfo.isNewUser,
      companyName: '',
      firstName: '',
      lastName: ''
    };

    if (provider === 'Facebook' || provider === 'GitHub') {
      this.userRegisterRequest.email = (<UserInfoProfile>credential.additionalUserInfo.profile).email;
    }


    const request: UserLoginRequest = {
      uid: this.userRegisterRequest.uid,
      email: this.userRegisterRequest.email
    };

    const firebaseToken = await credential.user.getIdToken();
    localStorage.setItem('firebaseToken', firebaseToken);

    return this.tokenService.login(request).toPromise()
      .then(tokenDto => {
        localStorage.setItem('currentUser', JSON.stringify(tokenDto.user));
        localStorage.setItem('watcherToken', tokenDto.watcherJWT);
      })
      .catch(err => {
        throw err;
      });
  }

  async register(): Promise<void> {
    await this.tokenService.register(this.userRegisterRequest).toPromise()
      .then(tokenDto => {
        localStorage.setItem('currentUser', JSON.stringify(tokenDto.user));
        localStorage.setItem('watcherToken', tokenDto.watcherJWT);
      })
      .catch(err => {
        throw err;
      });
  }

  signInWithGoogle(): Promise<boolean> {
    return this._firebaseAuth.auth.signInWithPopup(new firebase.auth.GoogleAuthProvider())
      .then(res => {
        return this.login(res, 'Google');
      })
      .then(() => {
        return true;
      })
      .catch(err => {
        if (err) {
          if (err.status === 400) {
            throw err;
          }
        } else {
          console.log(err);
          return false;
        }
      });
  }

  signInWithFacebook(): Promise<boolean> {
    return this._firebaseAuth.auth.signInWithPopup(new firebase.auth.FacebookAuthProvider())
      .then(res => {
        return this.login(res, 'Facebook');
      })
      .then(() => {
        return true;
      })
      .catch(err => {
        if (err) {
          if (err.status === 400) {
            throw err;
          }
        } else {
          console.log(err);
          return false;
        }
      });
  }

  signInWithGitHub(): Promise<boolean> {
    return this._firebaseAuth.auth.signInWithPopup(new firebase.auth.GithubAuthProvider())
      .then(res => {
        return this.login(res, 'GitHub');
      })
      .then(() => {
        return true;
      })
      .catch(err => {
        if (err) {
          if (err.status === 400) {
            throw err;
          }
        } else {
          console.log(err);
          return false;
        }
      });
  }

  async signUpWithProvider(companyName: string, firstName: string, lastName: string): Promise<void> {
    this.userRegisterRequest.companyName = companyName;
    this.userRegisterRequest.firstName = firstName;
    this.userRegisterRequest.lastName = lastName;

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

  getCurrentUser(): UserDto | null {
    const userStr = localStorage.getItem('currentUser');
    const userDto = (<UserDto>JSON.parse(userStr));
    return userDto;
  }

  getFirebaseToken(): string | null {
    return localStorage.getItem('firebaseToken');
  }

  getWatcherToken(): string | null {
    return localStorage.getItem('watcherToken');
  }

  logout(): boolean {
    localStorage.removeItem('currentUser');
    localStorage.removeItem('watcherToken');
    localStorage.removeItem('firebaseToken');

    this._firebaseAuth.auth.signOut()
      .then((res) => this.router.navigate(['/']))
      .catch(err => console.error(err));

    return true;
  }
}
