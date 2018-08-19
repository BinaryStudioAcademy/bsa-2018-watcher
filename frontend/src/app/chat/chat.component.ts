import { Component, OnInit } from '@angular/core';
import { Dropdown, SelectItem } from 'primeng/primeng';
import { Validators, FormControl, FormGroup, FormBuilder } from '@angular/forms';

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
    private fb: FormBuilder,
    private chatHub: ChatHubService,
    private authService: AuthService,
    private userService: UserService,
    private chatService: ChatService,
    private toastrService: ToastrService) { }


  chatList: SelectItem[] = [];
  selectedChat: Chat;

  addedUsers: User[] = [];
  currentUser: User;

  displayCreateChat: boolean;
  displayConversation: boolean;

  textMessage: string;
  newChatForm: FormGroup;


  ngOnInit() {
    this.newChatForm = this.fb.group({
      'name': new FormControl('', Validators.required),
      'email': new FormControl('', Validators.email)
    });

    this.currentUser = this.authService.getCurrentUser();
    this.chatService.getByUserId(this.currentUser.id).subscribe(
      chats => {
        chats.reverse();
        chats.forEach(chat => {
          this.chatList.push({ value: chat });
        });
        this.subscribeToEvents();
      },
      err => {
        this.toastrService.error('Can`t get user`s chats');
      }
    );
  }

  subscribeToEvents() {
    this.chatHub.chatCreated.subscribe((chat: Chat) => {
      console.log('chat created');
      this.chatList.unshift({ value: chat });
      this.selectedChat = chat;
      this.openChat();
    });

    this.chatHub.messageReceived.subscribe((message: Message) => {
      console.log('received message');
      this.selectedChat.messages.push(message);
    });
  }

  openChat() {
    if (this.selectedChat != null) {
      this.chatService.get(this.selectedChat.id).subscribe((value: Chat) => {
        this.selectedChat = value;
        this.displayConversation = true;
      });
    }
  }

  createNewChat() {
    if (this.newChatForm.valid) {
      const newChat: ChatRequest = {
        name: this.newChatForm.get('name').value,
        createdById: this.currentUser.id,
        users: this.addedUsers
      } as ChatRequest;

      this.chatHub.createNewChat(newChat);
      this.addedUsers = [];
      this.displayCreateChat = false;
    } else {
      this.toastrService.error('Form was filled incorrectly');
    }
  }

  addUser() {
    const email = this.newChatForm.get('email').value;
    if (this.currentUser.email === email) {
      this.toastrService.error('Сan`t add yourself to chat');
      return;
    } else if (this.addedUsers.some(u => u.email === email)) {
      this.toastrService.error('User already added');
    } else {
      this.userService.getByEmail(email).subscribe((value: User) => {
        this.addedUsers.push(value);
      },
        err => {
          this.toastrService.error('User don`t exist');
        }
      );
    }
  }

  sendMessage() {
    const newMessage: MessageRequest = {
      text: this.textMessage,
      userId: this.currentUser.id,
      chatId: this.selectedChat.id,
      createdAt: new Date(Date.now())
    } as MessageRequest;

    this.chatHub.sendMessage(newMessage);
    this.textMessage = '';
  }
}
