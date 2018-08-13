import {Component, OnInit} from '@angular/core';
import {MenuItem, Message} from 'primeng/api';
import {NotificationsService} from '../../core/services/notifications.service';
import {SampleRequest} from '../../shared/models/sample-request.model';
import {SampleEnum} from '../../shared/models/sample-enum.enum';
import {SampleDto} from '../../shared/models/sample-dto.model';
import {MessageService} from 'primeng/api';
import {AuthService} from '../../core/services/auth.service';
import { Organization } from '../../shared/models/organization.model';
import { UserService } from '../../core/services/user.service';
import { User } from '../../shared/models/user.model';
import { ToastrService } from '../../core/services/toastr.service';

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

  currentUser: User;

  userItems: MenuItem[];
  cogItems: MenuItem[];
  mailItems: MenuItem[];
  bellItems: MenuItem[];
  orgItems: MenuItem[];

  constructor(private notificationsService: NotificationsService,
              private messageService: MessageService,
              private userService: UserService,
              private toastrService: ToastrService,
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

    this.currentUser = this.authService.getCurrentUser();
    if (this.currentUser != null) {
      if (this.currentUser.organizations.length > 0) {
        this.fillOrganizations();
      }
    }

    this.authService.currentUser.subscribe(
      (userData) => {
        this.currentUser = userData;
        if (this.currentUser && this.currentUser.organizations && this.currentUser.organizations.length > 0) {
          this.fillOrganizations();
        }
      }
    );
  }

  private fillOrganizations() {
    this.orgItems = new Array<MenuItem>();

    this.currentUser.organizations.forEach(element => {
      this.orgItems.push({
        label: element.name,
        id: element.id.toString(),
        icon: 'fa fa-fw fa-building',
        command: (onclick) => { this.chengeLastPicOrganizations(element); },
        styleClass: (element.id === this.currentUser.lastPickedOrganizationId) ? 'selectedMenuItem' : '',
        disabled: (element.id === this.currentUser.lastPickedOrganizationId)
      });
    });
  }

  private chengeLastPicOrganizations(item: Organization) {
    // update user in beckend
    this.userService.updateLastPickedOrganization(this.currentUser.id, item.id)
    .subscribe(value => {
      // update user in frontend

      this.currentUser.lastPickedOrganizationId = item.id;
      this.currentUser.lastPickedOrganization = item;
      this.authService.updateCurrentUser(this.currentUser); // update user in localStorage
      this.fillOrganizations();
      // notify user about changes
      this.toastrService.success(`Organization by defaul was updated. Curent organization: "${item.name}"`);
    },
    err => {
      this.toastrService.error('Organization by defaul was not updated.');
    });
  }

}
