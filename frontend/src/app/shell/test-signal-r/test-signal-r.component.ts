import { Component, OnInit } from '@angular/core';
import { HubConnection, HubConnectionBuilder } from '@aspnet/signalr';
import { environment } from '../../../environments/environment';
import { AuthService } from '../../core/services/auth.service';
@Component({
  selector: 'app-test-signal-r',
  templateUrl: './test-signal-r.component.html',
  styleUrls: ['./test-signal-r.component.sass']
})
export class TestSignalRComponent implements OnInit {

  constructor(private authService: AuthService) { }

  private hubConnection: HubConnection;
  private chatUrl: String;

  ngOnInit() {
    this.chatUrl = '/chatsHub';
    this.hubConnection = new HubConnectionBuilder().withUrl(`${environment.server_url}${this.chatUrl}`).build();

    this.hubConnection.start()
      .then(() => {
        console.log('Connection started!');
        this.hubConnection.invoke('AddUser', this.authService.getCurrentUser().id);
        this.hubConnection.on('ReceiveMessage', (message: String) => { console.log(message); });
        this.hubConnection.invoke('Send', 'hKcyi0sCJKhEeR4eJSzlSOb2Fmh1', 'message')
          .catch(err => console.error(err));
      })
      .catch(err => console.log('Error while establishing connection :('));
  }

}
