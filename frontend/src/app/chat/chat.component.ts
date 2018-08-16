import { Component, OnInit } from '@angular/core';
import { MenuItem } from 'primeng/api';

import { ChatHubService } from '../core/services/chat-hub.service';
import { AuthService } from '../core/services/auth.service';
import { UserService } from '../core/services/user.service';
import { ChatService } from '../core/services/chat.service';
import { ToastrService } from '../core/services/toastr.service';

import { Chat } from '../shared/models/chat.model';
import { ChatType } from '../shared/models/chat-type.enum';
import { ChatRequest } from '../shared/requests/chat-request';
import { MessageRequest } from '../shared/requests/message-request';
import { Message } from '../shared/models/message.model';
import { User } from '../shared/models/user.model';


@Component({
  selector: 'app-chat',
  templateUrl: './chat.component.html',
  styleUrls: ['./chat.component.sass']
})
export class ChatComponent implements OnInit {

  constructor(
    private chatHub: ChatHubService,
    private authService: AuthService,
    private userService: UserService,
    private chatService: ChatService,
    private toastrService: ToastrService) { }

  currentUserId: string;
  chatPanel: MenuItem[] = [];
  chats: Chat[] = [];

  textMessage: string;
  wanteduser: string;

  choosedChat: Chat = {} as Chat;
  isChatChoosed: boolean;
  isNewChatChoosed: boolean;


  ngOnInit() {
    this.subscribeToChatCreated();
    this.currentUserId = this.authService.getCurrentUser().id;
    this.userService.get(this.currentUserId).subscribe(
      value => {
        this.chats = value.chats;
        this.chatPanel = [
          {
            label: 'Chats',
            icon: 'fa fa-envelope',
            items: this.createChatItems()
          }
        ];
      },
      err => {
        this.toastrService.error('Can`t get user`s chats');
      }
    );
  }

  private subscribeToChatCreated() {
    this.chatHub.chatCreated.subscribe((value: Chat) => {
      this.chats.push(value);
      this.choosedChat = value;
    });
  }

  openCloseNewChatWindow() {
    this.isNewChatChoosed ? this.isNewChatChoosed = false : this.isNewChatChoosed = true;
  }

  openConversation(chatId: number) {
    this.chatService.get(chatId).subscribe((value: Chat) => {
      this.choosedChat = value;
    });

    this.isChatChoosed = true;

    this.chatHub.messageReceived.subscribe((message: Message) => {
      this.choosedChat.messages.push(message);
    },
    err => {
      this.toastrService.error('Can`t get message history');
    });
  }

  closeConversation() {
    this.isChatChoosed = false;
    this.choosedChat = null;
    this.chatHub.messageReceived.unsubscribe();
  }

  createNewChat() {
    this.isNewChatChoosed = true;

    const newChat: ChatRequest = {
      name: 'New chat',
      createdById: this.currentUserId,
      chatType: ChatType.BetweenUsers
    } as ChatRequest;

    this.chatHub.initializeChat(newChat, this.currentUserId);
  }

  addUserToChat() {
    this.userService.get(this.wanteduser).subscribe((value: User) => {
      this.chatHub.addUser(value.id, this.choosedChat.id);
      this.toastrService.error('User added');
    },
      err => {
        this.toastrService.error('User don`t exist');
      }
    );
  }

  sendMessage() {
    const newMessage: MessageRequest = {
      text: this.textMessage,
      userId: this.currentUserId,
      chatId: this.choosedChat.id,
      createdAt: new Date(Date.now())
    } as MessageRequest;

    this.chatHub.sendMessage(newMessage);
  }

  createChatItems(): MenuItem[] {
    const items: MenuItem[] = [{
      label: 'New chat',
      icon: 'pi pi-fw pi-plus',
      command: () => this.createNewChat()
    }];

    this.chats.forEach(chat => {
      items.push({
        label: chat.name,
        icon: 'pi pi-fw pi-users',
        command: () => this.openConversation(chat.id)
      });
    });

    return items;
  }
}
