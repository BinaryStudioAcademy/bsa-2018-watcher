import { Component, OnInit } from '@angular/core';
import { FormControl, FormBuilder, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { UserService } from '../../core/services/user.service';
import { User } from '../../shared/models/user';
import { AuthService } from '../../core/services/auth.service';

@Component({
  selector: 'app-user-profile',
  templateUrl: './user-profile.component.html',
  styleUrls: ['./user-profile.component.sass']
})
export class UserProfileComponent implements OnInit {

  constructor(private fb: FormBuilder,
              private httpClient: HttpClient,
              private userService: UserService) { }

  private user: User;
  private userId: string;
  private userForm = this.fb.group({
    firstName: new FormControl({ value: '', disabled: true  }, Validators.required),
    secondName: new FormControl({ value: '', disabled: true  }, Validators.required),
    isActive: new FormControl({ value: '', disabled: true }, Validators.required),
    nickName: new FormControl({ value: '', disabled: true }),
    bio: new FormControl({ value: '', disabled: true })
  });

  ngOnInit() {
    this.userId = 'User uid from database';
    this.userService.get(this.userId).subscribe((value: User) => {
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
      this.user = value;
    });
  }

  edit() {
    Object.keys(this.userForm.controls).forEach(field => {
      const control = this.userForm.get(field);
      control.enabled ? control.disable() : control.enable();
    });
  }

  onSubmit() {
    console.log(this.userForm.valid);
    if (this.userForm.valid) {
      this.userService.update(this.userId, this.user);
    } else {
      Object.keys(this.userForm.controls).forEach(field => {
        const control = this.userForm.get(field);
        control.markAsDirty({ onlySelf: true });
        control.enable();
      });
    }
  }

}
