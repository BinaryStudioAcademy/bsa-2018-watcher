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

  display: boolean = false;
  isSignIn: boolean = true;

  constructor(private authService: AuthService, private router: Router) {

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
    this.authService.signInWithGoogle()
    .then((res) => { 
        this.router.navigate(['landing'])
      })
    .catch((err) => console.log(err));
  }

  signInWithFacebook() {
    this.authService.signInWithFacebook()
    .then((res) => { 
        this.router.navigate(['landing'])
      })
    .catch((err) => console.log(err));
  }
}
