import {Injectable} from '@angular/core';
import {HubConnection} from '@aspnet/signalr';
import * as signalR from '@aspnet/signalr';
import {environment} from '../../../environments/environment';
import {from, Observable, Subject} from 'rxjs';
import {PercentageInfo} from '../../dashboards/models/percentage-info';
import {ApiService} from '../services/api.service';
import {AuthService} from '../services/auth.service';
import {CollectedData} from '../../shared/models/collected-data.model';


@Injectable()
export class DashboardsHub {
  private isConnect: boolean;
  private hubConnection: HubConnection | undefined;
  private connectionEstablishedSub = new Subject<boolean>();
  public connectionEstablished$ = from(this.connectionEstablishedSub);

  private infoSub = new Subject<PercentageInfo>();
  public infoSubObservable = from(this.infoSub);

  constructor(private apiService: ApiService,
              private authService: AuthService) {
  }

  connectToSignalR(firebaseToken: string, watcherToken: string): Promise<void> {
    this.createConnection(firebaseToken, watcherToken);
    this.registerOnServerEvents();
    return this.startDashboardHubConnection();
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

  private createConnection(firebaseToken: string, watcherToken: string): void {
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
    this.hubConnection.onclose(err => {
      console.log('DashboardHub connection closed');
      console.error(err);
      this.isConnect = false;
      this.startDashboardHubConnection();
    });
  }


  // Reconnect loop
  private startDashboardHubConnection(): Promise<void> {
    if (this.isConnect) { return; }
    console.log('DashboardHub trying to connect');
    return this.hubConnection.start()
      .then(() => {
        console.log('DashboardHub connected');
        this.connectionEstablishedSub.next(true);
        // this.getSignalRClaims();
      })
      .catch(err => {
        console.log('Error while establishing connection (DashboardHub)');
        console.error(err);
        setTimeout(this.startDashboardHubConnection(), 3000);
      });
  }
}
