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

  confirm(header = 'Are you sure?', message = '', acceptLabel = 'Yes, delete it!', rejectLabel = 'Cancel') {
    return new Promise((resolve, reject) => {
      this.confirmationService.confirm({
        key: 'confirm',
        header: header,
        message: message,
        acceptLabel: acceptLabel,
        rejectLabel: rejectLabel,
        accept: () => {
          resolve(true);
        },
        reject: () => {
          resolve(false);
        }
      });
    });
  }

  notice(header = 'Something happened!', message = '', acceptLabel = 'Ok') {
    return new Promise((resolve, reject) => {
      this.confirmationService.confirm({
        key: 'notice',
        header: header,
        message: message,
        acceptLabel: acceptLabel,
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
