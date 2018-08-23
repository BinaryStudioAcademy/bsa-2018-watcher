import { Component, OnInit, EventEmitter } from '@angular/core';
import { SelectItem } from 'primeng/primeng';
import { MessageService } from 'primeng/api';

import { ChatHub } from '../core/hubs/chat.hub';
import { AuthService } from '../core/services/auth.service';
import { ChatService } from '../core/services/chat.service';
import { ToastrService } from '../core/services/toastr.service';

import { Chat } from '../shared/models/chat.model';
import { Message } from '../shared/models/message.model';
import { User } from '../shared/models/user.model';


@Component({
  selector: 'app-chat',
  templateUrl: './chat.component.html',
  styleUrls: ['./chat.component.sass']
})
export class ChatComponent implements OnInit {

  constructor(
    private chatHub: ChatHub,
    private authService: AuthService,
    private chatService: ChatService,
    private toastrService: ToastrService,
    private messageService: MessageService) { }

  public onDisplayChat = new EventEmitter<number>();
  public onDisplayChatCreating = new EventEmitter<boolean>();

  chatList: SelectItem[] = [];
  selectedChat: Chat;
  currentUser: User;
  unreadedMessageCount = 0;

  ngOnInit() {
    this.currentUser = this.authService.getCurrentUser();
    this.chatService.getByUserId(this.currentUser.id).subscribe(
      chats => {
        chats.reverse();
        chats.forEach(chat => {
          this.chatList.push({ value: chat });
          this.unreadedMessageCount += chat.unreadMessagesCount;
        });
        this.subscribeToEvents();
      },
      err => {
        this.toastrService.error('Can`t get user`s chats');
      }
    );
  }

  openChat(chatId: number) {
    this.onDisplayChat.emit(chatId);
  }

  selectChat() {
    this.onDisplayChat.emit(this.selectedChat.id);
  }

  removeSelect() {
    this.selectedChat = null;
  }

  openChatCreating(event) {
    event.stopPropagation();
    event.preventDefault();
    this.onDisplayChatCreating.emit();
  }

  getChatImage(chat: Chat) {
    if (chat.users.length === 2) {
      const photo = chat.users.find(u => u.id !== this.currentUser.id).photoURL;
      if (photo) {
        return photo;
      } else {
        return 'http://icons.iconarchive.com/icons/custom-icon-design/pretty-office-8/128/User-blue-icon.png';
      }
    }
    return 'http://icons.iconarchive.com/icons/custom-icon-design/pretty-office-8/128/Users-icon.png';
  }

  calcNotReadMessages(chat: Chat): number {
    return chat.messages.filter(item => !item.wasRead && item.user.id !== this.currentUser.id).length;
  }

  subscribeToEvents() {
    this.chatHub.chatCreated.subscribe((chat: Chat) => {
      this.chatList.unshift({ value: chat });
    });

    this.chatHub.messageReceived.subscribe(() => {
      this.unreadedMessageCount++;
    });

    this.chatHub.chatChanged.subscribe((chat: Chat) => {
      const index = this.chatList.findIndex(x => x.value.id === chat.id);
      this.chatList.splice(index, 1, { value: chat });
    });

    this.chatHub.messageReceived.subscribe((message: Message) => {
      if (message.user.id !== this.currentUser.id) {
        this.messageService.add(
          {
            key: 'chat-message',
            data: message,
          }
        );
      }
    });
  }
}
