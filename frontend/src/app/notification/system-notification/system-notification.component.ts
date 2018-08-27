import { Component, OnInit } from '@angular/core';
import { ChatService } from '../../core/services/chat.service';

@Component({
  selector: 'app-system-notification',
  templateUrl: './system-notification.component.html',
  styleUrls: ['./system-notification.component.sass']
})
export class SystemNotificationComponent implements OnInit {

  constructor(private chatService: ChatService) { }

  ngOnInit() { }

  openChat(id) {
    this.chatService.openChatClick.emit(id);
  }
}
