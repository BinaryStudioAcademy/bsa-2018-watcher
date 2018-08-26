import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

import { ChatService } from '../../core/services/chat.service';
import { AuthService } from '../../core/services/auth.service';
import { ChatHub } from '../../core/hubs/chat.hub';

import { MessageRequest } from '../../shared/requests/message-request';
import { Message } from '../../shared/models/message.model';
import { User } from '../../shared/models/user.model';
import { Chat } from '../../shared/models/chat.model';


@Component({
  selector: 'app-conversation-panel',
  templateUrl: './conversation-panel.component.html',
  styleUrls: [
    './conversation-panel.component.sass',
    '../chat.component.sass']
})
export class ConversationPanelComponent implements OnInit {

  @Input() onDisplay: EventEmitter<number>;
  @Output() collapse = new EventEmitter<boolean>();
  @Output() close = new EventEmitter();
  chat: Chat;
  currentUser: User;

  display: boolean;
  isCollapse: boolean;
  onDisplaySettings = new EventEmitter<Chat>();

  textMessage: string;
  unreadMessages: number;

  constructor(
    private authService: AuthService,
    private chatService: ChatService,
    private chatHub: ChatHub) { }

  ngOnInit() {
    this.currentUser = this.authService.getCurrentUser();
    this.subscribeToEvents();
  }

  subscribeToEvents() {
    this.onDisplay.subscribe((chatId: number) => {
      if (!chatId) {
        this.display = false;
        return;
      }
      this.chatService.get(chatId).subscribe((chat: Chat) => {
        this.chat = chat;
        this.markMessagesAsRead();
        this.unreadMessages = 0;
        this.display = true;
      });
    });

    this.chatHub.messageReceived.subscribe((message: Message) => {
      if (this.chat && this.chat.id === message.chatId) {
        if (this.isCollapse) {
          this.unreadMessages++;
        }
        this.chat.messages.push(message);
        this.markMessagesAsRead();
      }
    });
  }

  collapseExtend() {
    if (this.isCollapse) {
      this.isCollapse = false;
      this.unreadMessages = 0;
    } else {
      this.isCollapse = true;
    }
    this.collapse.emit(this.isCollapse);
  }

  openSettings(event) {
    event.stopPropagation();
    event.preventDefault();
    this.onDisplaySettings.emit(this.chat);
  }

  closePanel(event) {
    event.stopPropagation();
    event.preventDefault();
    this.display = false;
    this.close.emit();
  }

  sendMessage() {
    if (this.textMessage.length < 1) {
      return;
    }

    const newMessage: MessageRequest = {
      text: this.textMessage,
      userId: this.currentUser.id,
      chatId: this.chat.id,
      createdAt: new Date(Date.now())
    } as MessageRequest;

    this.chatHub.sendMessage(newMessage);
    this.textMessage = '';
  }

  markMessagesAsRead() {
    this.chat.messages.forEach(m => {
      if (!m.wasRead) {
        this.chatHub.markMessageAsRead(m.id);
      }
    });
  }
}
