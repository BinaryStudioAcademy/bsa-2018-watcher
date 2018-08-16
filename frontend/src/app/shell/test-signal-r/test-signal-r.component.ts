import { Component, OnInit } from '@angular/core';
import { HubConnection, HubConnectionBuilder } from '@aspnet/signalr';
import { environment } from '../../../environments/environment';
import { AuthService } from '../../core/services/auth.service';
import { Chat } from '../../shared/models/chat.model';
import { ChatType } from '../../shared/models/chat-type.enum';
import { Message } from '../../shared/models/message.model';
import * as signalR from '@aspnet/signalr';

@Component({
  selector: 'app-test-signal-r',
  templateUrl: './test-signal-r.component.html',
  styleUrls: ['./test-signal-r.component.sass']
})
export class TestSignalRComponent implements OnInit {

  constructor(private authService: AuthService) { }

  private hubConnection: HubConnection;
  private chatUrl: string;

  ngOnInit() {
    const firebaseToken = this.authService.getFirebaseToken();
    const watcherToken = this.authService.getWatcherToken();
    const connPath = `${environment.server_url}/chatsHub?Authorization=${firebaseToken}&WatcherAuthorization=${watcherToken}`;

    this.hubConnection = new signalR.HubConnectionBuilder()
      .withUrl(connPath) // {accessTokenFactory: () => firebaseToken}
      .configureLogging(signalR.LogLevel.Information)
      .build();

    const chat: Chat = {
      id: 33,
      name: 'chat',
      createdBy: this.authService.getCurrentUser(),
      type: ChatType.BetweenUsers,
      organization: null,
      messages: null
    };

    const message: Message = {
      id: 0,
      chatId: 33,
      createdAt: new Date(),
      text: 'message',
      userId: this.authService.getCurrentUser().id,
      wasRead: false
    };

    this.hubConnection.start()
      .then(() => {
        console.log('Connection started!');
        // this.hubConnection.invoke('AddUser', this.authService.getCurrentUser().id);
        this.hubConnection.on('ReceiveMessage', (messageIn) => console.log(messageIn));
        this.hubConnection.invoke('Send', message);
        // (message: String) => { console.log(message); });
      })
      .catch(err => console.log('Error while establishing connection :('));
  }

}
