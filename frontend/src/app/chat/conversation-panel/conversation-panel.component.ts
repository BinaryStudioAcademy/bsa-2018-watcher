import { Component, OnInit, Input, Output, EventEmitter, ViewChildren } from '@angular/core';

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
  @Output() close = new EventEmitter();
  @ViewChildren('messageList') messageList: any;

  chat: Chat;
  currentUser: User;

  display: boolean;
  onDisplaySettings = new EventEmitter<Chat>();
  textMessage: string;

  constructor(
    private authService: AuthService,
    private chatService: ChatService,
    private chatHub: ChatHub) { }

  ngOnInit() {
    this.subscribeToEvents();
    this.currentUser = this.authService.getCurrentUser();
    this.onDisplay.subscribe((chatId: number) => {
      if (!chatId) {
        this.display = false;
        return;
      }
      this.display = true;
        this.chatService.get(chatId).subscribe((chat: Chat) => {
          this.chat = chat;
          this.markMessagesAsRead();
          this.scrollMessageListToBottom();
        });
    });
  }

  subscribeToEvents() {
    this.chatHub.messageReceived.subscribe((message: Message) => {
      if (this.chat && this.chat.id === message.chatId) {
        this.chat.messages.push(message);
        this.scrollMessageListToBottom();
        this.markMessagesAsRead();
      }
    });
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
    this.chat.messages.forEach( m => {
      if (!m.wasRead) {
        this.chatHub.markMessageAsRead(m.id);
      }
    });
  }

  private scrollMessageListToBottom(): void {
    setTimeout(() => {
      if (this.messageList) {
        this.messageList.toArray()[0].nativeElement.scrollTop = this.messageList.toArray()[0].nativeElement.scrollHeight;
      }
    });
  }
}
