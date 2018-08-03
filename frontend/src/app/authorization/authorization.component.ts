import { Component, OnInit, TemplateRef, ViewChild  } from '@angular/core';

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

  constructor() { }

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

}
