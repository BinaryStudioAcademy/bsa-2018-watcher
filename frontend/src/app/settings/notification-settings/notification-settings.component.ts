import { Component, OnInit } from '@angular/core';
import { NotificationSettingsService } from '../../core/services/notification-settings.service';
import { SelectItem } from 'primeng/api';
import { NotificationType } from '../../shared/models/notification-type.enum';
import { AuthService } from '../../core/services/auth.service';
import { ToastrService } from '../../core/services/toastr.service';
import { NotificationSetting } from '../../shared/models/notification-setting.model';

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
    this.userId = this.authService.getCurrentUser().id;
    this.service.getByUserId(this.userId).subscribe((entitys) => {
      this.notificationSettings = entitys;
      if (this.notificationSettings) {
        this.fillDropdown();
        this.selectedNotificationSetting = this.notificationSettings[0];
      }
    });
  }

  private fillDropdown() {
    this.notificationSettings.forEach(element => {
      this.dropdown.push({label: NotificationType[element.type], value: element});
    });
  }

  onSave() {
    if (this.selectedNotificationSetting && this.selectedNotificationSetting.isDisable) {
      this.toastrService.confirm('Are you sure you want to disable all notifications?').then((value) => {
        if (value) {
          this.updateSetting();
        }
      });
    } else {
      this.updateSetting();
    }
  }

  private updateSetting() {
    this.service.update(this.selectedNotificationSetting.id, this.selectedNotificationSetting)
    .subscribe(value => {
      this.toastrService.success('Notification setting was updated.');
    },
    err => {
      this.toastrService.error('Notification setting was not updated.');
    });
  }

}
