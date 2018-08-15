import { Component, OnInit } from '@angular/core';
import { MenuItem } from 'primeng/api';
import { Chat } from '../shared/models/chat';
import { ChatType } from '../shared/models/chat-type.enum';
import { Message } from '../shared/models/message.model';

@Component({
  selector: 'app-chat',
  templateUrl: './chat.component.html',
  styleUrls: ['./chat.component.sass']
})
export class ChatComponent implements OnInit {

  constructor() { }

  chatPanel: MenuItem[];
  fakeChats: Chat[];
  message: string;

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

  sendMessage() {
  }

  closeConversation() {
    this.isChatChoosed = false;
  }

  openConversation(chat: Chat) {
    // Get list of message
    this.choosedChat = chat;
    this.isChatChoosed = true;
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
