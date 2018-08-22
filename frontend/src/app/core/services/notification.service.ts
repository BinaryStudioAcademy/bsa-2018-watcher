import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { Notification } from '../../shared/models/notification.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class NotificationService {

  private readonly ctrlUrl = 'Notifications';

  constructor(private apiService: ApiService) { }

  public getAll(id: string): Observable<Notification[]> {
    return this.apiService.get(`/${this.ctrlUrl}/${id}`) as Observable<Notification[]>;
  }
}
