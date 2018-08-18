import { Component, OnInit } from '@angular/core';
import { Dropdown, SelectItem} from 'primeng/primeng';

import { ChatHubService } from '../core/hubs/chat.hub';
import { AuthService } from '../core/services/auth.service';
import { UserService } from '../core/services/user.service';
import { ChatService } from '../core/services/chat.service';
import { ToastrService } from '../core/services/toastr.service';

import { Chat } from '../shared/models/chat.model';
import { ChatType } from '../shared/models/chat-type.enum';
import { ChatRequest } from '../shared/requests/chat-request';
import { MessageRequest } from '../shared/requests/message-request';
import { Message } from '../shared/models/message.model';
import { User } from '../shared/models/user.model';


@Component({
  selector: 'app-chat',
  templateUrl: './chat.component.html',
  styleUrls: ['./chat.component.sass']
})
export class ChatComponent implements OnInit {

  constructor(
    private chatHub: ChatHubService,
    private authService: AuthService,
    private userService: UserService,
    private chatService: ChatService,
    private toastrService: ToastrService) { }

  currentUserId: string;
  chats: Chat[] = [];

  chatList: SelectItem[] = [];
  selectedChat: Chat;

  textMessage: string;
  wantedUser: string;

  choosedChat: Chat = {} as Chat;
  newChat: ChatRequest = {} as ChatRequest;
  userList: string[] = [];

  isChatChoosed: boolean;
  isNewChatChoosed: boolean;


  ngOnInit() {
    this.newChat.users = [];
    this.subscribeToEvents();
    this.currentUserId = this.authService.getCurrentUser().id;
    this.chatService.getByUserId(this.currentUserId).subscribe(
      chats => {
        chats.forEach(chat => {
          this.chatList.push({ label: chat.name, icon: 'pi pi-fw pi-users', value: chat });
        });
      },
      err => {
        this.toastrService.error('Can`t get user`s chats');
      }
    );
  }

  private subscribeToEvents() {
    this.chatHub.chatCreated.subscribe((value: Chat) => {
      console.log('chat created');
      this.chats.push(value);
      this.choosedChat = value;
    });

    this.chatHub.messageReceived.subscribe((value: Message) => {
      console.log('received message');
      this.choosedChat.messages.push(value);
    });
  }

  openCloseNewChatWindow() {
    this.isNewChatChoosed ? this.isNewChatChoosed = false : this.isNewChatChoosed = true;
    this.isChatChoosed = false;
  }

  openConversation(chatId: number) {
    this.isNewChatChoosed = false;
    this.chatService.get(chatId).subscribe((value: Chat) => {
      this.choosedChat = value;
      this.isChatChoosed = true;
    });
  }

  closeConversation() {
    this.isChatChoosed = false;
  }

  createNewChat() {
    this.isNewChatChoosed = true;
    this.newChat.name = this.newChat.name || 'NewChat';
    this.newChat.createdById = this.currentUserId;

    this.chatHub.createNewChat(this.newChat);
  }

  addUser() {
    if (!this.newChat.users.some(u => u.id === this.wantedUser)) {
      this.userService.get(this.wantedUser).subscribe((value: User) => {
        this.newChat.users.push(value);
      },
        err => {
          this.toastrService.error('User don`t exist');
        }
      );
    } else {
      this.toastrService.error('User already added');
    }
  }

  selectChat() {
    console.log('selected chat');
    console.log(this.selectedChat);

    this.openConversation(this.selectedChat.id);
  }

  sendMessage() {
    const newMessage: MessageRequest = {
      text: this.textMessage,
      userId: this.currentUserId,
      chatId: this.choosedChat.id,
      createdAt: new Date(Date.now())
    } as MessageRequest;

    this.chatHub.sendMessage(newMessage);
    this.textMessage = '';
  }
}
