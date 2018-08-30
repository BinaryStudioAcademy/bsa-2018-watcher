import { Component, OnInit, EventEmitter } from '@angular/core';
import { SelectItem } from 'primeng/primeng';

import { ChatHub } from '../core/hubs/chat.hub';
import { AuthService } from '../core/services/auth.service';
import { ChatService } from '../core/services/chat.service';
import { ToastrService } from '../core/services/toastr.service';
import { SystemToastrService } from '../core/services/system-toastr.service';

import { Chat } from '../shared/models/chat.model';
import { Message } from '../shared/models/message.model';
import { NotificationsHubService } from '../core/hubs/notifications.hub';
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
    private notify: NotificationsHubService,

    private systemToastrService: SystemToastrService) { }

  public onDisplayChat = new EventEmitter<number>();
  public onDisplayCreating = new EventEmitter<boolean>();

  isSelectedChatCollapsed: boolean;
  chatList: SelectItem[] = [];
  selectedChat: Chat;
  currentUserId: string;
  totalUnreadMessages = 0;

  ngOnInit() {
    this.currentUserId = this.authService.getCurrentUser().id;
    this.chatService.getByUserId(this.currentUserId).subscribe(
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

  selectChat() {
    if (this.selectedChat.unreadMessagesCount) {
      this.totalUnreadMessages -= this.selectedChat.unreadMessagesCount;
      this.selectedChat.unreadMessagesCount = 0;
    }
    this.onDisplayChat.emit(this.selectedChat.id);
  }

  openCreating(event) {
    event.stopPropagation();
    event.preventDefault();
    this.onDisplayCreating.emit(true);
  }

  onCollapseChat(isCollapsed) {
    this.isSelectedChatCollapsed = isCollapsed;
    if (!isCollapsed) {
      this.totalUnreadMessages -= this.selectedChat.unreadMessagesCount;
      this.selectedChat.unreadMessagesCount = 0;
    }
  }

  subscribeToEvents() {
    this.chatService.openChatClick.subscribe((id: number) => {
      this.selectedChat = this.chatList.find(x => x.value.id === id).value;
      this.selectChat();
    });

    this.chatHub.chatCreated.subscribe((chat: Chat) => {
      this.chatList.unshift({ value: chat });

      if (chat.createdBy.id === this.currentUserId) {
        this.selectedChat = this.chatList[0].value;
        this.selectChat();
      }
    });

    this.chatHub.chatChanged.subscribe((chat: Chat) => {
      const index = this.chatList.findIndex(x => x.value.id === chat.id);

      // Save amount of unreaded messages and replace chat
      chat.unreadMessagesCount = this.chatList[index].value.unreadMessagesCount;
      this.chatList.splice(index, 1, { value: chat });
      this.selectedChat = chat;
    });

    this.chatHub.chatDeleted.subscribe((chat: Chat) => {
      this.onDisplayChat.emit();
      const indexOfChat = this.chatList.map(item => item.value.id).indexOf(chat.id);
      this.totalUnreadMessages -= this.chatList[indexOfChat].value.unreadMessagesCount;
      this.chatList.splice(indexOfChat, 1);
    });

    this.chatHub.messageReceived.subscribe((message: Message) => {
      // TODO: test
      const not = {
        text: 'New message',
        createdAt: new Date(),
        userId: this.currentUserId
      } as Notification;
      this.notify.send(not, NotificationType.Warning);

      if (message.user.id !== this.currentUserId) {
        // Check chat settings
        const settings = this.chatList.find(x => x.value.id === message.chatId).
          value.usersSettings.find(x => x.userId === this.currentUserId);

        if (!(settings && settings.isMute)) {
          this.systemToastrService.chat(message);
        }

        // Don`t count unread if chat is open and not collapse
        if (!(this.selectedChat && !this.isSelectedChatCollapsed && this.selectedChat.id === message.chatId)) {
          this.totalUnreadMessages++;
          this.chatList.find(x => x.value.id === message.chatId).value.unreadMessagesCount++;
        }
      }
    });
  }

  getChatImage(chat: Chat) {
    const groupeImg = 'http://icons.iconarchive.com/icons/custom-icon-design/pretty-office-8/128/Users-icon.png';
    const partnerImg = 'http://icons.iconarchive.com/icons/custom-icon-design/pretty-office-8/128/User-blue-icon.png';

    if (chat.users.length === 2) {
      const photo = chat.users.find(u => u.id !== this.currentUserId).photoURL;
      return photo || partnerImg;
    }

    if (chat.users.length === 1) {
      return chat.users[0].photoURL || partnerImg;
    }
    return groupeImg;
  }
}
