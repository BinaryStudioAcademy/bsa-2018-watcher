import { Component, OnInit } from '@angular/core';
import { FormControl, FormBuilder, Validators } from '@angular/forms';
import { NotificationSetting } from '../../shared/models/notificationSetting';

@Component({
  selector: 'app-notification-settings',
  templateUrl: './notification-settings.component.html',
  styleUrls: ['./notification-settings.component.sass']
})
export class NotificationSettingsComponent implements OnInit {

  constructor(private fb: FormBuilder) {

   }

  ngOnInit() {
  }

}
