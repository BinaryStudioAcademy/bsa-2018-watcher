import { Injectable } from '@angular/core';
import { MessageService, ConfirmationService } from 'primeng/api';

@Injectable(/*{
  providedIn: 'root'
}*/)
export class ToastnotificationService {

  response: boolean;

  constructor(private messageService: MessageService, private confirmationService: ConfirmationService) { }

  success(message: string) {
    this.messageService.add({ severity: 'success', summary: 'Success Message', detail: message });
  }

  info(message: string) {
    this.messageService.add({severity: 'info', summary: 'Info Message', detail: message});
  }

  warn(message: string) {
    this.messageService.add({ severity: 'warn', summary: 'Warn Message', detail: message });
  }

  error(message: string) {
    this.messageService.add({ severity: 'error', summary: 'Error Message', detail: message });
  }

  confirm(message: string) {
    this.confirmationService.confirm({
      message: message,
      header: 'Attention',
      icon: 'fa fa-question-circle',
      accept: () => { this.response = true; },
      reject: () => { this.response = false; }
  });
  return this.response;
  }
}
