import { Component, OnInit } from '@angular/core';
import { NotificationSetting } from '../../shared/models/notificationSetting';
import { NotificationType } from '../../shared/enums/notificationType';
import { NotificationSettingsService } from '../../core/services/notification-settings.service';
import {SelectItem} from 'primeng/api';

@Component({
  selector: 'app-notification-settings',
  templateUrl: './notification-settings.component.html',
  styleUrls: ['./notification-settings.component.sass']
})
export class NotificationSettingsComponent implements OnInit {
  dropdown: SelectItem[];
  notificationSettings: NotificationSetting[];
  selectedNotificationSetting: NotificationSetting;


  constructor(private service: NotificationSettingsService) {
    this.notificationSettings = this.service.getDefaultData();
    this.selectedNotificationSetting = this.notificationSettings[0];
    this.dropdown = [
      {label: NotificationType[this.notificationSettings[0].type], value: this.notificationSettings[0]},
      {label: NotificationType[this.notificationSettings[1].type], value: this.notificationSettings[1]},
    ];
    }

  ngOnInit() {

  }

  onSubmit() {
  }

}
