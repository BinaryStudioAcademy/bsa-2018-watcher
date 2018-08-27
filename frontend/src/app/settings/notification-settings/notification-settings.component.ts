import {Component, OnInit} from '@angular/core';
import {NotificationSettingsService} from '../../core/services/notification-settings.service';
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
  notificationSettings: NotificationSetting[];
  notificationTypes = NotificationType;
  isSaving: Boolean = false;

  constructor(private service: NotificationSettingsService,
              private authService: AuthService,
              private toastrService: ToastrService) {
  }

  ngOnInit() {
    const user = this.authService.getCurrentUser();
    if (user == null) {
      return;
    } else {
      this.userId = user.id;
    }

    this.service.getByUserId(this.userId).subscribe((entities) => {
      this.notificationSettings = entities;
    });
  }

  onDisable(id: number): void {
    const disablingNotificationSettings = this.notificationSettings.find(item => item.id === id);

    if (disablingNotificationSettings.isDisable === false) { return; }

    this.toastrService.confirm(`Are you sure you want to disable all notifications
       ${NotificationType[disablingNotificationSettings.type]} type?`).then((value) => {
        if (!value) {
          disablingNotificationSettings.isDisable = false;
        } else {
          disablingNotificationSettings.isMute = false;
          disablingNotificationSettings.isEmailable = false;
        }
      });
  }

  onSave() {
    this.isSaving = true;

    this.service.updateAll(this.notificationSettings)
      .subscribe(() => {
          this.toastrService.success('Notification setting was updated.');
          this.isSaving = false;
        },
        err => {
          this.toastrService.error('Notification setting was not updated.');
          this.isSaving = false;
        });
  }

}
