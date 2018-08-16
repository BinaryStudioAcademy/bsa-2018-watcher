import {Component, OnInit} from '@angular/core';
import {NotificationSettingsService} from '../../core/services/notification-settings.service';
import {SelectItem} from 'primeng/api';
import {NotificationType} from '../../shared/models/notification-type.enum';
import {AuthService} from '../../core/services/auth.service';
import {ToastrService} from '../../core/services/toastr.service';
import {NotificationSetting} from '../../shared/models/notification-setting.model';

@Component({
  selector: 'app-notification-settings',
  templateUrl: './notification-settings.component.html',
  styleUrls: ['./notification-settings.component.sass']
})
export class NotificationSettingsComponent implements OnInit {
  userId: string;
  dropdown: SelectItem[];
  notificationSettings: NotificationSetting[];
  selectedNotificationSetting: NotificationSetting;


  constructor(private service: NotificationSettingsService,
              private authService: AuthService,
              private toastrService: ToastrService) {
    this.dropdown = new Array<SelectItem>();
  }

  ngOnInit() {
    const user = this.authService.getCurrentUser();
    if (user == null) {
      return;
    } else {
      this.userId = user.id;
    }

    if (user.notificationSettings && user.notificationSettings.length === 0) {
      this.service.getByUserId(this.userId).subscribe((entities) => {
        this.notificationSettings = entities;
        if (this.notificationSettings) {
          this.fillDropdown();
          this.selectedNotificationSetting = this.notificationSettings[0];
        }
      });
    } else {
      this.notificationSettings = user.notificationSettings;
      this.fillDropdown();
      this.selectedNotificationSetting = this.notificationSettings[0];
    }
  }

  private fillDropdown(): void {
    this.notificationSettings.forEach(element => {
      this.dropdown.push({label: NotificationType[element.type], value: element});
    });
  }

  onSave() {
    if (this.selectedNotificationSetting && this.selectedNotificationSetting.isDisable) {
      this.toastrService.confirm(`Are you sure you want to disable all notifications
       ${NotificationType[this.selectedNotificationSetting.type]} type?`).then((value) => {
        if (value) {
          this.updateSetting();
        }
      });
    } else {
      this.updateSetting();
    }
  }

  private updateSetting(): void {
    this.service.update(this.selectedNotificationSetting.id, this.selectedNotificationSetting)
      .subscribe(value => {
          const user = this.authService.getCurrentUser();
          // TODO: Update User 1 Notification setting form array
          // user.notificationSettings = selectedNotificationSetting;
          this.toastrService.success('Notification setting was updated.');
        },
        err => {
          this.toastrService.error('Notification setting was not updated.');
        });
  }

}
