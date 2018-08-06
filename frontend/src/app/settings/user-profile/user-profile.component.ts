import { Component, OnInit } from '@angular/core';
import { FormControl, FormBuilder } from '@angular/forms';
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
    firstName: [''],
    secondName: ['']
  });

  ngOnInit() {
  }

  onSubmit() {
    console.log('Ok');
  }

}
