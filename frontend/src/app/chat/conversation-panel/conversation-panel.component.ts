import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

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

  @Input() chat: Chat;

  @Output() collapse = new EventEmitter<boolean>();
  @Output() close = new EventEmitter();
  currentUser: User;

  display: boolean;
  isCollapse: boolean;
  onDisplaySettings = new EventEmitter<Chat>();

  textMessage: string;
  unreadMessages = 0;

  constructor(
    private authService: AuthService,
    private chatHub: ChatHub) { }

  ngOnInit() {
    this.currentUser = this.authService.getCurrentUser();
     this.subscribeToEvents();
  }

  subscribeToEvents() {
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
    this.isCollapse = false;
    this.close.emit();
  }

  sendMessage() {
    if (!this.textMessage.length) {
      return;
    }

    const newMessage: MessageRequest = {
      text: this.textMessage,
      userId: this.currentUser.id,
      chatId: this.chat.id,
      createdAt: new Date()
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
