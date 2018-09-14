import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

import { AuthService } from '../../core/services/auth.service';
import { ChatHub } from '../../core/hubs/chat.hub';

import { MessageRequest } from '../../shared/requests/message-request';
import { Message } from '../../shared/models/message.model';
import { User } from '../../shared/models/user.model';
import { Chat } from '../../shared/models/chat.model';
import { ChatWindow } from '../../shared/models/chat-window.model';


@Component({
  selector: 'app-conversation-panel',
  templateUrl: './conversation-panel.component.html',
  styleUrls: [
    './conversation-panel.component.sass',
    '../chat.component.sass']
})
export class ConversationPanelComponent implements OnInit {

  @Input() window: ChatWindow;
  @Output() close = new EventEmitter();
  @Output() extended = new EventEmitter<number>();

  onDisplaySettings = new EventEmitter<Chat>();

  currentUser: User;
  textMessage: string;

  constructor(
    private authService: AuthService,
    private chatHub: ChatHub) { }

  ngOnInit() {
    this.currentUser = this.authService.getCurrentUser();
    this.subscribeToEvents();
    this.markMessagesAsRead();
  }

  subscribeToEvents() {
    this.chatHub.messageReceived.subscribe((message: Message) => {
      if (this.window.chat.id === message.chatId) {
        this.window.chat.messages.push(message);
        if (this.window.isCollapsed) {
          this.window.unreadMessages++;
        } else if (message.userId !== this.currentUser.id) {
          this.markMessagesAsRead();
        }
      }
    });
  }

  extend() {
    this.markMessagesAsRead();
    this.window.isCollapsed = false;
    this.window.unreadMessages = 0;
    this.extended.emit(this.window.chat.id);
  }

  openSettings(event) {
    event.stopPropagation();
    event.preventDefault();
    this.onDisplaySettings.emit(this.window.chat);
  }

  closePanel(event) {
    event.stopPropagation();
    event.preventDefault();
    this.close.emit();
  }

  sendMessage() {
    if (!this.textMessage.length) {
      return;
    }

    const newMessage: MessageRequest = {
      text: this.textMessage,
      userId: this.currentUser.id,
      chatId: this.window.chat.id,
      createdAt: new Date()
    } as MessageRequest;

    this.chatHub.sendMessage(newMessage);
    this.textMessage = '';
  }

  markMessagesAsRead() {
    this.window.chat.messages.forEach(m => {
      if (!m.wasRead) {
        this.chatHub.markMessageAsRead(m.id);
      }
    });
  }
}
