import { EventEmitter, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HubConnection, HubConnectionBuilder } from '@aspnet/signalr';
import { environment } from '../../../environments/environment';

import { Message } from '../../shared/models/message.model';

import * as signalR from '@aspnet/signalr';
import { AuthService } from './auth.service';
import { Chat } from '../../shared/models/chat.model';

@Injectable({
    providedIn: 'root'
})
export class ChatHubService {
    private hubConnection: HubConnection;
    private hubName = 'chatsHub';

    public messageReceived = new EventEmitter<Message>();
    public chatCreated = new EventEmitter<Chat>();

    constructor(private authService: AuthService) {
        const firebaseToken = this.authService.getFirebaseToken();
        const watcherToken = this.authService.getWatcherToken();
        const connPath = `${environment.server_url}/${this.hubName}?Authorization=${firebaseToken}&WatcherAuthorization=${watcherToken}`;

        this.hubConnection = new signalR.HubConnectionBuilder()
            .withUrl(connPath)
            .configureLogging(signalR.LogLevel.Information)
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

        this.hubConnection.on('ChatCreated', (data: any) => {
            this.chatCreated.emit(data);
        });
    }

    public sendMessage(message: Message) {
        this.hubConnection.invoke('Send', message);
    }

    public initializeChat(chat: Chat, userId: string) {
        this.hubConnection.invoke('InitializeChat', chat, userId);
    }
}
