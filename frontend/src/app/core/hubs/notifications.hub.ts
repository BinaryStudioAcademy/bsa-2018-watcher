import {EventEmitter, Injectable} from '@angular/core';

import {HubConnection} from '@aspnet/signalr';
import * as signalR from '@aspnet/signalr';
import {environment} from '../../../environments/environment';
import {SampleRequest} from '../../shared/models/sample-request.model';
import {ApiService} from '../services/api.service';
import {AuthService} from '../services/auth.service';
import { Notification } from '../../shared/models/notification.model';


@Injectable({
  providedIn: 'root'
})
export class NotificationsHubService {
  private connectionIsEstablished = false;
  private hubConnection: HubConnection | undefined;

  notificationReceived = new EventEmitter<Notification>();
  connectionEstablished = new EventEmitter<Boolean>();

  constructor(private authService: AuthService) {

  }

  connectToSignalR(firebaseToken: string, watcherToken: string): void {
    this.createConnection(firebaseToken, watcherToken);
      this.registerOnServerEvents();
      this.startNotificationHubConnection();
  }

  send(userId: string, item: string): string {
    if (this.hubConnection) {
      this.hubConnection.invoke('Send', userId, item)
                         .catch(err => console.error(err));
    }
    return item;
  }

  createSample(request: SampleRequest): SampleRequest {
    if (this.hubConnection) {
      this.hubConnection.invoke('CreateSample', request)
                         .catch(err => console.error(err));
    }
    return request;
  }

  sendMessage(mess: string): string {
    if (this.hubConnection) {
      this.hubConnection.invoke('BroadcastMessage', mess)
                         .catch(err => console.error(err));
    }
    return mess;
  }

  echo(): void {
    if (this.hubConnection) {
      this.hubConnection.invoke('Echo')
                         .catch(err => console.error(err));
    }
  }

  private createConnection(firebaseToken: string, watcherToken: string): void {
    const connPath = `${environment.server_url}/notifications?Authorization=${firebaseToken}&WatcherAuthorization=${watcherToken}`;

    this.hubConnection = new signalR.HubConnectionBuilder()
      .withUrl(connPath, ) // {accessTokenFactory: () => firebaseToken}
      .configureLogging(signalR.LogLevel.Information)
      .build();
  }

  private registerOnServerEvents(): void {
    this.hubConnection.on('AddNotification', (data: Notification) => {
      console.log(data);
      this.notificationReceived.emit(data);
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
