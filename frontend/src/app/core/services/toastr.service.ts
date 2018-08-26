import { Injectable } from '@angular/core';
import { MessageService, ConfirmationService } from 'primeng/api';
import { ToastModule } from 'primeng/toast';
@Injectable(/*{
  providedIn: 'root'
}*/)
export class ToastrService {

  constructor(private messageService: MessageService, private confirmationService: ConfirmationService) { }

  private message(severity: string, summary: string, detail: string): void {
    this.messageService.add({
      severity,
      summary,
      detail
    });
  }

  success(message: string): void {
    this.message('success', 'Success', message);
  }

  info(message: string): void {
    this.message('info', 'Info', message);
  }

  warning(message: string): void {
    this.message('warn', 'Warn', message);
  }

  error(message: string): void {
    this.message('error', 'Error', message);
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

  notice(message = 'Something happened!') {
    return new Promise((resolve, reject) => {
      this.confirmationService.confirm({
          message: message,
          header: 'Notice',
          icon: 'fa fa-exclamation-circle',
          acceptLabel: 'Ok',
          rejectVisible: false,
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
