import { Component, OnInit } from '@angular/core';
import { MenuItem } from 'primeng/api';
import { Chat } from '../shared/models/chat';
import { ChatType } from '../shared/models/chat-type.enum';
import { Message } from '../shared/models/message.model';
import { ChatHubService } from '../core/services/chat-hub.service';
import { AuthService } from '../core/services/auth.service';


@Component({
  selector: 'app-chat',
  templateUrl: './chat.component.html',
  styleUrls: ['./chat.component.sass']
})
export class ChatComponent implements OnInit {

  constructor(private chatHub: ChatHubService,
    private authService: AuthService) { }

  chatPanel: MenuItem[];
  fakeChats: Chat[];
  textMessage: string;

  choosedChat: Chat = {} as Chat;
  isChatChoosed: boolean;


  ngOnInit() {
    this.fakeChats = [
      {
        id: 1,
        name: 'chat1',
        type: ChatType.BetweenUsers,
        createdBy: null,
        createdById: null,
        organization: null,
        organizationId: null,
        messages: [{
          id: 1,
          text: 'Its a simple message, which is overflow',
          createdAt: null,
          wasRead: true,
          user: null,
          chatId: 1,
          chat: null
        },
        {
          id: 1,
          text: 'message2',
          createdAt: null,
          wasRead: true,
          user: null,
          chatId: 1,
          chat: null
        },
        {
          id: 1,
          text: 'Its a simple message, which is overflow',
          createdAt: null,
          wasRead: true,
          user: null,
          chatId: 1,
          chat: null
        },
        {
          id: 1,
          text: 'Its a simple message, which is overflow',
          createdAt: null,
          wasRead: true,
          user: null,
          chatId: 1,
          chat: null
        },
        {
          id: 1,
          text: 'Its a simple message, which is overflow',
          createdAt: null,
          wasRead: true,
          user: null,
          chatId: 1,
          chat: null
        },
        {
          id: 1,
          text: 'Its a simple message, which is overflow',
          createdAt: null,
          wasRead: true,
          user: null,
          chatId: 1,
          chat: null
        }]
      },
      {
        id: 2,
        name: 'chat2',
        type: ChatType.BetweenUsers,
        createdBy: null,
        createdById: null,
        organization: null,
        organizationId: null,
        messages: [{
          id: 1,
          text: 'message1',
          createdAt: null,
          wasRead: true,
          user: null,
          chatId: 1,
          chat: null
        },
        {
          id: 1,
          text: 'Its a simple message, which is overflow',
          createdAt: null,
          wasRead: true,
          user: null,
          chatId: 1,
          chat: null
        }]
      }
    ];

    this.chatPanel = [
      {
        label: 'Chats',
        icon: 'fa fa-envelope',
        items: this.createChatItems()
      }
    ];
  }

  private subscribeToReceivingMessage() {
    this.chatHub.messageReceived.subscribe((message: Message) => {
      this.choosedChat.messages.push(message);
    });
  }

  openConversation(chat: Chat) {
    // Get list of message
    this.choosedChat = chat;
    this.isChatChoosed = true;
    this.chatHub.addUser(this.authService.getCurrentUser().id);
    this.subscribeToReceivingMessage();
  }

  closeConversation() {
    this.isChatChoosed = false;
  }

  sendMessage() {
    const newMessage: Message = { text: this.textMessage, user: this.authService.getCurrentUser() } as Message;
    this.chatHub.sendTextMessage(this.authService.getCurrentUser().id, this.textMessage);
  }


  createChatItems(): MenuItem[] {
    const items: MenuItem[] = [{
      label: 'New chat',
      icon: 'pi pi-fw pi-plus',
    }];

    this.fakeChats.forEach(fakeChat => {
      items.push({
        label: fakeChat.name,
        icon: 'pi pi-fw pi-users',
        command: () => this.openConversation(fakeChat)
      });
    });

    return items;
  }
}
