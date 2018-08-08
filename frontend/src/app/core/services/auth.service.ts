import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { AngularFireAuth } from 'angularfire2/auth';
import * as firebase from 'firebase/app';
import { Observable } from 'rxjs';
import { PostInfo } from '../../shared/models/post-info';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private user: Observable<firebase.User>;
  private userDetails: firebase.User = null;

  constructor(private _firebaseAuth: AngularFireAuth, private router: Router) {
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

  signInWithGoogle(): Promise<PostInfo> {
    const info: PostInfo = new PostInfo();
    return this._firebaseAuth.auth.signInWithPopup(new firebase.auth.GoogleAuthProvider()
    ).then((res) => {
      info.user = {
        uid: res.user.uid,
        email: res.user.email,
        displayName: res.user.displayName,
        refreshToken: res.user.refreshToken,
        photoURL: res.user.photoURL,
        isNewUser: res.additionalUserInfo.isNewUser
      };

      return res;
    }).then(resNext => {
      return resNext.user.getIdToken().then(token => {
        info.token = token;
        return info; }
      );
    });
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

  isLoggedIn() {
    if (this.userDetails == null) {
      return false;
    } else {
      return true;
    }
  }

  signUpWithGoogle(): Promise<PostInfo> {
    const info: PostInfo = new PostInfo();
    return this._firebaseAuth.auth.signInWithPopup(new firebase.auth.GoogleAuthProvider()
    ).then((res) => {
      info.user = {
        uid: res.user.uid,
        email: res.user.email,
        displayName: res.user.displayName,
        refreshToken: res.user.refreshToken,
        photoURL: res.user.photoURL,
        isNewUser: res.additionalUserInfo.isNewUser
      };

      return res;
    }).then(resNext => {
      return resNext.user.getIdToken().then(token => {
        info.token = token;
        return info; }
      );
    });
  }

  logout() {
    this._firebaseAuth.auth.signOut()
      .then((res) => this.router.navigate(['/']));
  }
}
