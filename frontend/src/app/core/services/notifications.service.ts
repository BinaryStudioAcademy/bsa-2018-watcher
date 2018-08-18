import {EventEmitter, Injectable} from '@angular/core';

import {HttpClient, HubConnection} from '@aspnet/signalr';
import * as signalR from '@aspnet/signalr';
import {environment} from '../../../environments/environment';
import {SampleDto} from '../../shared/models/sample-dto.model';
import {SampleRequest} from '../../shared/models/sample-request.model';
import {ApiService} from './api.service';
import {AuthService} from './auth.service';
import {MarketPrice} from '../../dashboards/models/market-price';
import {from, Observable, Subject} from 'rxjs';
import {User} from '../../shared/models/user.model';
import {catchError, map} from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class NotificationsService {
  private connectionIsEstablished = false;
  private hubConnection: HubConnection | undefined;
  private marketSub = new Subject<MarketPrice>();
  public marketSubObservable = from(this.marketSub);

  sampleReceived = new EventEmitter<SampleDto>();
  connectionEstablished = new EventEmitter<Boolean>();

  constructor(private apiService: ApiService,
              private authService: AuthService) {
  }

  public getInitialMarketStatus(): Observable<MarketPrice[]> {
    // const url = `${environment.server_url}`;
    // return this.http.get(url, {params})
    //   .pipe(map(this.extractData),
    //     catchError(this.handleError));
    return this.apiService.get(`/Samples/MarketData`) as Observable<MarketPrice[]>;
  }

  // getUpdates() {
    // let socket = socketio(this.baseUrl);
    // let marketSub = new Subject<MarketPrice>();
    // let marketSubObservable = from(marketSub);

    // socket.on('market', (marketStatus: MarketPrice) => {
    //   marketSub.next(marketStatus);
    // });

    // return marketSubObservable;
  // }

  connectToSignalR(): void {
    this.createConnection();
    this.registerOnServerEvents();
    this.startHubConnection();
  }

  subscribeToMarketDataFeed() {
    if (this.hubConnection) {
      this.hubConnection.invoke('SubscribeToMarketDataFeed')
        .catch(err => console.error(err));
    }
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
    this.hubConnection.on('MarketTick', (marketStatus: MarketPrice) => {
        this.marketSub.next(marketStatus);
      }
    );

    this.hubConnection.on('Send', (data: any) => {
      console.log('Data received:' + data);
      this.sampleReceived.emit(data);
    });

    this.hubConnection.on('Send', (item: string) => {
      console.log('Message from Hub: ' + item);
    });

    this.hubConnection.on('BroadcastMessage', (message: string) => {
      console.log('Broadcasted Message: ' + message);
    });

    this.hubConnection.on('Echo', (data: string) => {
      console.log('Received echo data from the hub');
      console.log(data);
    });

    this.hubConnection.on('DataFeedTick', (sampleDto: SampleDto) => {
      console.log(`Received Data feed from the hub: ${JSON.stringify(sampleDto)}`);
    });

    this.hubConnection.on('AddSample', (sampleDto: SampleDto, secondParam: string, thirdParam: number) => {
      console.log(`secondParam: ${secondParam}, thirdParam: ${thirdParam}`);
      console.log('Created SampleDto: ' + JSON.stringify(sampleDto) + sampleDto);
      this.sampleReceived.emit(sampleDto);
    });

    // On Close open connection again
    this.hubConnection.onclose(function (error) {
      console.log('CONNECTION CLOSED!!!');
      console.error(error);
      this.startHubConnection();
    });
  }


  // Reconnect loop
  private startHubConnection(): void {
    console.log('Connecting to Hub!!!');
    this.hubConnection.start()
      .then(() => {
        console.log('CONNECTION STARTED!!!');
        this.connectionIsEstablished = true;
        this.connectionEstablished.emit(true);
      })
      .catch(function (err) {
        console.error(err);
        setTimeout(this.startHubConnection(), 3000);
      });
  }
}
