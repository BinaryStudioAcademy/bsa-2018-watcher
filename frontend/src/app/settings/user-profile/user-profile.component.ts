import { Component, OnInit } from '@angular/core';
import { FormControl, FormBuilder, Validators } from '@angular/forms';
import { UserService } from '../../core/services/user.service';
import { AuthService } from '../../core/services/auth.service';
import { User } from '../../shared/models/user.model';
import { ToastrService } from '../../core/services/toastr.service';

@Component({
  selector: 'app-user-profile',
  templateUrl: './user-profile.component.html',
  styleUrls: ['./user-profile.component.sass']
})
export class UserProfileComponent implements OnInit {

  constructor(private fb: FormBuilder,
              private userService: UserService,
              private authService: AuthService,
              private toastrService: ToastrService) { }

  private user: User;
  private userId: string;
  private canUpdate: boolean;

  public userForm = this.fb.group({
    displayName: new FormControl({ value: '', disabled: true }, Validators.required),
    firstName: new FormControl({ value: '', disabled: true  }, Validators.required),
    secondName: new FormControl({ value: '', disabled: true  }, Validators.required),
    bio: new FormControl({ value: '', disabled: true })
  });

  ngOnInit() {
    this.userId = this.authService.getCurrentUser().id;
    this.userService.get(this.userId).subscribe((value) => {
      this.user = value;
      this.setUserData();
    });
  }

  setUserData() {
    Object.keys(this.userForm.controls).forEach(field => {
      const control = this.userForm.get(field);
      control.setValue(this.user[field]);
    });

    this.userForm.valueChanges.subscribe(value => {
      Object.keys(this.userForm.controls).forEach(field => {
        this.user[field] = this.userForm.get(field).value;
      });
    });
  }

  enableEditing() {
    Object.keys(this.userForm.controls).forEach(field => {
      const control = this.userForm.get(field);
      control.enabled ? control.disable() : control.enable();
    });

    this.canUpdate ? this.canUpdate = false : this.canUpdate = true;
  }

  onSubmit() {
    if (this.userForm.valid) {
      this.userService.update(this.userId, this.user).subscribe(value => {
        this.toastrService.success('Profile was updated');
        this.enableEditing();
      },
      err => {
        this.toastrService.error('Profile was not updated');
      });
    } else {
      Object.keys(this.userForm.controls).forEach(field => {
        const control = this.userForm.get(field);
        control.markAsDirty({ onlySelf: true });
        control.enable();
      });
    }
  }

}
