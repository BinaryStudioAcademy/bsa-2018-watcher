import {Component, OnInit, ViewChild} from '@angular/core';
import {AuthService} from '../core/services/auth.service';
import {Router} from '@angular/router';
import {TokenService} from '../core/services/token.service';
import {UserDto} from '../shared/models/user-dto';

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
  ) {
  }

  ngOnInit() {
  }

  showDialogSignIn(): void {
    this.display = true;
  }

  showDialogSignUp(): void {
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

  showSignUp(): void {
    this.isSignIn = false;
    this.isSuccessSignUp = false;
  }

  showSignIn(): void {
    this.isSignIn = true;
    this.isSuccessSignUp = false;
  }

  showNotRegisteredSignIn(): void {
    this.display = true;
    this.isSignIn = false;
    this.isNotRegisteredSignIn = true;
  }

  async signUpWithGoogle(): Promise<void> {
    const result = await this.authService.signInWithGoogle();

    this.currentUserCheck(result);
  }

  // TODO: change this to In
  async signInWithGoogle(): Promise<void> {
    await this.authService.signUpWithGoogle()
      .then(res => {
        this.closeDialog();
        this.signInPostProcessing(res);
      })
      .catch(err => {
        if (err) {
          if (err.status === 400) {
            console.log('AMA IN COMPONENT!!!');
            this.isSignIn = false;
            this.isSuccessSignUp = true;
            debugger;
            // TODO: Close providers window, open details
          }
        }
      });
  }

  async signUpWithGitHub(): Promise<void> {
    const result = await this.authService.signUpWithGitHub();
    this.closeDialog();

    this.signInPostProcessing(result);
  }

  async signUpWithFacebook(): Promise<void> {
    const result = await this.authService.signUpWithFacebook();
    this.closeDialog();

    this.signInPostProcessing(result);
  }

  async signUpWithTwitter(): Promise<void> {
    const result = await this.authService.signUpWithTwitter();
    this.closeDialog();

    this.signInPostProcessing(result);
  }

  async signInWithFacebook(): Promise<void> {
    const result = await this.authService.signInWithFacebook();

    this.currentUserCheck(result);
  }

  async signInWithTwitter(): Promise<void> {
    const result = await this.authService.signInWithTwitter();

    this.currentUserCheck(result);
  }

  async signInWithGitHub(): Promise<void> {
    const result = await this.authService.signInWithGitHub();

    this.currentUserCheck(result);
  }

  backToSignUp(): void {
    this.showSignUp();
  }

  closeDialog(): void {
    this.isSuccessSignUp = false;
    this.isSignIn = true;
    this.display = false;
  }

  currentUserCheck(result: boolean): void {
    const currentUser: UserDto = this.authService.getCurrentUser();

    if (currentUser == null) {
      this.showNotRegisteredSignIn();
    } else {
      this.closeDialog();
      this.signInPostProcessing(result);
    }
  }

  noRegistration(): void {
    this.display = false;
    this.router.navigate(['/']);
  }

  saveUserDetails(): void {
    this.closeDialog();
  }

  signInPostProcessing(result: boolean | void): Promise<boolean> {
    if (result) {
      return this.router.navigate(['/user/dashboards']);
    } else {
      return this.router.navigate(['/']);
    }
  }

}
