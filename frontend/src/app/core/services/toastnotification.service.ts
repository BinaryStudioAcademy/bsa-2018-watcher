import { Injectable } from '@angular/core';
import { MessageService } from 'primeng/api';

@Injectable(/*{
  providedIn: 'root'
}*/)
export class ToastnotificationService {

  constructor(private messageService: MessageService) { }

  success(message: string) {
    switch (message) {
      case 'Instance':
        this.messageService.add({ severity: 'success', summary: 'Instance', detail: 'Instance was created' });
        break;
      case 'Profile':
        this.messageService.add({ severity: 'success', summary: 'Profile', detail: 'Profile was updated' });
        break;
      default: this.messageService.add({ severity: 'success', summary: 'Service Message', detail: 'Detail Text' });
    }
  }

  warn(message: string) {
    this.messageService.add({ severity: 'warn', summary: 'Service Message', detail: 'Detail Text' });
  }

  error(message: string) {
    this.messageService.add({ severity: 'error', summary: 'Service Message', detail: 'Detail Text' });
  }

  confirm() {
    this.messageService.add({ severity: 'success', summary: 'Service Message', detail: 'Detail Text' }); }
}
