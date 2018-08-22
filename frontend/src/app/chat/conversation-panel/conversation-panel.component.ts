import { Component, OnInit, Input, EventEmitter, ViewChildren } from '@angular/core';

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

  @Input() onDisplay: EventEmitter<Chat>;
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
    this.currentUser = this.authService.getCurrentUser();
    this.onDisplay.subscribe((data: Chat) => {
      this.chatService.get(data.id).subscribe((chat: Chat) => {
        this.chat = chat;
        this.subscribeToEvents();
        this.scrollMessageListToBottom();
      });
      this.display = true;
    });
  }

  subscribeToEvents() {
    this.chatHub.messageReceived.subscribe((message: Message) => {
      if (this.chat && this.chat.id === message.chatId) {
        this.chat.messages.push(message);
        this.scrollMessageListToBottom();
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

  private scrollMessageListToBottom(): void {
    setTimeout(() => {
      if (this.messageList) {
        this.messageList.toArray()[0].nativeElement.scrollTop = this.messageList.toArray()[0].nativeElement.scrollHeight;
      }
    });
  }
}
