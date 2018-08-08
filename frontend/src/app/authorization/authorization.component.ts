import { Component, OnInit, ViewChild } from '@angular/core';
import { AuthService } from '../core/services/auth.service';
import { Router } from '@angular/router';
import {TokenService} from '../core/services/token.service';
import { UserDto } from '../shared/models/user-dto';

@Component({
  selector: 'app-authorization',
  templateUrl: './authorization.component.html',
  styleUrls: ['./authorization.component.sass']
})
export class AuthorizationComponent implements OnInit {

  @ViewChild('signInTemplate') signInTemplate;
  @ViewChild('signUpTemplate') signUpTemplate;
  @ViewChild('userDetailsTemplate') userDetailsTemplate;
  @ViewChild('notRegisteredSignInTemplate') notRegisteredSignInTemplate;

  display = false;
  isSignIn = true;
  isSuccessSignUp = false;
  isNotRegisteredSignIn = false;

  companyName = '';
  lastName = '';
  firstName = '';

  constructor(
    private authService: AuthService,
    private tokenService: TokenService,
    private router: Router
  ) { }

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
    } else if (this.isNotRegisteredSignIn) {
      return this.notRegisteredSignInTemplate;
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

  showNotRegisteredSignIn() {
    this.display = true;
    this.isSignIn = false;
    this.isNotRegisteredSignIn = true;
  }

  async signUpWithGoogle() {
    const result = await this.authService.signUpWithGoogle();
    this.closeDialog();
    // this.isSuccessSignUp = true;

    if (result) {
      return this.router.navigate(['/user/dashboards']);
    } else {
      return this.router.navigate(['/']);
    }
  }

  signUpWithGitHub() {
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

  async signInWithGoogle() {
    const result = await this.authService.signInWithGoogle();

    const currentUser: UserDto  = this.authService.getCurrentUser();
    

    if (currentUser == null) {
      this.showNotRegisteredSignIn();
    } else {
        this.closeDialog();
      // this.isSuccessSignUp = true;

      if (result) {
        return this.router.navigate(['/user/dashboards']);
      } else {
        return this.router.navigate(['/']);
      }
    }
  }


  signInWithFacebook() {
    this.authService.signInWithFacebook()
      .then((res) => {

        // var token : FirebaseCredential = res.credential;
        // var user : firebase.User = res.user;

        this.router.navigate(['landing']);
      })
      .catch((err) => console.log(err));
  }

  signInWithTwitter() {
    this.authService.signInWithTwitter()
      .then((res) => {
        // var token : FirebaseCredential = res.credential;
        // var user : firebase.User = res.user;

        this.router.navigate(['landing']);
      })
      .catch((err) => console.log(err));
  }

  signInWithGitHub() {
    this.authService.signInWithGitHub()
      // .then((res) => {
      //   debugger;
      //   var token: FirebaseCredential = res.credential;
      //   var user = res.user.getIdToken(true).then(idToken => {
      //     var i = idToken;
      //     console.log(i);
      //     debugger;
      //   });
      //   //firebase.auth().currentUser.getIdToken(true);
      //   debugger;
      //   this.router.navigate(['landing']);
      // })
      .catch((err) => console.log(err));
  }


  backToSignUp() {
    this.showSignUp();
  }

  noRegistration() {
    this.display = false;
    this.router.navigate(['/']);
  }

}
