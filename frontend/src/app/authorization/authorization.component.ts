import { Component, OnInit, TemplateRef, ViewChild  } from '@angular/core';
import { AngularFireAuth } from 'angularfire2/auth';
import * as firebase from 'firebase/app';
import { AuthService } from '../core/services/auth.service';
import { Router } from '@angular/router';


@Component({
  selector: 'app-authorization',
  templateUrl: './authorization.component.html',
  styleUrls: ['./authorization.component.sass']
})
export class AuthorizationComponent implements OnInit {

  @ViewChild('signInTemplate') signInTemplate;
  @ViewChild('signUpTemplate') signUpTemplate;
  @ViewChild('userDetailsTemplate') userDetailsTemplate;

  display = false;
  isSignIn = true;
  isSuccessSignUp = false;

  companyName =  '';
  userName = '';
  userEmail = '';

  constructor(private authService: AuthService, private router: Router) {

   }

  ngOnInit() {
  }

  showDialogSignIn() {
    this.display = true;
  }

  showDialogSignUp() {
    this.display = true;
    this.isSignIn = false;
  }

  loadTemplate() {
    if (this.isSignIn) {
      return this.signInTemplate;
    } else if (this.isSuccessSignUp) {
      return this.userDetailsTemplate;
    } else {
      return this.signUpTemplate;
    }
  }

  showSignUp() {
    this.isSignIn = false;
    this.isSuccessSignUp = false;
  }

  showSignIn() {
    this.isSignIn = true;
    this.isSuccessSignUp = false;
  }

  signInWithTwitter() {
    //
  }

  signUpWithGoogle() {
    this.isSuccessSignUp = true;
  }

  signUpWithFacebook() {
    this.isSuccessSignUp = true;
  }

  signUpWithTwitter() {
    this.isSuccessSignUp = true;
  }

  saveUserDetails() {
    this.closeDialog();
  }

  closeDialog() {
    this.isSuccessSignUp = false;
    this.isSignIn = true;
    this.display = false;
  }

  signInWithGoogle() {
    this.authService.signInWithGoogle()
    .then((res) => {
        this.router.navigate(['landing']);
      })
    .catch((err) => console.log(err));
  }

  signInWithFacebook() {
    this.authService.signInWithFacebook()
    .then((res) => {
        this.router.navigate(['landing']);
      })
    .catch((err) => console.log(err));
  }

  beckToSignUp() {
    this.showSignUp();
  }
}

