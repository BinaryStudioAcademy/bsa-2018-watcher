import { Component, OnInit, EventEmitter } from '@angular/core';
import { SelectItem } from 'primeng/primeng';

import { ChatHub } from '../core/hubs/chat.hub';
import { AuthService } from '../core/services/auth.service';
import { ChatService } from '../core/services/chat.service';
import { ToastrService } from '../core/services/toastr.service';
import { SystemToastrService } from '../core/services/system-toastr.service';

import { Chat } from '../shared/models/chat.model';
import { Message } from '../shared/models/message.model';


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
    this.chatHub.chatCreated.subscribe((chat: Chat) => {
      this.chatList.unshift({ value: chat });

      if (chat.createdBy.id === this.currentUserId) {
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
      this.selectedChat = chat;
    });

    this.chatHub.messageReceived.subscribe((message: Message) => {
      if (message.user.id !== this.currentUserId) {
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

    this.chatHub.chatDeleted.subscribe((chat: Chat) => {
      this.onDisplayChat.emit();
      const indexOfChat = this.chatList.map(item => item.value.id).indexOf(chat.id);
      this.totalUnreadMessages -= this.chatList[indexOfChat].value.unreadMessagesCount;
      this.chatList.splice(indexOfChat, 1);
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
