import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { NotificationSetting } from '../../shared/models/notificationSetting';
import { NotificationType } from '../../shared/enums/notificationType';

@Injectable({
  providedIn: 'root'
})
export class NotificationSettingsService {

  constructor(private http: HttpClient) {

  }

  getNotificationSettings(userId: number):  NotificationSetting[] {
    /* return this.http.get<NotificationSetting[]>('/api/settings/notificationSetting')
      .pipe(
        map(response => {
          return response;
        })
      ); */
      let notificationSettings: NotificationSetting[];
      notificationSettings = [
        { id: 1, type: NotificationType.Chat, isDisable: false, isMute: false },
        { id: 1, type: NotificationType.System, isDisable: false, isMute: true }
      ];
      return notificationSettings;
  }
}
