import { Component, OnInit, ViewChild } from '@angular/core';
import { AuthService } from '../core/services/auth.service';
import { Router } from '@angular/router';
import { TokenService } from '../core/services/token.service';

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
  isFetching = false;
  emailExists = false;

  companyName = '';
  lastName = '';
  firstName = '';
  userEmail = '';

  constructor(
    private authService: AuthService,
    private tokenService: TokenService,
    private router: Router
  ) {
  }

  ngOnInit() {
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

  showSignUp(): void {
    this.isSignIn = false;
    this.isSuccessSignUp = false;
  }

  showSignIn(): void {
    this.isSignIn = true;
    this.isSuccessSignUp = false;
  }

  showDialogSignUp(): void {
    this.display = true;
    this.isSignIn = false;
  }

  closeDialog(): void {
    this.isSuccessSignUp = false;
    this.isSignIn = true;
    this.display = false;
  }

  noRegistration(): void {
    this.display = false;
    this.router.navigate(['/']);
  }

  async signInWithGoogle(): Promise<void> {
    this.isFetching = true;
    await this.authService.signInWithGoogle()
      .then(result => {
        if (result) {
          this.closeDialog();
          this.signInPostProcessing(result);
        }
        this.isFetching = false;
        this.fetchExistingData();
      })
      .catch(err => {
        if (err) {
          if (err.status === 400) {
            this.isSignIn = false;
            this.isSuccessSignUp = true;
          }
        }
        this.isFetching = false;
        this.fetchExistingData();
      });
  }

  async signInWithFacebook(): Promise<void> {
    this.isFetching = true;
    await this.authService.signInWithFacebook()
      .then(result => {
        if (result) {
          this.closeDialog();
          this.signInPostProcessing(result);
        }
        this.isFetching = false;
        this.fetchExistingData();
      })
      .catch(err => {
        console.log(err);
        if (err) {
          if (err.status === 400) {
            this.isSignIn = false;
            this.isSuccessSignUp = true;
          }
        }
        this.isFetching = false;
        this.fetchExistingData();
      });
  }

  async signInWithGitHub(): Promise<any> {
    this.isFetching = true;
    await this.authService.signInWithGitHub()
      .then(result => {
        if (result) {
          this.closeDialog();
          this.signInPostProcessing(result);
        }
        this.isFetching = false;
        this.fetchExistingData();
      })
      .catch(err => {
        if (err) {
          if (err.status === 400) {
            this.isSignIn = false;
            this.isSuccessSignUp = true;
          }
        }
        this.isFetching = false;
        this.fetchExistingData();
      });
  }

  async saveUserDetails(): Promise<void> {
    await this.authService.signUpWithProvider(this.companyName, this.firstName, this.lastName, this.userEmail)
      .then(res => {
        this.closeDialog();
        this.signInPostProcessing(true);
      })
      .catch(err => {
        if (err) {
          this.closeDialog();
          console.log(err);
        }
      });
  }

  onContinueLaterClick(): void {
    // default data
    this.companyName = 'MyCompany';
    if (this.firstName === '') {
      this.firstName = 'MyFirstName';
    }
    if (this.lastName === '') {
      this.lastName = 'MyLastName';
    }
    this.saveUserDetails();
  }

  signInPostProcessing(result: boolean): Promise<boolean> {
    if (result) {
      return this.router.navigate(['/user']);
    } else {
      return this.router.navigate(['/']);
    }
  }

  fetchExistingData() {
    this.firstName = this.authService.userRegisterRequest.firstName;
    this.lastName = this.authService.userRegisterRequest.lastName;
    this.userEmail = this.authService.userRegisterRequest.email;
    if (this.userEmail !== null){
      this.emailExists = true;
    }
  }
}
