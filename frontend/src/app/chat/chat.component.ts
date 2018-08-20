import { Component, OnInit } from '@angular/core';
import { SelectItem } from 'primeng/primeng';
import { Validators, FormControl, FormGroup, FormBuilder } from '@angular/forms';

import { ChatHub } from '../core/hubs/chat.hub';
import { AuthService } from '../core/services/auth.service';
import { UserService } from '../core/services/user.service';
import { ChatService } from '../core/services/chat.service';
import { ToastrService } from '../core/services/toastr.service';

import { Chat } from '../shared/models/chat.model';
import { ChatType } from '../shared/models/chat-type.enum';
import { ChatRequest } from '../shared/requests/chat-request';
import { ChatUpdateRequest } from '../shared/requests/chat-update-request';
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
    private chatHub: ChatHub,
    private authService: AuthService,
    private userService: UserService,
    private chatService: ChatService,
    private toastrService: ToastrService) { }

  chatSettingsForm: FormGroup;
  chatList: SelectItem[] = [];
  selectedChat: Chat;

  addedUsers: User[] = [];
  currentUser: User;

  displayCreatingChat: boolean;
  displayChatSettings: boolean;
  displayChat: boolean;

  textMessage: string;

  ngOnInit() {
    this.chatSettingsForm = this.fb.group({
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
      this.chatList.unshift({ value: chat });
      this.selectedChat = chat;
      this.openChat();
    });

    this.chatHub.messageReceived.subscribe((message: Message) => {
      if (this.selectedChat && this.selectedChat.id === message.chatId) {
        this.selectedChat.messages.push(message);
      }
    });

    this.chatHub.chatChanged.subscribe((chat: Chat) => {
      const index = this.chatList.findIndex(x => x.value.id === chat.id);
      this.chatList.splice(index, 1, { value: chat });
    });
  }

  openChat() {
    if (this.selectedChat != null) {
      this.chatService.get(this.selectedChat.id).subscribe((chat: Chat) => {
        this.selectedChat = chat;
        this.displayChat = true;
      });
    }
  }

  openChatCreating() {
    this.displayCreatingChat = true;
    this.addedUsers = [];
    this.chatSettingsForm.reset();
  }

  openChatSettings() {
    this.chatSettingsForm.controls['name'].setValue(this.selectedChat.name);
    this.displayChatSettings = true;
  }

  createNewChat() {
    if (this.chatSettingsForm.valid) {
      const newChat: ChatRequest = {
        name: this.chatSettingsForm.get('name').value,
        createdById: this.currentUser.id,
        users: this.addedUsers
      } as ChatRequest;

      this.chatHub.createNewChat(newChat);
      this.displayCreatingChat = false;
    } else {
      this.toastrService.error('Form was filled incorrectly');
    }
  }

  addUser() {
    const email = this.chatSettingsForm.get('email').value;
    this.chatSettingsForm.get('email').reset();

    if (this.currentUser.email === email) {
      this.toastrService.error('Сan`t add yourself to chat');
      return;
    }
    if (this.selectedChat.users.some(u => u.email === email)) {
      this.toastrService.error('User already added');
      return;
    }
    this.userService.getByEmail(email).subscribe((value: User) => {
      this.selectedChat.users.push(value);
      this.chatHub.addUserToChat(value.id, this.selectedChat.id);
    },
      err => {
        this.toastrService.error('User don`t exist');
      }
    );
  }

  addToLocalList() {
    const email = this.chatSettingsForm.get('email').value;
    this.chatSettingsForm.get('email').reset();

    if (this.currentUser.email === email) {
      this.toastrService.error('Сan`t add yourself to chat');
      return;
    }
    if (this.addedUsers.some(u => u.email === email)) {
      this.toastrService.error('User already added');
      return;
    }
    this.userService.getByEmail(email).subscribe((value: User) => {
      this.addedUsers.push(value);
    },
      err => {
        this.toastrService.error('User don`t exist');
      }
    );
  }

  deleteUser(id: string) {
    if (id !== this.currentUser.id) {
      this.chatHub.deleteUserFromChat(id, this.selectedChat.id);
    }
  }

  updateChat() {
    if (!this.chatSettingsForm.valid) {
      this.toastrService.error('Form was filled incorrectly');
      return;
    }

    const updatedChat: ChatUpdateRequest = {
      name: this.chatSettingsForm.get('name').value
    };

    this.chatHub.updateChat(updatedChat, this.selectedChat.id);
    this.displayChatSettings = false;
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
