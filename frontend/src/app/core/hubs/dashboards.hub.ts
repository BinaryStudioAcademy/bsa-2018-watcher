import {Injectable, EventEmitter} from '@angular/core';
import {HubConnection} from '@aspnet/signalr';
import * as signalR from '@aspnet/signalr';
import {environment} from '../../../environments/environment';
import {from, Subject} from 'rxjs';
import {AuthService} from '../services/auth.service';
import {CollectedData} from '../../shared/models/collected-data.model';
import {InstanceChecked} from '../../shared/models/instance-checked';


@Injectable()
export class DashboardsHub {
  private hubName = 'dashboards';
  private hubConnection: HubConnection | undefined;
  public connectionEstablished$ = new EventEmitter<boolean>();
  public isConnect: boolean;

  public infoSubObservable = new EventEmitter<CollectedData>(); // from(this.infoSub);
  public instanceCheckedSubObservable = new EventEmitter<InstanceChecked>();

  constructor(private authService: AuthService) {
    this.startConnection();
  }

  private startConnection(): void {
    if (!this.authService.getCurrentUserLS()) { return; }
    if (this.isConnect) { return; }
    this.authService.getTokens().subscribe(([firebaseToken, watcherToken]) => {
      this.buildConnection(firebaseToken, watcherToken);
      console.log('Dashboards Hub trying to connect');
      this.hubConnection
        .start()
        .then(() => {
          console.log('Dashboards Hub connected');
          this.isConnect = true;
          this.connectionEstablished$.emit(true);
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
        this.infoSubObservable.emit(info);
      });

    this.hubConnection.on('InstanceStatusCheck', (info: InstanceChecked) => {
      info.statusCheckedAt = new Date(info.statusCheckedAt);
      this.instanceCheckedSubObservable.emit(info);
    });

    // On Close open connection again
    this.hubConnection.onclose((error: Error) => {
      this.isConnect = false;
      this.connectionEstablished$.next(false);
      console.log('Dashboard Hub connection closed');
      console.error(error);
      this.startConnection();
    });
  }

  subscribeToInstanceById(instanceGuidId: string): void {
    if (this.hubConnection) {
      this.hubConnection.invoke('SubscribeToInstanceById', instanceGuidId)
        .catch(err => console.error(err));
    }
  }

  subscribeToOrganizationById(id: number): void {
    if (this.hubConnection) {
      this.hubConnection.invoke('SubscribeToOrganizationById', id)
        .catch(err => console.error(err));
    }
  }

  unSubscribeFromInstanceById(instanceGuidId: string): void {
    if (this.hubConnection) {
      this.hubConnection.invoke('UnSubscribeFromInstanceById', instanceGuidId)
        .catch(err => console.error(err));
    }
  }

  unSubscribeFromOrganizationById(id: number): void {
    if (this.hubConnection) {
      this.hubConnection.invoke('UnSubscribeFromOrganizationById', id)
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

  public disconnect() {
    this.connectionEstablished$ = new EventEmitter<boolean>();
    this.infoSubObservable = new EventEmitter<CollectedData>();
    this.instanceCheckedSubObservable = new EventEmitter<InstanceChecked>();
  }
}
