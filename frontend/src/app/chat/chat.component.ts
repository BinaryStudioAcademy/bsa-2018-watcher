import { Component, HostListener, OnInit, EventEmitter } from '@angular/core';
import { SelectItem } from 'primeng/primeng';

import { ChatHub } from '../core/hubs/chat.hub';
import { AuthService } from '../core/services/auth.service';
import { ChatService } from '../core/services/chat.service';
import { ToastrService } from '../core/services/toastr.service';
import { SystemToastrService } from '../core/services/system-toastr.service';

import { Chat } from '../shared/models/chat.model';
import { Message } from '../shared/models/message.model';
import { ChatWindow } from '../shared/models/chat-window.model';


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
    private systemToastrService: SystemToastrService) { }

  public onDisplayCreating = new EventEmitter<boolean>();

  chatWindows: ChatWindow[] = [];
  maxSupportedOpenedWindows: number;

  totalUnreadMessages = 0;
  chatList: SelectItem[] = [];
  selectedChat: Chat;
  currentUserId: string;

  isLoading: Boolean = false;

  ngOnInit() {
    this.calculateMaxSupportedOpenedWindows(window.innerWidth);

    this.currentUserId = this.authService.getCurrentUser().id;
    this.isLoading = true;
    this.chatService.getByUserId(this.currentUserId).subscribe(
      chats => {
        chats.reverse();
        chats.forEach(chat => {
          this.chatList.push({ value: chat });
          this.totalUnreadMessages += chat.unreadMessagesCount;
        });
        this.subscribeToEvents();
        this.isLoading = false;
      },
      err => {
        this.toastrService.error('Can`t get user`s chats');
        this.isLoading = false;
      }
    );
  }

  openChat() {
    if (!this.chatWindows.some(c => c.chat.id === this.selectedChat.id)) {
      this.chatService.get(this.selectedChat.id).subscribe((value: Chat) => {
        this.chatWindows.unshift({
          chat: value,
          isCollapsed: false,
          unreadMessages: 0
        });
        this.removeWindowsOverflow();
      });
    } else {
      // If chat opened but collpsed
      const window = this.chatWindows.find(cw => cw.chat.id === this.selectedChat.id);
      window.unreadMessages = 0;
      window.isCollapsed = false;
    }

    // Clear counter when chat opens
    if (this.selectedChat.unreadMessagesCount) {
      this.totalUnreadMessages -= this.selectedChat.unreadMessagesCount;
      this.selectedChat.unreadMessagesCount = 0;
    }

    // Clear chat selecting in list
    this.selectedChat = {} as Chat;
  }

  openCreating(event) {
    event.stopPropagation();
    event.preventDefault();
    this.onDisplayCreating.emit(true);
  }

  clearCounterForChat(chatId: number) {
    const window = this.chatList.find(c => c.value.id === chatId);
    this.totalUnreadMessages -= window.value.unreadMessagesCount;
    window.value.unreadMessagesCount = 0;
  }

  removeChatWindow(chatId: number) {
    const index = this.chatWindows.findIndex(c => c.chat.id === chatId);
    this.chatWindows.splice(index, 1);
  }

  subscribeToEvents() {
    this.chatService.openChatClick.subscribe((id: number) => {
      this.selectedChat = this.chatList.find(x => x.value.id === id).value;
      this.openChat();
    });

    this.chatHub.chatCreated.subscribe((chat: Chat) => {
      this.chatList.unshift({ value: chat });

      // Open only for user who create it
      if (chat.createdById === this.currentUserId) {
        this.selectedChat = chat;
        this.openChat();
      }
    });

    this.chatHub.chatChanged.subscribe((chat: Chat) => {
      if (!this.chatList.some(cl => cl.value.id === chat.id)) {
        this.chatList.unshift({ value: chat });
        return;
      }
      const index = this.chatList.findIndex(x => x.value.id === chat.id);

      // Save amount of unreaded messages and replace chat
      chat.unreadMessagesCount = this.chatList[index].value.unreadMessagesCount;
      this.chatList.splice(index, 1, { value: chat });

      if (this.chatWindows.some(cw => cw.chat.id === chat.id)) {
        this.chatWindows.find(w => w.chat.id === chat.id).chat = chat;
      }
    });

    this.chatHub.chatDeleted.subscribe((chat: Chat) => {
      const indexOfChat = this.chatList.map(item => item.value.id).indexOf(chat.id);
      this.totalUnreadMessages -= this.chatList[indexOfChat].value.unreadMessagesCount;
      this.chatList.splice(indexOfChat, 1);

      if (this.chatWindows.some(cw => cw.chat.id === chat.id)) {
        const windowIndex = this.chatWindows.findIndex(w => w.chat.id === chat.id);
        this.chatWindows.splice(windowIndex, 1);
      }
    });

    this.chatHub.messageReceived.subscribe((message: Message) => {
      if (message.user.id !== this.currentUserId) {
        // Check chat settings
        const settings = this.chatList.find(x => x.value.id === message.chatId).
          value.usersSettings.find(x => x.userId === this.currentUserId);

        if (!(settings && settings.isMute)) {
          this.systemToastrService.chat(message);
        }

        // Don`t count unread if chat is open and not collapse
        if (!this.chatWindows.some(cw => cw.chat.id === message.chatId && !cw.isCollapsed)) {
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

  @HostListener('window:resize', ['$event'])
  onResize(event: any) {
    this.calculateMaxSupportedOpenedWindows(event.target.innerWidth);
    this.removeWindowsOverflow();
  }

  calculateMaxSupportedOpenedWindows(width: number) {
    this.maxSupportedOpenedWindows = Math.floor((width - 190) / (250 + 20));
  }

  removeWindowsOverflow() {
    const difference = this.chatWindows.length - this.maxSupportedOpenedWindows;
    // Remove windows if don`t have place
    if (difference > 0) {
      this.chatWindows.splice(this.chatWindows.length - difference);
    }
  }
}
