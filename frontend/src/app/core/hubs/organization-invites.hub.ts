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
  private isConnect: boolean;

  onAddInvite = new EventEmitter<OrganizationInvite>();
  onUpdateInvite = new EventEmitter<OrganizationInvite>();
  onDeleteInvite = new EventEmitter<number>();

  connectionEstablished = new EventEmitter<Boolean>();

  constructor(private authService: AuthService) {
    this.startInviteHubConnection();
  }

  private createConnection(firebaseToken: string, watcherToken: string): void {
    const connPath = `${environment.server_url}/invites?Authorization=${firebaseToken}&WatcherAuthorization=${watcherToken}`;

    this.hubConnection = new signalR.HubConnectionBuilder()
      .withUrl(connPath, ) // {accessTokenFactory: () => firebaseToken}
      .configureLogging(signalR.LogLevel.Information)
      .build();
  }

  private startInviteHubConnection(): void {
    if (this.isConnect) { return; }
    this.authService.getTokens().subscribe( ([firebaseToken, watcherToken]) => {
      this.createConnection(firebaseToken, watcherToken);
      console.log('OrganizationInvitesHub trying to connect');
      this.hubConnection.start()
        .then(() => {
          console.log('OrganizationInvitesHub connected');
          this.registerOnServerEvents();
        })
        .catch(err => {
          console.error('Error while establishing connection (OrganizationInvitesHub)');
          setTimeout(this.startInviteHubConnection(), 3000);
        });
    });
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
    this.hubConnection.onclose(err => {
      console.log('OrganizationInvitesHub connection closed');
      console.error(err);
      this.isConnect = false;
      this.startInviteHubConnection();
    });
  }
}
