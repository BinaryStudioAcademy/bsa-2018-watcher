import { Component, OnInit, EventEmitter } from '@angular/core';
import { SelectItem } from 'primeng/primeng';
import { MessageService } from 'primeng/api';

import { ChatHub } from '../core/hubs/chat.hub';
import { AuthService } from '../core/services/auth.service';
import { ChatService } from '../core/services/chat.service';
import { ToastrService } from '../core/services/toastr.service';
import { SystemToastrService } from '../core/services/system-toastr.service';

import { Chat } from '../shared/models/chat.model';
import { Message } from '../shared/models/message.model';
import { User } from '../shared/models/user.model';
import { Notification } from '../shared/models/notification.model';
import { NotificationType } from '../shared/models/notification-type.enum';


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
    private messageService: MessageService,
    private systemToastrService: SystemToastrService) { }

  public onDisplayChat = new EventEmitter<number>();
  public onDisplayChatCreating = new EventEmitter<boolean>();

  chatList: SelectItem[] = [];
  selectedChat: Chat;
  isSelectedChatCollapsed: boolean;
  currentUser: User;
  totalUnreadMessages = 0;

  ngOnInit() {
    this.currentUser = this.authService.getCurrentUser();
    this.chatService.getByUserId(this.currentUser.id).subscribe(
      chats => {
        chats.reverse();
        chats.forEach(chat => {
          this.chatList.push({ value: chat });
          this.totalUnreadMessages += chat.unreadMessagesCount;
        });
        this.subscribeToEvents();
      },
      err => {
        this.toastrService.error('Can`t get user`s chats');
      }
    );
  }

  openChat(chatId: number) {
    this.totalUnreadMessages -= this.selectedChat.unreadMessagesCount;
    this.selectedChat.unreadMessagesCount = 0;
    this.onDisplayChat.emit(chatId);
  }

  selectChat() {
    this.totalUnreadMessages -= this.selectedChat.unreadMessagesCount;
    this.selectedChat.unreadMessagesCount = 0;
    this.onDisplayChat.emit(this.selectedChat.id);
  }

  removeSelect() {
    this.onDisplayChat.emit();
    this.selectedChat = null;
  }

  openChatCreating(event) {
    const mes: Message = {
      chatId: 89,
      text: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt',
      user: this.authService.getCurrentUser(),
      createdAt: new Date(),
    } as Message;

    const not: Notification = {
      createdAt: new Date(),
      text: 'Simple notify',
      type: NotificationType.Info
    } as Notification;

    const not2: Notification = {
      createdAt: new Date(),
      text: 'Simple notify2',
      type: NotificationType.Error
    } as Notification;

    const not3: Notification = {
      createdAt: new Date(),
      text: 'Simple notify3',
      type: NotificationType.Warning
    } as Notification;
    this.systemToastrService.send(not2);
    this.systemToastrService.send(not);
    this.systemToastrService.send(not3);
    this.systemToastrService.chat(mes);


    event.stopPropagation();
    event.preventDefault();
    this.onDisplayChatCreating.emit(true);
  }

  onCollapseChat(isCollapse) {
    this.isSelectedChatCollapsed = isCollapse;
    if (!isCollapse) {
      this.totalUnreadMessages -= this.selectedChat.unreadMessagesCount;
      this.selectedChat.unreadMessagesCount = 0;
    }
  }

  subscribeToEvents() {
    this.chatHub.chatCreated.subscribe((chat: Chat) => {
      this.chatList.unshift({ value: chat });

      if (chat.createdBy.id === this.currentUser.id) {
        this.selectedChat = this.chatList[0].value;
        this.openChat(chat.id);
      }
    });

    this.chatService.openChatClick.subscribe((id: number) => {
      this.openChat(id);
    });

    this.chatHub.chatChanged.subscribe((chat: Chat) => {
      const index = this.chatList.findIndex(x => x.value.id === chat.id);

      // Save amount of unreaded messages and replace chat
      chat.unreadMessagesCount = this.chatList[index].value.unreadMessagesCount;
      this.chatList.splice(index, 1, { value: chat });
    });

    this.chatHub.messageReceived.subscribe((message: Message) => {
      if (message.user.id !== this.currentUser.id) {
        this.systemToastrService.chat(message);

        // Don`t count unread if chat is open and not collapse
        if (this.selectedChat && !this.isSelectedChatCollapsed && this.selectedChat.id === message.chatId) {
        } else {
          this.totalUnreadMessages++;
          const index = this.chatList.findIndex(x => x.value.id === message.chatId);
          this.chatList[index].value.unreadMessagesCount++;
        }
      }
    });
  }

  getChatImage(chat: Chat) {
    if (chat.users.length === 2) {
      const photo = chat.users.find(u => u.id !== this.currentUser.id).photoURL;
      return photo || 'http://icons.iconarchive.com/icons/custom-icon-design/pretty-office-8/128/User-blue-icon.png';
    }

    if (chat.users.length === 1) {
      return chat.users[0].photoURL || 'http://icons.iconarchive.com/icons/custom-icon-design/pretty-office-8/128/User-blue-icon.png';
    }
    return 'http://icons.iconarchive.com/icons/custom-icon-design/pretty-office-8/128/Users-icon.png';
  }
}
