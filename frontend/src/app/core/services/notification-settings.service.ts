import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { NotificationSetting } from '../../shared/models/notificationSetting';
import { NotificationType } from '../../shared/models/notification-type.enum';
import { environment } from '../../../environments/environment';


@Injectable({
  providedIn: 'root'
})
export class NotificationSettingsService {
  url: string;
  constructor(private http: HttpClient) {
   this.url = environment.server_url;
  }

  getNotificationSettings(userId: number):  NotificationSetting[] {
   // let entity = this.http.get<Array<NotificationSetting>>(this.url + '/' + userId);

      let notificationSettings: NotificationSetting[];
      notificationSettings = [
        { id: 1, type: NotificationType.Chat, isDisable: false, isMute: false },
        { id: 1, type: NotificationType.System, isDisable: false, isMute: true }
      ];
      return notificationSettings;
  }
}
