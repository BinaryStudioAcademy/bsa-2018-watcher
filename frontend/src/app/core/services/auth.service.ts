import {Injectable} from '@angular/core';
import {Router} from '@angular/router';
import {AngularFireAuth} from 'angularfire2/auth';
import * as firebase from 'firebase/app';
import {Observable} from 'rxjs';
import {PostInfo} from '../../shared/models/post-info';
import {TokenService} from './token.service';
import {UserDto} from '../../shared/models/user-dto';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  // public currentUser: Observable<UserDto>;

  private user: Observable<firebase.User>;
  private userDetails: firebase.User = null;

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

  async signInWithGoogle(): Promise<boolean> {
    try {
      const res = await this._firebaseAuth.auth.signInWithPopup(new firebase.auth.GoogleAuthProvider());

      const info: PostInfo = {
        token: await res.user.getIdToken(),
        user: {
          uid: res.user.uid,
          email: res.user.email,
          displayName: res.user.displayName,
          refreshToken: res.user.refreshToken,
          photoURL: res.user.photoURL,
          isNewUser: res.additionalUserInfo.isNewUser
        }
      };

      localStorage.setItem('firebaseToken', info.token);
      const tokenDto = await this.tokenService.register(info).toPromise();
      localStorage.setItem('currentUser', JSON.stringify(tokenDto.user));
      localStorage.setItem('watcherToken', tokenDto.watcherJWT);

    } catch (e) {
      console.log(e);
      return false;
    }

    return true;
  }

  signInWithFacebook(): Promise<firebase.auth.UserCredential> {
    return this._firebaseAuth.auth.signInWithPopup(
      new firebase.auth.FacebookAuthProvider()
    );
  }

  signInWithTwitter(): Promise<firebase.auth.UserCredential> {
    return this._firebaseAuth.auth.signInWithPopup(
      new firebase.auth.TwitterAuthProvider()
    );
  }

  signInWithGitHub(): Promise<firebase.auth.UserCredential> {
    return this._firebaseAuth.auth.signInWithPopup(
      new firebase.auth.GithubAuthProvider()
    );
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
