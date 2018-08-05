import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { HubConnection } from '@aspnet/signalr';
import * as signalR from '@aspnet/signalr';
import {environment} from '../../../environments/environment';
import {SampleDto} from '../../shared/models/sample-dto.model';
import {SampleRequest} from '../../shared/models/sample-request.model';


@Injectable({
  providedIn: 'root'
})
export class NotificationsService {
  private _hubConnection: HubConnection | undefined;

  constructor(private http: HttpClient) {
    this.init();
  }

  send(userId: string, item: string): string {
    if (this._hubConnection) {
      this._hubConnection.invoke('Send', userId, item);
    }
    return item;
  }

  createSample(request: SampleRequest): SampleRequest {
    if (this._hubConnection) {
      this._hubConnection.invoke('CreateSample', request);
    }
    return request;
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

  private init() {
    const connPath = environment.server_url + '/notifications';
    this._hubConnection = new signalR.HubConnectionBuilder()
      .withUrl(connPath)
      .configureLogging(signalR.LogLevel.Information)
      .build();

    this.startConnection();

    this._hubConnection.on('Send', (item: string) => {
      console.log('Message from Hub: ' + item);
    });

    this._hubConnection.on('BroadcastMessage', (message: string) => {
      console.log('Broadcasted Message: ' + message);
    });

    this._hubConnection.on('Echo', (data: string) => {
      console.log('Received echo data from the hub');
      console.log(data);
    });

    this._hubConnection.on('DataFeedTick', (sampleDto: SampleDto) => {
      console.log(`Received Data feed from the hub: ${sampleDto}`);
    });

    this._hubConnection.on('AddSample', (sampleDto: SampleDto, secondParam: string, thirdParam: number) => {
      console.log(`secondParam: ${secondParam}, thirdParam: ${thirdParam}`);
      console.log('Created SampleDto: ' + JSON.stringify(sampleDto) + sampleDto);
    });

    // On Close open connection again
    this._hubConnection.onclose(function () {
      this.startConnection();
    });
  }

  // Reconnect loop
  private startConnection() {
    console.log('Conecting to Hub!!!');
    this._hubConnection.start().catch(function (err) {
      console.error(err.toString());
      setTimeout(function () {
        console.log('Recconecting to Hub!');
        this.startConnection();
      }, 3000);
    });
  }
}
