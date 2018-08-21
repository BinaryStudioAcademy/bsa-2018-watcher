import { Component, OnInit, EventEmitter, Input } from '@angular/core';
import { FormBuilder, FormGroup, FormControl, Validators } from '@angular/forms';

import { UserService } from '../../core/services/user.service';
import { AuthService } from '../../core/services/auth.service';
import { ToastrService } from '../../core/services/toastr.service';
import { ChatHub } from '../../core/hubs/chat.hub';

import { ChatRequest } from '../../shared/requests/chat-request';
import { ChatType } from '../../shared/models/chat-type.enum';
import { Chat } from '../../shared/models/chat.model';
import { User } from '../../shared/models/user.model';

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

  wantedUser: string;
  filteredUsers: User[];
  users: User[] = [];
  currentUser: User;

  ngOnInit() {
    this.chatSettingsForm = this.fb.group({
      'name': new FormControl('', Validators.required)
    });

    this.currentUser = this.authService.getCurrentUser();
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
    const newChat: ChatRequest = {
      name: this.chatSettingsForm.get('name').value,
      createdById: this.currentUser.id,
      type: ChatType.BetweenUsers,
      users: this.users,
      organizationId: null
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
        this.filteredUsers = data.filter(u => !this.users.some(x => x.id === u.id));
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
