import { Component, OnInit, Input, EventEmitter } from '@angular/core';
import { FormBuilder, FormGroup, FormControl, Validators } from '@angular/forms';

import { UserService } from '../../core/services/user.service';
import { AuthService } from '../../core/services/auth.service';
import { ToastrService } from '../../core/services/toastr.service';
import { ChatHub } from '../../core/hubs/chat.hub';

import { ChatUpdateRequest } from '../../shared/requests/chat-update-request';
import { User } from '../../shared/models/user.model';
import { Chat } from '../../shared/models/chat.model';
import { ChatService } from '../../core/services/chat.service';


@Component({
  selector: 'app-conversation-settings-popup',
  templateUrl: './conversation-settings-popup.component.html',
  styleUrls: [
    './conversation-settings-popup.component.sass',
    '../chat.component.sass']
})

export class ConversationSettingsPopupComponent implements OnInit {

  @Input() onDisplay: EventEmitter<Chat>;

  chat: Chat;
  currentUser: User;

  display: boolean;

  chatSettingsForm: FormGroup;
  filteredUsers: User[];
  wantedUser: string;

  constructor(
    private fb: FormBuilder,
    private authService: AuthService,
    private userService: UserService,
    private toastrService: ToastrService,
    private chatHub: ChatHub,
    private chatService: ChatService) { }

  ngOnInit() {
    this.currentUser = this.authService.getCurrentUser();
    this.chatSettingsForm = this.fb.group({
      'name': new FormControl('', Validators.required)
    });

    this.onDisplay.subscribe((data: Chat) => {
      this.chat = data;
      this.chatSettingsForm.controls['name'].setValue(data.name);
      this.display = true;
    });
  }

  addUser(value) {
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
        this.filteredUsers = data.filter(u => u.id !== this.currentUser.id &&
          !this.chat.users.some(x => x.id === u.id));
      }
    });
  }

  deleteUser(id: string) {
    const index = this.chat.users.findIndex(u => u.id === id);
    this.chat.users.splice(index, 1);
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
    this.display = false;
  }

  deleteChat(id: number) {
    console.log(id);

    this.chatHub.deleteChat(this.chat.id);
    this.display = false;
  }

  closeSettings() {
    this.display = false;
    this.wantedUser = '';
    this.chatSettingsForm.reset();
  }
}
