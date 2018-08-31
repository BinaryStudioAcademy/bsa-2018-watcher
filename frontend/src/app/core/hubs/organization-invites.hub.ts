import {EventEmitter, Injectable} from '@angular/core';
import {HubConnection} from '@aspnet/signalr';
import * as signalR from '@aspnet/signalr';
import { environment } from '../../../environments/environment';
import { AuthService } from '../services/auth.service';
import { OrganizationInvite } from '../../shared/models/organization-invite.model';

@Injectable({
  providedIn: 'root'
})
export class OrganizationInvitesHub {
  private hubConnection: HubConnection | undefined;
  private connectionIsEstablished = false;

  onAddInvite = new EventEmitter<OrganizationInvite>();
  onUpdateInvite = new EventEmitter<OrganizationInvite>();
  onDeleteInvite = new EventEmitter<number>();

  connectionEstablished = new EventEmitter<Boolean>();

  constructor(private authService: AuthService) {
    this.connectToSignalR();
  }

  private connectToSignalR(): void {
    this.createConnection();
    this.registerOnServerEvents();
    this.startInviteHubConnection();
  }

  private createConnection(): void {
    const firebaseToken = this.authService.getFirebaseToken();
    const watcherToken = this.authService.getWatcherToken();
    const connPath = `${environment.server_url}/invites?Authorization=${firebaseToken}&WatcherAuthorization=${watcherToken}`;

    this.hubConnection = new signalR.HubConnectionBuilder()
      .withUrl(connPath, ) // {accessTokenFactory: () => firebaseToken}
      .configureLogging(signalR.LogLevel.Information)
      .build();
  }

  private registerOnServerEvents(): void {
    // On Add event
    this.hubConnection.on('AddInvite', (data: OrganizationInvite) => {
      console.log(`Add invite: ${data}`);
      this.onAddInvite.emit(data);
    });

    // On Update event
    this.hubConnection.on('UpdateInvite', (data: OrganizationInvite) => {
      console.log(`Update invite: ${data}`);
      this.onUpdateInvite.emit(data);
    });

    // On Delete event
    this.hubConnection.on('DeleteInvite', (id: number) => {
      console.log(`Delete invite: ${id}`);
      this.onDeleteInvite.emit(id);
    });

    // On Close event
    this.hubConnection.onclose(function (error) {
      console.log('CONNECTION CLOSED!!!');
      console.error(error);
      this.startInviteHubConnection();
    });
  }

  private startInviteHubConnection(): void {
    console.log('Connecting to Invite Hub!!!');
    this.hubConnection.start()
      .then(() => {
        console.log('Invite hub connected');
        this.connectionIsEstablished = true;
        this.connectionEstablished.emit(true);
      })
      .catch(function (err) {
        console.error('Error while establishing connection (Invites hub)...');
        setTimeout(this.startInviteHubConnection(), 5000);
      });
  }
}
