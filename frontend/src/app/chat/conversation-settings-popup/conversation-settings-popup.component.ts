import { Component, OnInit, Input, EventEmitter } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { UserService } from '../../core/services/user.service';
import { AuthService } from '../../core/services/auth.service';
import { ToastrService } from '../../core/services/toastr.service';
import { ChatHub } from '../../core/hubs/chat.hub';

import { ChatUpdateRequest } from '../../shared/requests/chat-update-request';
import { User } from '../../shared/models/user.model';
import { Chat } from '../../shared/models/chat.model';
import { NotificationSetting } from '../../shared/models/notification-setting.model';
import { NotificationType } from '../../shared/models/notification-type.enum';


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
  currentUserId: string;

  display: boolean;

  chatSettingsForm: FormGroup;
  notificationSettingsForm: FormGroup;
  filteredUsers: User[];
  wantedUser: string;
  notificationSettings: NotificationSetting;

  constructor(
    private fb: FormBuilder,
    private authService: AuthService,
    private userService: UserService,
    private toastrService: ToastrService,
    private chatHub: ChatHub) { }

  ngOnInit() {
    this.currentUserId = this.authService.getCurrentUser().id;
    this.chatSettingsForm = this.fb.group({
      'name': ['', Validators.required]
    });
    this.notificationSettingsForm = this.fb.group({
      'isMute': [false],
      'isEmailable': [false]
    });

    this.onDisplay.subscribe((data: Chat) => {
      this.chat = data;
      this.chatSettingsForm.controls['name'].setValue(data.name);
      if (data.usersSettings) {
        this.notificationSettings =
          data.usersSettings.find(s => s.userId === this.currentUserId) || this.createDefaultNotificationsSettings();

        this.notificationSettingsForm.controls['isMute'].setValue(this.notificationSettings.isMute);
        this.notificationSettingsForm.controls['isEmailable'].setValue(this.notificationSettings.isEmailable);
      }
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
        this.filteredUsers = data.filter(u => u.id !== this.currentUserId &&
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
    this.notificationSettings.isMute = this.notificationSettingsForm.get('isMute').value || false;
    this.notificationSettings.isEmailable = this.notificationSettingsForm.get('isEmailable').value || false;

    const updatedChat: ChatUpdateRequest = {
      name: this.chatSettingsForm.get('name').value,
      usersSettings: [this.notificationSettings]
    };

    this.chatHub.updateChat(updatedChat, this.chat.id);
    this.display = false;
  }

  deleteChat() {
    this.chatHub.deleteChat(this.chat.id);
    this.display = false;
  }

  closeSettings() {
    this.display = false;
    this.wantedUser = '';
    this.chatSettingsForm.reset();
  }

  createDefaultNotificationsSettings(): NotificationSetting {
    return {
      type: NotificationType.Chat,
      userId: this.currentUserId,
      chatId: this.chat.id,
      isMute: false,
      isEmailable: false
    } as NotificationSetting;
  }
}
