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
    this.dropdown = new Array<SelectItem>();
    this.notificationSettings = this.service.getDefaultData();
    this.selectedNotificationSetting = this.notificationSettings[0];
    this.fillDropdown(this.notificationSettings);
  }

  ngOnInit() {

  }

  onSubmit() {
  }

  private fillDropdown(notificationSettings: NotificationSetting[]) {
    notificationSettings.forEach(element => {
      this.dropdown.push({label: NotificationType[element.type], value: element});
    });
  }

}
