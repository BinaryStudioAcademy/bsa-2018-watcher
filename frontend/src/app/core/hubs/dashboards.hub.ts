import {EventEmitter, Injectable} from '@angular/core';
import { HubConnection} from '@aspnet/signalr';
import * as signalR from '@aspnet/signalr';
import {environment} from '../../../environments/environment';
import {MarketPrice, MarketPriceDate} from '../../dashboards/models';
import {from, Observable, Subject} from 'rxjs';
import {PercentageInfo} from '../../dashboards/models/percentage-info';
import {ApiService} from '../services/api.service';
import {AuthService} from '../services/auth.service';


@Injectable({
  providedIn: 'root'
})
export class DashboardsHub {
  private connectionIsEstablished = false;
  private hubConnection: HubConnection | undefined;

  private infoSub = new Subject<PercentageInfo>();
  public infoSubObservable = from(this.infoSub);
  connectionEstablished = new EventEmitter<Boolean>();

  constructor(private apiService: ApiService,
              private authService: AuthService) {
  }

  public getInitialMarketStatusOld(): Observable<MarketPrice[]> {
    return this.apiService.get(`/Samples/MarketData`) as Observable<MarketPrice[]>;
  }

  public getInitialMarketStatus(): Observable<MarketPriceDate[]> {
    return this.apiService.get(`/Samples/MarketData`) as Observable<MarketPriceDate[]>;
  }

  public getInitialPercentageInfoByInstanceId(id: number): Observable<PercentageInfo[]> {
    return this.apiService.get(`/CollectedData/Percentage/${id}?count=20`) as Observable<PercentageInfo[]>;
  }

  connectToSignalR(): void {
    this.createConnection();
    this.registerOnServerEvents();
    this.startHubConnection();
  }

  subscribeToInstanceById(instanceGuidId: string): void {
    if (this.hubConnection) {
      this.hubConnection.invoke('SubscribeToInstanceById', instanceGuidId)
        .catch(err => console.error(err));
    }
  }

  unSubscribeFromInstanceById(instanceGuidId: string): void {
    if (this.hubConnection) {
      this.hubConnection.invoke('UnSubscribeFromInstanceById', instanceGuidId)
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

  private createConnection(): void {
    const firebaseToken = this.authService.getFirebaseToken();
    const watcherToken = this.authService.getWatcherToken();
    const connPath = `${environment.server_url}/dashboards?Authorization=${firebaseToken}&WatcherAuthorization=${watcherToken}`;

    this.hubConnection = new signalR.HubConnectionBuilder()
      .withUrl(connPath) // {accessTokenFactory: () => firebaseToken}
      .configureLogging(signalR.LogLevel.Information)
      .build();
  }

  private registerOnServerEvents(): void {

    this.hubConnection.on('InstanceDataTick', (info: PercentageInfo) => {
        this.infoSub.next(info);
      }
    );

    this.hubConnection.on('Send', (item: string) => {
      console.log(`Message from Service Bus: ${item}`);
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
