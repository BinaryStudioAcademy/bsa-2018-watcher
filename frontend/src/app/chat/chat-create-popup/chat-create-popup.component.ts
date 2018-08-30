import { Component, OnInit, EventEmitter, Input } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { UserService } from '../../core/services/user.service';
import { AuthService } from '../../core/services/auth.service';
import { ToastrService } from '../../core/services/toastr.service';
import { ChatHub } from '../../core/hubs/chat.hub';

import { ChatRequest } from '../../shared/requests/chat-request';
import { ChatType } from '../../shared/models/chat-type.enum';
import { Chat } from '../../shared/models/chat.model';
import { User } from '../../shared/models/user.model';
import { NotificationType } from '../../shared/models/notification-type.enum';
import { NotificationSetting } from '../../shared/models/notification-setting.model';

@Component({
  selector: 'app-chat-create-popup',
  templateUrl: './chat-create-popup.component.html',
  styleUrls: [
    './chat-create-popup.component.sass',
    '../chat.component.sass']
})
export class ChatCreatePopupComponent implements OnInit {
  constructor(
    private fb: FormBuilder,
    private chatHub: ChatHub,
    private authService: AuthService,
    private userService: UserService,
    private toastrService: ToastrService) { }

  @Input() onDisplay: EventEmitter<Chat>;

  display: boolean;
  chatSettingsForm: FormGroup;
  notificationSettingsForm: FormGroup;

  wantedUser: string;
  filteredUsers: User[];
  users: User[] = [];
  currentUserId: string;

  ngOnInit() {
    this.chatSettingsForm = this.fb.group({
      'name': ['', Validators.required]
    });
    this.notificationSettingsForm = this.fb.group({
      'isMute': [false],
      'isDisable': [false],
      'isEmailable': [false]
    });

    this.currentUserId = this.authService.getCurrentUser().id;
    this.onDisplay.subscribe(() => {
      this.users = [];
      this.chatSettingsForm.reset();
      this.display = true;
    });
  }

  createChat() {
    if (!this.chatSettingsForm.valid) {
      this.toastrService.error('Form was filled incorrectly');
      return;
    }
    if (this.users.length < 1) {
      this.toastrService.error('Chat can`t be empty. Add someone.');
      return;
    }
    const newChat: ChatRequest = {
      name: this.chatSettingsForm.get('name').value,
      createdById: this.currentUserId,
      type: ChatType.BetweenUsers,
      users: this.users,
      organizationId: null,
      usersSettings: [{
        type: NotificationType.Chat,
        userId: this.currentUserId,
        isDisable: this.notificationSettingsForm.get('isDisable').value || false,
        isMute: this.notificationSettingsForm.get('isMute').value || false,
        isEmailable: this.notificationSettingsForm.get('isEmailable').value || false
        } as NotificationSetting
      ]
    };

    this.chatHub.createNewChat(newChat);
    this.display = false;
  }

  addUser(value) {
    this.users.push(value);
    this.wantedUser = '';
  }

  filterUsers(event) {
    this.userService.find(event.query).subscribe(data => {
      this.filteredUsers = [];
      if (data.length) {
        this.filteredUsers = data.filter(u => u.id !== this.currentUserId &&
          !this.users.some(x => x.id === u.id));
      }
    });
  }

  deleteUser(id: string) {
    const index = this.users.findIndex(u => u.id === id);
    this.users.splice(index, 1);
  }

  closeSettings() {
    this.display = false;
    this.wantedUser = '';
    this.chatSettingsForm.reset();
  }
}
