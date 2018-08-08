import { Injectable } from '@angular/core';
import { MessageService, ConfirmationService } from 'primeng/api';
@Injectable(/*{
  providedIn: 'root'
}*/)
export class ToastrService {

  constructor(private messageService: MessageService, private confirmationService: ConfirmationService) { }

  success(message: string) {
    this.messageService.add({ severity: 'success', summary: 'Success Message', detail: message });
  }

  info(message: string) {
    this.messageService.add({severity: 'info', summary: 'Info Message', detail: message});
  }

  warning(message: string) {
    this.messageService.add({ severity: 'warn', summary: 'Warn Message', detail: message });
  }

  error(message: string) {
    this.messageService.add({ severity: 'error', summary: 'Error Message', detail: message });
  }

  confirm(message = 'Are you sure?') {
    return new Promise((resolve, reject) => {
      this.confirmationService.confirm({
          message: message,
          header: 'Confirmation',
          icon: 'fa fa-question-circle',
          accept: () => {
              resolve(true);
          },
          reject: () => {
            resolve(false);
          }
      });
  });

  }
}
