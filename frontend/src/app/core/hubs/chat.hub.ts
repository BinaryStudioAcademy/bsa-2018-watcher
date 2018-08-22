import { EventEmitter, Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { HubConnection } from '@aspnet/signalr';
import * as signalR from '@aspnet/signalr';
import { AuthService } from '../services/auth.service';

import { Message } from '../../shared/models/message.model';
import { Chat } from '../../shared/models/chat.model';
import { MessageRequest } from '../../shared/requests/message-request';
import { ChatRequest } from '../../shared/requests/chat-request';
import { ChatUpdateRequest } from '../../shared/requests/chat-update-request';


@Injectable({
    providedIn: 'root'
})
export class ChatHub {
    private hubConnection: HubConnection;
    private hubName = 'chatsHub';

    public messageReceived = new EventEmitter<Message>();
    public chatCreated = new EventEmitter<Chat>();
    public chatChanged = new EventEmitter<Chat>();

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
                console.log('ChatHub connected');
                this.registerOnEvents();
            })
            .catch(err => {
                console.log('Error while establishing connection...');
                setTimeout(this.startConnection(), 5000);
            });
    }

    private registerOnEvents(): void {
        this.hubConnection.on('ReceiveMessage', (data: any) => {
            this.messageReceived.emit(data);
            console.log(data);
        });

        this.hubConnection.on('ChatCreated', (data: any) => {
            this.chatCreated.emit(data);
            console.log(data);
        });

        this.hubConnection.on('ChatChanged', (data: any) => {
            this.chatChanged.emit(data);
            console.log(data);
        });

        this.hubConnection.onclose(function (error) {
            console.log('Connection closed!!!');
            console.error(error);
            this.startConnection();
        });
    }

    public createNewChat(chat: ChatRequest) {
        this.hubConnection.invoke('InitializeChat', chat);
    }

    public updateChat(chat: ChatUpdateRequest, chatId: number) {
        this.hubConnection.invoke('UpdateChat', chat, chatId);
    }

    public sendMessage(message: MessageRequest) {
        this.hubConnection.invoke('Send', message);
    }

    public addUserToChat(userId: string, chatId: number) {
        this.hubConnection.invoke('AddUserToChat', chatId, userId);
    }

    public deleteUserFromChat(userId: string, chatId: number) {
        this.hubConnection.invoke('DeleteUserFromChat', chatId, userId);
    }
}
