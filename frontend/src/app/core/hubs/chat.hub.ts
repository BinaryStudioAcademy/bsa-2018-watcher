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
    private isConnect: boolean;

    public messageReceived = new EventEmitter<Message>();
    public chatMessagesWasRead = new EventEmitter<number>();
    public chatCreated = new EventEmitter<Chat>();
    public chatChanged = new EventEmitter<Chat>();
    public chatDeleted = new EventEmitter<Chat>();

    constructor(private authService: AuthService) {
        this.startConnection();
    }

    private buildConnection(firebaseToken: string, watcherToken: string) {
        const connPath = `${environment.server_url}/${this.hubName}?Authorization=${firebaseToken}&WatcherAuthorization=${watcherToken}`;

        this.hubConnection = new signalR.HubConnectionBuilder()
            .withUrl(connPath)
            .configureLogging(signalR.LogLevel.Information)
            .build();
    }

    private startConnection(): void {
        if (this.isConnect) { return; }
        this.authService.getTokens().subscribe(([firebaseToken, watcherToken]) => {
            this.buildConnection(firebaseToken, watcherToken);
            console.log('ChatHub trying to connect');
            this.hubConnection
                .start()
                .then(() => {
                    console.log('ChatHub connected');
                    this.registerOnEvents();
                })
                .catch(err => {
                    console.log('Error while establishing connection (ChatHub)');
                    setTimeout(this.startConnection(), 3000);
                });
      });
    }

    private registerOnEvents(): void {
        this.hubConnection.on('ReceiveMessage', (data: any) => {
            this.messageReceived.emit(data);
            console.log('Message Received');
        });

        this.hubConnection.on('ChatCreated', (data: any) => {
            this.chatCreated.emit(data);
            console.log('Chat created');
        });

        this.hubConnection.on('ChatChanged', (data: any) => {
            this.chatChanged.emit(data);
            console.log('ChatChanged');
        });

        this.hubConnection.on('ChatChanged', (data: any) => {
            this.chatChanged.emit(data);
            console.log('ChatChanged');
        });

        this.hubConnection.on('ChatDeleted', (data: any) => {
            this.chatDeleted.emit(data);
            console.log('ChatDeleted');
        });

        this.hubConnection.onclose((error: Error) => {
            this.isConnect = false;
            console.log('ChatHub connection closed');
            console.error(error);
            this.startConnection();
        });
    }

    public createNewChat(chat: ChatRequest) {
        this.hubConnection.invoke('InitializeChat', chat)
            .catch(err => console.error(err));
    }

    public markMessageAsRead(messageId: number) {
        this.hubConnection.invoke('MarkMessageAsRead', messageId)
            .catch(err => console.error(err));
    }

    public updateChat(chat: ChatUpdateRequest, chatId: number) {
        this.hubConnection.invoke('UpdateChat', chat, chatId)
            .catch(err => console.error(err));
    }

    public sendMessage(message: MessageRequest) {
        this.hubConnection.invoke('Send', message)
            .catch(err => console.error(err));
    }

    public addUserToChat(userId: string, chatId: number) {
        this.hubConnection.invoke('AddUserToChat', chatId, userId)
            .catch(err => console.error(err));
    }

    public deleteUserFromChat(userId: string, chatId: number) {
        this.hubConnection.invoke('DeleteUserFromChat', chatId, userId)
            .catch(err => console.error(err));
    }

    public deleteChat(chatId: number) {
        this.hubConnection.invoke('DeleteChat', chatId)
            .catch(err => console.error(err));
    }
}
