import { EventEmitter, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HubConnection, HubConnectionBuilder } from '@aspnet/signalr';
import { environment } from '../../../environments/environment';

import { Message } from '../../shared/models/message.model';
import { Chat } from '../../shared/models/chat.model';

@Injectable({
    providedIn: 'root'
})
export class ChatHubService {
    private hubConnection: HubConnection;
    private hubName = 'chatsHub';

    public messageReceived = new EventEmitter<Message>();

    constructor() {
        this.hubConnection = new HubConnectionBuilder()
            .withUrl(`${environment.server_url}/${this.hubName}`)
            .build();

        this.startConnection();
        this.registerOnReceivingMessage();
    }

    private startConnection(): void {
        this.hubConnection
            .start()
            .then(() => {
                console.log('Hub connection started');
            })
            .catch(err => {
                console.log('Error while establishing connection, retrying...');
                setTimeout(this.startConnection(), 5000);
            });
    }

    private registerOnReceivingMessage(): void {
        this.hubConnection.on('ReceiveMessage', (data: any) => {
            this.messageReceived.emit(data);
        });
    }

    public addUser(userId: string) {
        this.hubConnection.invoke('AddUser', userId);
    }

    public sendMessage(message: Message) {
        this.hubConnection.invoke('SendMessage', message);
    }

    public sendTextMessage(userId: string, message: string) {
        this.hubConnection.invoke('Send', userId, message);
    }
}
