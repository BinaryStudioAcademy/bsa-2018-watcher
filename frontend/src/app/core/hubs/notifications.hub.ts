import { EventEmitter, Injectable } from '@angular/core';

import { HubConnection } from '@aspnet/signalr';
import * as signalR from '@aspnet/signalr';
import { environment } from '../../../environments/environment';
import { AuthService } from '../services/auth.service';
import { Notification } from '../../shared/models/notification.model';
import { NotificationType } from '../../shared/models/notification-type.enum';

@Injectable()
export class NotificationsHubService {
  private hubConnection: HubConnection | undefined;
  private isConnect: boolean;

  notificationReceived = new EventEmitter<Notification>();
  notificationDeleted = new EventEmitter<number>();

  connectionEstablished = new EventEmitter<Boolean>();

  constructor(private authService: AuthService) {
    this.startNotificationsHubConnection();
  }

  private createConnection(firebaseToken: string, watcherToken: string): void {
    const connPath = `${environment.server_url}/notifications?Authorization=${firebaseToken}&WatcherAuthorization=${watcherToken}`;

    this.hubConnection = new signalR.HubConnectionBuilder()
      .withUrl(connPath) // {accessTokenFactory: () => firebaseToken}
      .configureLogging(signalR.LogLevel.Information)
      .build();
  }

  private startNotificationsHubConnection(): void {
    if (!this.authService.getCurrentUserLS()) { return; }
    if (this.isConnect) { return; }
    this.authService.getTokens().subscribe( ([firebaseToken, watcherToken]) => {
      this.createConnection(firebaseToken, watcherToken);
      console.log('NotificationsHub trying to connect');
      this.hubConnection.start()
        .then(() => {
          console.log('NotificationsHub connected');
          this.isConnect = true;
          this.registerOnServerEvents();
        })
        .catch(err => {
          console.error('Error while establishing connection (NotificationsHub)');
          setTimeout(this.startNotificationsHubConnection(), 3000);
        });
    });
  }

  send(notification: Notification, type: NotificationType) {
    if (this.hubConnection) {
      this.hubConnection.invoke('SendNotification', notification, type)
        .catch(err => console.error(err));
    }
  }

  delete(notification: Notification) {
    if (this.hubConnection) {
      this.hubConnection.invoke('DeleteNotification', notification)
        .catch(err => console.error(err));
    }
  }

  private registerOnServerEvents(): void {
    this.hubConnection.on('AddNotification', (data: Notification) => {
      console.log('Notification added');
      this.notificationReceived.emit(data);
    });

    this.hubConnection.on('DeleteNotification', (data: number) => {
      console.log('Notification deleted');
      this.notificationDeleted.emit(data);
    });

    this.hubConnection.onclose(err => {
      console.log('NotificationsHub connection closed');
      console.error(err);
      this.isConnect = false;
      this.startNotificationsHubConnection();
    });
  }
}
