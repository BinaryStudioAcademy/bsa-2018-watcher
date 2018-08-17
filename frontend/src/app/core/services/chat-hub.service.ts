import { EventEmitter, Injectable } from '@angular/core';
import { HubConnection } from '@aspnet/signalr';
import { environment } from '../../../environments/environment';

import * as signalR from '@aspnet/signalr';
import { AuthService } from './auth.service';

import { Message } from '../../shared/models/message.model';
import { Chat } from '../../shared/models/chat.model';

import { MessageRequest } from '../../shared/requests/message-request';
import { ChatRequest } from '../../shared/requests/chat-request';


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
    }

    private startConnection(): void {
        this.hubConnection
            .start()
            .then(() => {
                console.log('Hub connection started');
                this.registerOnEvents();
            })
            .catch(err => {
                console.log('Error while establishing connection, retrying...');
                setTimeout(this.startConnection(), 5000);
            });
    }

    private registerOnEvents(): void {
        this.hubConnection.on('ReceiveMessage', (data: any) => {
            this.messageReceived.emit(data);
        });

        this.hubConnection.on('ChatCreated', (data: any) => {
            this.chatCreated.emit(data);
            console.log('ChatCreated');
        });

        this.hubConnection.on('UserAdded', (data: any) => {
            console.log('UserAdded');
        });
    }

    public initializeChat(chat: ChatRequest, userId: string) {
        this.hubConnection.invoke('InitializeChat', chat, userId);
    }

    public sendMessage(message: MessageRequest) {
        this.hubConnection.invoke('Send', message);
    }

    public addUserToChat(userId: string, chatId: number) {
        this.hubConnection.invoke('AddUserToChat', userId, chatId);
    }
}
