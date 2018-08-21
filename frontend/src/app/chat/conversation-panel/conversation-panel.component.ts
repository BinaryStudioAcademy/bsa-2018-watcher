import { Component, OnInit, Input, EventEmitter, ViewChildren } from '@angular/core';
import { FormBuilder, FormGroup, FormControl, Validators } from '@angular/forms';

import { UserService } from '../../core/services/user.service';
import { ChatService } from '../../core/services/chat.service';
import { AuthService } from '../../core/services/auth.service';
import { ToastrService } from '../../core/services/toastr.service';
import { ChatHub } from '../../core/hubs/chat.hub';

import { ChatUpdateRequest } from '../../shared/requests/chat-update-request';
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
  displaySettings: boolean;

  chatSettingsForm: FormGroup;
  filteredUsers: User[];

  wantedUser: string;
  textMessage: string;

  constructor(
    private fb: FormBuilder,
    private authService: AuthService,
    private userService: UserService,
    private chatService: ChatService,
    private toastrService: ToastrService,
    private chatHub: ChatHub) { }

  ngOnInit() {
    this.currentUser = this.authService.getCurrentUser();
    this.chatSettingsForm = this.fb.group({
      'name': new FormControl('', Validators.required)
    });

    this.onDisplay.subscribe((data: Chat) => {
      this.chatService.get(data.id).subscribe((chat: Chat) => {
        this.chat = chat;
        console.log(chat);
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

  openSettings() {
    this.chatSettingsForm.controls['name'].setValue(this.chat.name);
    this.displaySettings = true;
  }

  addUser(value) {
    console.log(value);
    if (this.chat.users.some(u => u === value)) {
      this.toastrService.error('User already added');
      return;
    }

    this.chatHub.addUserToChat(value.id, this.chat.id);
    this.chat.users.push(value);
    this.wantedUser = '';
  }

  filterUsers(event) {
    this.userService.find(event.query).subscribe(data => {
      this.filteredUsers = [];
      if (data.length) {
        this.filteredUsers = data.filter(u => u.id !== this.currentUser.id);
      }
    });
  }

  deleteUser(id: string) {
    this.chatHub.deleteUserFromChat(id, this.chat.id);
  }

  updateChat() {
    if (!this.chatSettingsForm.valid) {
      this.toastrService.error('Form was filled incorrectly');
      return;
    }
    const updatedChat: ChatUpdateRequest = {
      name: this.chatSettingsForm.get('name').value
    };

    this.chatHub.updateChat(updatedChat, this.chat.id);
    this.displaySettings = false;
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
