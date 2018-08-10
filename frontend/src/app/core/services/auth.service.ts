import {Injectable} from '@angular/core';
import {Router} from '@angular/router';
import {AngularFireAuth} from 'angularfire2/auth';
import {Observable} from 'rxjs';
import {UserRegisterRequest} from '../../shared/models/user-register-request';
import {TokenService} from './token.service';
import {UserDto} from '../../shared/models/user-dto';
import {UserLoginRequest} from '../../shared/models/user-login-request';
import * as firebase from 'firebase';

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

  async login(credential: firebase.auth.UserCredential): Promise<void> {
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
      .then( res => {

        return this.login(res);
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

  async signUpWithGoogle(companyName: string, firstName: string, lastName: string): Promise<void> {
    this.userRegisterRequest.companyName = companyName;
    this.userRegisterRequest.firstName = firstName;
    this.userRegisterRequest.lastName = lastName;

    await this.register()
      .then(() => {
      })
      .catch(err => {
        throw err;
      });
    // return await this._firebaseAuth.auth.signInWithPopup(new firebase.auth.GoogleAuthProvider())
    //   .then(res => {
    //     return this.register(res);
    //   })
    //   .then(() => {
    //     return true;
    //   })
    //   .catch(err => {
    //     if (err) {
    //       if (err.status === 400) {
    //         throw err;
    //       }
    //     } else {
    //       console.log(err);
    //       return false;
    //     }
    //   });
  }

  async signInWithFacebook(): Promise<boolean> {
    try {
      const res = await this._firebaseAuth.auth.signInWithPopup(new firebase.auth.FacebookAuthProvider());

      await this.login(res);

    } catch (e) {
      console.log(e);
      return false;
    }

    return true;
  }

  async signUpWithFacebook(): Promise<boolean> {
    try {
      const res = await this._firebaseAuth.auth.signInWithPopup(new firebase.auth.FacebookAuthProvider());

      await true; // this.register(res);

    } catch (e) {
      console.log(e);
      return false;
    }

    return true;
  }

  async signInWithGitHub(): Promise<boolean> {
    try {
      const res = await this._firebaseAuth.auth.signInWithPopup(new firebase.auth.GithubAuthProvider());

      await this.login(res);

    } catch (e) {
      console.log(e);
      return false;
    }

    return true;
  }

  async signUpWithGitHub(): Promise<boolean> {
    try {
      const res = await this._firebaseAuth.auth.signInWithPopup(new firebase.auth.GithubAuthProvider());

      await true; //this.register(res);

    } catch (e) {
      console.log(e);
      return false;
    }

    return true;
  }

  async signInWithTwitter(): Promise<boolean> {
    try {
      const res = await this._firebaseAuth.auth.signInWithPopup(new firebase.auth.TwitterAuthProvider());

      await this.login(res);

    } catch (e) {
      console.log(e);
      return false;
    }

    return true;
  }

  async signUpWithTwitter(): Promise<boolean> {
    try {
      const res = await this._firebaseAuth.auth.signInWithPopup(new firebase.auth.TwitterAuthProvider());

      await true; // this.register(res);

    } catch (e) {
      console.log(e);
      return false;
    }

    return true;
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
