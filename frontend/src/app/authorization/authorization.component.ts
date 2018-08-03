import { Component, OnInit, TemplateRef, ViewChild  } from '@angular/core';
import { AngularFireAuth } from 'angularfire2/auth';
import * as firebase from 'firebase/app';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-authorization',
  templateUrl: './authorization.component.html',
  styleUrls: ['./authorization.component.sass']
})
export class AuthorizationComponent implements OnInit {
  // private user: Observable<firebase.User>;
  @ViewChild('signInTemplate') signInTemplate;
  @ViewChild('signUpTemplate') signUpTemplate;

  display: boolean = false;
  isSignIn: boolean = true;

  constructor(private _firebaseAuth: AngularFireAuth) {
   // this.user = _firebaseAuth.authState;
   }

  ngOnInit() {
  }

  showDialog() {
    this.display = true;
  }

  loadTemplate() {
    if (this.isSignIn) {
      return this.signInTemplate;
    } else {
      return this.signUpTemplate;
    }
  }

  showSignUp(){
    this.isSignIn = false;
  }

  showSignIn(){
    this.isSignIn = true;
  }

  signInWithGoogle() {
    return this._firebaseAuth.auth.signInWithPopup(
      new firebase.auth.GoogleAuthProvider()
    )
  }

  signInWithFacebook() {
    return this._firebaseAuth.auth.signInWithPopup(
      new firebase.auth.FacebookAuthProvider()
    )
  }
}
