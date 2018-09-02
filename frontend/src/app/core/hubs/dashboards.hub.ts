import {Injectable} from '@angular/core';
import {HubConnection} from '@aspnet/signalr';
import * as signalR from '@aspnet/signalr';
import {environment} from '../../../environments/environment';
import {from, Observable, Subject} from 'rxjs';
import {PercentageInfo} from '../../dashboards/models/percentage-info';
import {ApiService} from '../services/api.service';
import {AuthService} from '../services/auth.service';
import {CollectedData} from '../../shared/models/collected-data.model';


@Injectable({
  providedIn: 'root'
})
export class DashboardsHub {
  private hubConnection: HubConnection | undefined;
  private connectionEstablishedSub = new Subject<boolean>();
  public connectionEstablished$ = from(this.connectionEstablishedSub);

  private infoSub = new Subject<PercentageInfo>();
  public infoSubObservable = from(this.infoSub);

  constructor(private apiService: ApiService,
              private authService: AuthService) {
  }

  connectToSignalR(): Promise<void> {
    this.createConnection();
    this.registerOnServerEvents();
    return this.startHubConnection();
  }

  getSignalRClaims() {
    if (this.hubConnection) {
      this.hubConnection.invoke('GetClaims')
        .catch(err => console.error(err));
    }
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

    this.hubConnection.on('InstanceDataTick', (info: CollectedData) => {
        this.infoSub.next(info);
      }
    );

    this.hubConnection.on('UserClaimsData', (claimsData: any[]) => {
      console.log(claimsData);
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
  private startHubConnection(): Promise<void> {
    return this.hubConnection.start()
      .then(() => {
        this.connectionEstablishedSub.next(true);
        // this.getSignalRClaims();
      })
      .catch(function (err) {
        console.error(err);
        setTimeout(this.startHubConnection(), 3000);
      });
  }
}
