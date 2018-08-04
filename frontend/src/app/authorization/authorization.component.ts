import { Component, OnInit, TemplateRef, ViewChild  } from '@angular/core';


@Component({
  selector: 'app-authorization',
  templateUrl: './authorization.component.html',
  styleUrls: ['./authorization.component.sass']
})
export class AuthorizationComponent implements OnInit {

  @ViewChild('signInTemplate') signInTemplate;
  @ViewChild('signUpTemplate') signUpTemplate;
  @ViewChild('userDetailsTemplate') userDetailsTemplate;

  display: boolean = false;
  isSignIn: boolean = true;
  isSuccessSignUp = false;

  constructor() { }

  ngOnInit() {
  }

  showDialog() {
    this.display = true;
  }

  loadTemplate() {
    if (this.isSignIn) {
      return this.signInTemplate;
    } 
    else if(this.isSuccessSignUp) {
      return this.userDetailsTemplate;
    }
    else{
      return this.signUpTemplate;
    }
  }

  showSignUp(){
    this.isSignIn = false;
  }

  showSignIn(){
    this.isSignIn = true;
  }

  signInWithGoogle(){
    
  }

  signInWithFacebook(){
    
  }

  signInWithTwitter(){
    
  }

  signUpWithGoogle(){
    this.isSuccessSignUp = true;
  }

  signUpWithFacebook(){
    this.isSuccessSignUp = true;
  }

  signUpWithTwitter(){
    this.isSuccessSignUp = true;
  }

  saveUserDetails(){
    this.isSuccessSignUp = false;
    this.isSignIn = true;
    this.display = false;
  }


}
