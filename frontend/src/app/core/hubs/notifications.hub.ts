import { EventEmitter, Injectable } from '@angular/core';

import { HubConnection } from '@aspnet/signalr';
import * as signalR from '@aspnet/signalr';
import { environment } from '../../../environments/environment';
import { AuthService } from '../services/auth.service';
import { Notification } from '../../shared/models/notification.model';
import { NotificationType } from '../../shared/models/notification-type.enum';

import { Message } from '../../shared/models/message.model';


@Injectable({
  providedIn: 'root'
})
export class NotificationsHubService {
  private hubConnection: HubConnection | undefined;
  private connectionIsEstablished = false;

  notificationReceived = new EventEmitter<Notification>();
  notificationDeleted = new EventEmitter<number>();

  connectionEstablished = new EventEmitter<Boolean>();

  constructor(private authService: AuthService) {
    this.connectToSignalR();
  }

  private connectToSignalR(): void {
    this.createConnection();
    this.registerOnServerEvents();
    this.startNotificationHubConnection();
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

  private createConnection(): void {
    const firebaseToken = this.authService.getFirebaseToken();
    const watcherToken = this.authService.getWatcherToken();
    const connPath = `${environment.server_url}/notifications?Authorization=${firebaseToken}&WatcherAuthorization=${watcherToken}`;

    this.hubConnection = new signalR.HubConnectionBuilder()
      .withUrl(connPath) // {accessTokenFactory: () => firebaseToken}
      .configureLogging(signalR.LogLevel.Information)
      .build();
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

    // On Close open connection again
    this.hubConnection.onclose(function (error) {
      console.log('CONNECTION CLOSED!!!');
      console.error(error);
      this.startNotificationHubConnection();
    });
  }


  // Reconnect loop
  private startNotificationHubConnection(): void {
    console.log('Connecting to Hub!!!');
    this.hubConnection.start()
      .then(() => {
        console.log('Notification hub connected');
        this.connectionIsEstablished = true;
        this.connectionEstablished.emit(true);
      })
      .catch(function (err) {
        console.error('Error while establishing connection (Notification hub)...');
        setTimeout(this.startNotificationHubConnection(), 5000);
      });
  }
}
