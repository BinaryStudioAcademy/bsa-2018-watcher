import { Component, OnInit } from '@angular/core';
import { FormControl, FormBuilder, Validators } from '@angular/forms';
import { UserUpdate } from '../../shared/models/userUpdate';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-user-profile',
  templateUrl: './user-profile.component.html',
  styleUrls: ['./user-profile.component.sass']
})
export class UserProfileComponent implements OnInit {

  constructor(private fb: FormBuilder,
              private httpClient: HttpClient) { }

  user: UserUpdate;
  userForm = this.fb.group({
    firstName: new FormControl({ value: '', disabled: true  }, Validators.required),
    secondName: new FormControl({ value: '', disabled: true  }, Validators.required),
    isActive: new FormControl({ value: '', disabled: true }, Validators.required),
    nickName: new FormControl({ value: '', disabled: true }),
    bio: new FormControl({ value: '', disabled: true })
  });

  ngOnInit() {
    this.user = {
      firstName: 'Neo',
      secondName: 'Anderson',
      isActive: true,
      notificationSettingId: 5,
      nickName: '',
      bio: 'MyBio'
    };

    this.setUserData();

    this.userForm.valueChanges.subscribe(value => {
      this.user = value;
    });
  }

  setUserData() {
    Object.keys(this.userForm.controls).forEach(field => {
      const control = this.userForm.get(field);
      control.setValue(this.user[field]);
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
      this.httpClient.put('http://localhost:60785/api/users/070ac039-69ee-4afc-8ddf-034a4d1f84e3', this.user).subscribe(value => {
        console.log(value);
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
