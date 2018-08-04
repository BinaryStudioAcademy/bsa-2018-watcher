import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { HubConnection } from '@aspnet/signalr';
import * as signalR from '@aspnet/signalr';


@Injectable({
  providedIn: 'root'
})
export class NotificationsService {
  private _hubConnection: HubConnection | undefined;

  constructor(private http: HttpClient) {
    this.init();
  }

  send(item: string): string {
    if (this._hubConnection) {
      this._hubConnection.invoke('Send', item);
    }
    return item;
  }

  sendMessage(mess: string): string {
    if (this._hubConnection) {
      this._hubConnection.invoke('BroadcastMessage', mess);
    }
    return mess;
  }

  echo() {
    if (this._hubConnection) {
      this._hubConnection.invoke('Echo');
    }
  }

  joinGroup(group: string): void {
    if (this._hubConnection) {
      this._hubConnection.invoke('JoinGroup', group);
    }
  }

  leaveGroup(group: string): void {
    if (this._hubConnection) {
      this._hubConnection.invoke('LeaveGroup', group);
    }
  }

  private init() {

    this._hubConnection = new signalR.HubConnectionBuilder()
      .withUrl('http://localhost:29878/notifications')
      .configureLogging(signalR.LogLevel.Information)
      .build();

    this._hubConnection.start().catch(err => console.error(err.toString()));

    this._hubConnection.on('Send', (item: string) => {
      console.log('Message from Hub: ' + item);
    });

    this._hubConnection.on('BroadcastMessage', (message: string) => {
      console.log('Broadcasted Message: ' + message);
    });

    this._hubConnection.on('JoinGroup', (data: string) => {
      console.log('recieved data from the hub');
      console.log(data);
    });

    this._hubConnection.on('LeaveGroup', (data: string) => {
      console.log('You left the group: ' + data);
    });
  }
}
