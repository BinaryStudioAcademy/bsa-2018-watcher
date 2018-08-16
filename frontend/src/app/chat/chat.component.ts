import { Component, OnInit } from '@angular/core';
import { MenuItem } from 'primeng/api';
import { Chat } from '../shared/models/chat.model';
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

  chatPanel: MenuItem[] = [];
  chats: Chat[] = [];
  textMessage: string;

  choosedChat: Chat = {} as Chat;
  isChatChoosed: boolean;


  ngOnInit() {
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
    const newMessage: Message = { text: this.textMessage, userId: this.authService.getCurrentUser().id } as Message;
    this.chatHub.sendTextMessage(this.authService.getCurrentUser().id, this.textMessage);
  }


  createChatItems(): MenuItem[] {
    const items: MenuItem[] = [{
      label: 'New chat',
      icon: 'pi pi-fw pi-plus',
    }];

    this.chats.forEach(chat => {
      items.push({
        label: chat.name,
        icon: 'pi pi-fw pi-users',
        command: () => this.openConversation(chat)
      });
    });

    return items;
  }
}
