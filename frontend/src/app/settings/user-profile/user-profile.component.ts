import { Component, OnInit } from '@angular/core';
import { FormControl, FormBuilder, Validators } from '@angular/forms';
import { User } from 'firebase';

@Component({
  selector: 'app-user-profile',
  templateUrl: './user-profile.component.html',
  styleUrls: ['./user-profile.component.sass']
})
export class UserProfileComponent implements OnInit {

  constructor(private fb: FormBuilder) { }

  user: User;
  userForm = this.fb.group({
    firstName: new FormControl({ value: '', disabled: true  }, Validators.required),
    secondName: new FormControl({ value: '', disabled: true  }, Validators.required)
  });

  ngOnInit() {
  }

  editFirstName() {
    const ctrl = this.userForm.get('firstName');
    ctrl.enabled ? ctrl.disable() : ctrl.enable();
  }

  editSecondName() {
    const ctrl = this.userForm.get('secondName');
    ctrl.enabled ? ctrl.disable() : ctrl.enable();
  }

  onSubmit() {
    if (this.userForm.valid) {

    } else {
      Object.keys(this.userForm.controls).forEach(field => { // {1}
        const control = this.userForm.get(field);            // {2}
        control.markAsDirty({ onlySelf: true });
        control.enable();
      });
    }
  }

}
