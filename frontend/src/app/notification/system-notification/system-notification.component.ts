import { Component, OnInit } from '@angular/core';
import { ChatService } from '../../core/services/chat.service';
import { NotificationType } from '../../shared/models/notification-type.enum';

@Component({
  selector: 'app-system-notification',
  templateUrl: './system-notification.component.html',
  styleUrls: ['./system-notification.component.sass']
})
export class SystemNotificationComponent implements OnInit {

  constructor(private chatService: ChatService) { }
  type = NotificationType;

  ngOnInit() { }

  openChat(id) {
    this.chatService.openChatClick.emit(id);
  }
}
