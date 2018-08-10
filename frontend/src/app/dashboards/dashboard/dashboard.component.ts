import { Component, OnInit } from '@angular/core';
import {NotificationsService} from '../../core/services/notifications.service';
import {SampleDto} from '../../shared/models/sample-dto.model';
import {MessageService} from 'primeng/api';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.sass'],
  providers: [MessageService]
})
export class DashboardComponent implements OnInit {

  constructor(private notificationsService: NotificationsService,
              private messageService: MessageService) {
    this.subscribeToEvents();
  }

  ngOnInit() {
  }

  private subscribeToEvents(): void {
    this.notificationsService.connectionEstablished.subscribe(() => {
        console.log('Connected from dashboard');
    });

    this.notificationsService.sampleReceived.subscribe((sample: SampleDto) => {
      this.messageService.add({
        severity: 'info', summary: sample.name, detail: `Name: ${sample.name}, Id: ${sample.id},
          Sample Field: ${sample.sampleField.toString()}, Date of creation: ${sample.dateOfCreation}, Count: ${sample.count}, `
      });
    });
  }

}
