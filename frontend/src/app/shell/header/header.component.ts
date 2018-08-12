import {Component, OnInit} from '@angular/core';
import {MenuItem, Message} from 'primeng/api';
import {NotificationsService} from '../../core/services/notifications.service';
import {SampleRequest} from '../../shared/models/sample-request.model';
import {SampleEnum} from '../../shared/models/sample-enum.enum';
import {SampleDto} from '../../shared/models/sample-dto.model';
import {MessageService} from 'primeng/api';
import {AuthService} from '../../core/services/auth.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.sass'],
  providers: [MessageService]
})
export class HeaderComponent implements OnInit {
  canCreateSample = false;
  msgs: Message[] = [];
  samples: SampleDto[] = [];
  notificationsNumber = 0;
  messagesNumber = 2;

  displayName: string;

  userItems: MenuItem[];
  cogItems: MenuItem[];
  mailItems: MenuItem[];
  bellItems: MenuItem[];
  orgItems: MenuItem[];

  constructor(private notificationsService: NotificationsService,
              private messageService: MessageService,
              private authService: AuthService) {
    this.subscribeToEvents();
  }

  showAllSamples() {
    this.msgs = [];
    const newMessages: Message[] = this.samples.map(s => {
      const mess: Message = {
        severity: 'info',
        summary: s.name,
        detail: `Name: ${s.name}, Id: ${s.id}, Sample Field: ${s.sampleField.toString()}, Date of creation: ${s.dateOfCreation},
        Count: ${s.count}`
      };
      return mess;
    });
    this.msgs.push(...newMessages);
   // this.messageService.addAll(newMessages);
  }

  private subscribeToEvents(): void {
    this.notificationsService.connectionEstablished.subscribe(() => {
      this.canCreateSample = true;
    });

    this.notificationsService.sampleReceived.subscribe((sample: SampleDto) => {
      this.messagesNumber++;
      this.notificationsNumber++;
      this.samples.push(sample);
      this.msgs.push({
        severity: 'info', summary: sample.name, detail: `Name: ${sample.name}, Id: ${sample.id},
          Sample Field: ${sample.sampleField.toString()}, Date of creation: ${sample.dateOfCreation}, Count: ${sample.count}, `
      });
    });
  }

  // TODO: methods for SignalR Tests
  createSample() {
    const req: SampleRequest = {
      name: 'Test',
      count: 12,
      dateOfCreation: new Date(2017, 1, 1),
      sampleField: SampleEnum.FirstItem
    };

    this.notificationsService.createSample(req);
  }

  echoToServer() {
    this.notificationsService.echo();
  }

  sendMess() {
    this.notificationsService.send('ri3bE0PElDT8gLU35sonvnMzbEq2', 'From Sdadadafsd message');
  }

  connectToServer() {
    this.notificationsService.connectToSignalR();
  }

  ngOnInit() {
    this.userItems = [
      {
        label: 'Settings',
        icon: 'fa fa-fw fa-cog',
        routerLink: ['/user/settings']
      },
      {
        label: 'Logout',
        icon: 'fa fa-fw fa-sign-out',
        command: (onclick) => {
          if (this.authService.isLoggedIn()) {
            this.authService.logout();
          }
        }
      }
    ];

    this.cogItems = [{
      label: 'Item',
      icon: 'fa fa-fw fa-cog',
    },
      {
        label: 'Item',
        icon: 'fa fa-fw fa-cog',
      },
      {
        label: 'Item',
        icon: 'fa fa-fw fa-cog',
      }
    ];

    this.mailItems = [{
      label: 'Item',
      icon: 'fa fa-fw fa-envelope-o',
    },
      {
        label: 'Item',
        icon: 'fa fa-fw fa-envelope-o',
      },
      {
        label: 'Item',
        icon: 'fa fa-fw fa-envelope-o',
      }
    ];

    this.bellItems = [{
      label: 'Item',
      icon: 'fa fa-fw fa-bell-o',
    },
      {
        label: 'Item',
        icon: 'fa fa-fw fa-bell-o',
      },
      {
        label: 'Item',
        icon: 'fa fa-fw fa-bell-o',
      }
    ];

    this.orgItems = [{
      label: 'Organization1',
      icon: 'fa fa-fw fa-building',
    },
      {
        label: 'Organization2',
        icon: 'fa fa-fw fa-building',
      },
      {
        label: 'Organization3',
        icon: 'fa fa-fw fa-building',
      }
    ];
    const currUser = this.authService.getCurrentUser();
    if (currUser != null) {
      this.displayName = currUser.displayName;
    }

  }
}
