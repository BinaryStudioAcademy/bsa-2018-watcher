import { Component, OnInit } from '@angular/core';
import { HubConnection, HubConnectionBuilder } from '@aspnet/signalr';
import { environment } from '../../../environments/environment';
import { AuthService } from '../../core/services/auth.service';
import { Chat } from '../../shared/models/chat.model';
import { ChatType } from '../../shared/models/chat-type.enum';
import { Message } from '../../shared/models/message.model';
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
    const connPath = `/notifications?Authorization=${firebaseToken}&WatcherAuthorize=${watcherToken}`;

    this.chatUrl = `${environment.server_url}/chatsHub?Authorization=${firebaseToken}&WatcherAuthorize=${watcherToken}`;
    this.hubConnection = new HubConnectionBuilder().withUrl(this.chatUrl).build();

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
      chat: chat,
      chatId: 33,
      createdAt: new Date(),
      text: 'message',
      user: this.authService.getCurrentUser(),
      wasRead: false
    };

    this.hubConnection.start()
      .then(() => {
        console.log('Connection started!');
        // this.hubConnection.invoke('AddUser', this.authService.getCurrentUser().id);
        this.hubConnection.on('ReceiveMessage', (messageIn) => console.log(messageIn));
        this.hubConnection.invoke('Send', this.authService.getCurrentUser().id, message);
        // (message: String) => { console.log(message); });
      })
      .catch(err => console.log('Error while establishing connection :('));
  }

}
