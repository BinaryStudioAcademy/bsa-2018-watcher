import { Injectable } from '@angular/core';
import { Observable } from '../../../../node_modules/rxjs';
import { ApiService } from '../../shared/services/api.service';
import { NotificationSetting } from '../../shared/models/notification-setting.model';

@Injectable({
  providedIn: 'root'
})
export class NotificationSettingsService {
  private readonly ctrlUrl = 'NotificationSettings';

  constructor(private apiService: ApiService) { }

  public update(id: number, entity: NotificationSetting): Observable<Object> {
    return this.apiService.put(`/${this.ctrlUrl}/${id}`, entity);
  }

  public getByUserId(userId: string): Observable<NotificationSetting[]> {
    return this.apiService.get(`/${this.ctrlUrl}/${userId}`) as Observable<NotificationSetting[]>;
  }
}