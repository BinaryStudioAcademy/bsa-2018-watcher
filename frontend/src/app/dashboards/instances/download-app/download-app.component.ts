import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';
import { ToastrService } from '../../../core/services/toastr.service';

@Component({
  selector: 'app-download-app',
  templateUrl: './download-app.component.html',
  styleUrls: ['./download-app.component.sass']
})
export class DownloadAppComponent implements OnInit {

  @Output() closed: EventEmitter<void>;
  @Input() display: boolean;
  @Input() guid: string;
  constructor(private toastrService: ToastrService) {
    this.closed = new EventEmitter();
  }

  closeDialog(): void {
    this.closed.emit();
  }
  ngOnInit(): void {
  }
  copyToClipboard(message: string): void {
    const selBox = document.createElement('textarea');
    selBox.style.position = 'fixed';
    selBox.style.left = '0';
    selBox.style.top = '0';
    selBox.style.opacity = '0';
    selBox.value = message;
    document.body.appendChild(selBox);
    selBox.focus();
    selBox.select();
    document.execCommand('copy');
    document.body.removeChild(selBox);
    this.toastrService.info(`Copied to clipboard`);
  }

}
