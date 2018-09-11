import {Injectable} from '@angular/core';
import {HubConnection} from '@aspnet/signalr';
import * as signalR from '@aspnet/signalr';
import {environment} from '../../../environments/environment';
import {from, Subject} from 'rxjs';
import {AuthService} from '../services/auth.service';
import {CollectedData} from '../../shared/models/collected-data.model';


@Injectable()
export class DashboardsHub {
  private hubName = 'dashboards';
  private isConnect: boolean;
  private hubConnection: HubConnection | undefined;
  private connectionEstablishedSub = new Subject<boolean>();
  public connectionEstablished$ = from(this.connectionEstablishedSub);

  private infoSub = new Subject<CollectedData>();
  public infoSubObservable = from(this.infoSub);

  constructor(private authService: AuthService) {
    this.startConnection();
  }

  private startConnection(): void {
    if (this.isConnect) { return; }
    this.authService.getTokens().subscribe(([firebaseToken, watcherToken]) => {
      this.buildConnection(firebaseToken, watcherToken);
      console.log('Dashboards Hub trying to connect');
      this.hubConnection
        .start()
        .then(() => {
          console.log('Dashboards Hub connected');
          this.isConnect = true;
          this.connectionEstablishedSub.next(true);
          this.registerOnEvents();
        })
        .catch(err => {
          console.log('Error while establishing connection (Dashboards Hub)');
          setTimeout(this.startConnection(), 3000);
        });
    });
  }

  private buildConnection(firebaseToken: string, watcherToken: string) {
    const connPath = `${environment.server_url}/${this.hubName}?Authorization=${firebaseToken}&WatcherAuthorization=${watcherToken}`;

    this.hubConnection = new signalR.HubConnectionBuilder()
      .withUrl(connPath)
      .configureLogging(signalR.LogLevel.Information)
      .build();
  }

  private registerOnEvents(): void {
    this.hubConnection.on('InstanceDataTick', (info: CollectedData) => {
        info.time = new Date(info.time);
        this.infoSub.next(info);
      });

    this.hubConnection.on('UserClaimsData', (claimsData: any[]) => {
        console.log(claimsData);
      });

    this.hubConnection.on('Send', (item: string) => {
      console.log(`Message from Service Bus: ${item}`);
    });

    // On Close open connection again
    this.hubConnection.onclose((error: Error) => {
      this.isConnect = false;
      this.connectionEstablishedSub.next(false);
      console.log('Dashboard Hub connection closed');
      console.error(error);
      this.startConnection();
    });
  }


  // Reconnect loop
  // private startDashboardHubConnection(): Promise<void> {
  //   if (this.isConnect) {
  //     return;
  //   }
  //   console.log('DashboardHub trying to connect');
  //   return this.hubConnection.start()
  //     .then(() => {
  //       console.log('DashboardHub connected');
  //       this.connectionEstablishedSub.next(true);
  //       this.isConnect = true;
  //       // this.getSignalRClaims();
  //     })
  //     .catch(err => {
  //       console.log('Error while establishing connection (DashboardHub)');
  //       console.error(err);
  //       setTimeout(this.startDashboardHubConnection(), 3000);
  //     });
  // }

  // connectToSignalR(firebaseToken: string, watcherToken: string): Promise<void> {
  //   this.buildConnection(firebaseToken, watcherToken);
  //   this.registerOnEvents();
  //   return this.startDashboardHubConnection();
  // }

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
}
