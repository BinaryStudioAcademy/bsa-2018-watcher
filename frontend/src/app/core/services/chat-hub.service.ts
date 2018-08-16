import { EventEmitter, Injectable } from '@angular/core';
import { HubConnection, HubConnectionBuilder } from '@aspnet/signalr';
import { environment } from '../../../environments/environment';

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

    constructor() {
        this.hubConnection = new HubConnectionBuilder()
            .withUrl(`${environment.server_url}/${this.hubName}`)
            .build();

        this.startConnection();
        this.registerOnReceivingMessage();
        this.registerOnChatCreated();
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

    private registerOnChatCreated(): void {
        this.hubConnection.on('ChatCreated', (data: any) => {
            this.chatCreated.emit(data);
        });
    }

    public initializeChat(chat: ChatRequest, userId: string) {
        this.hubConnection.invoke('InitializeChat', chat, userId);
    }

    public sendMessage(message: MessageRequest) {
        this.hubConnection.invoke('Send', message);
    }

    public addUser(userId: string, chatId: number) {
        this.hubConnection.invoke('AddUser', userId, chatId);
    }
}
