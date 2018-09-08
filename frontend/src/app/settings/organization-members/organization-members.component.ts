import { Component, OnInit, ViewChild } from '@angular/core';
import { AuthService } from '../../core/services/auth.service';
import { UserOrganizationService } from '../../core/services/user-organization.service';
import { OrganizationRoleService } from '../../core/services/organization-role.service';
import { User } from '../../shared/models/user.model';
import { SelectItem, LazyLoadEvent } from 'primeng/api';
import { UserService } from '../../core/services/user.service';
import { ToastrService } from '../../core/services/toastr.service';
import { UserOrganization } from '../../shared/models/user-organization.model';
import { OrganizationRole } from '../../shared/models/organization-role.model';
import { Dropdown } from 'primeng/primeng';
import { ChatHub } from 'src/app/core/hubs/chat.hub';
import { ChatType } from 'src/app/shared/models/chat-type.enum';
import { ChatRequest } from '../../shared/requests/chat-request';
import { NotificationType } from '../../shared/models/notification-type.enum';
import { NotificationSetting } from 'src/app/shared/models/notification-setting.model';

@Component({
  selector: 'app-organization-members',
  templateUrl: './organization-members.component.html',
  styleUrls: ['./organization-members.component.sass']
})
export class OrganizationMembersComponent implements OnInit {

  userOrganizationsAll: UserOrganization[];
  userOrganizations: UserOrganization[];
  currentUser: User;
  totalRecords: number;
  lstRoles: OrganizationRole[];
  isManager: boolean;
  dropdownRole: SelectItem[];
  isLoading = false;
  popupMessage = '';

  constructor(
    private authService: AuthService,
    private userService: UserService,
    private userOrganizationService: UserOrganizationService,
    private organizationRoleService: OrganizationRoleService,
    private chatHub: ChatHub,
    private toastrService: ToastrService) {

    this.dropdownRole = new Array<SelectItem>();

  }
  ngOnInit() {
    this.currentUser = this.authService.getCurrentUser();
    if (this.currentUser == null) {
      return;
    }

    this.userService.getNumber().subscribe((value: number) => this.totalRecords = value);

    this.userOrganizationService
        .getByOrganizationId(this.currentUser.lastPickedOrganizationId)
        .subscribe((value: UserOrganization[]) => {
          this.userOrganizationsAll = value;
          this.toastrService.success('Get info from server');
          const role = this.userOrganizationsAll
          .find( usOrg => usOrg.user.id === this.currentUser.id )
          .organizationRole.name;
          this.isManager = role === 'Manager' ? true : false;
        });

    this.organizationRoleService.getAll().subscribe((value: OrganizationRole[]) => {
      this.lstRoles = value;
      this.fillDropdownRole();
    });
  }

  private fillDropdownRole(): void {
    this.dropdownRole = this.lstRoles.map((item: OrganizationRole) =>
                        this.toSelectItem(item));
  }

  toSelectItem(role: OrganizationRole): SelectItem {
    const item: SelectItem = {
      label: role.name,
      value: role
    };
    return item;
  }

  async changeRole(dropdown: Dropdown, userOrganization: UserOrganization ) {
    const selectedOption: OrganizationRole = dropdown.selectedOption.value;
    if (await this.toastrService.confirm(`You sure you want to make ${userOrganization.user.displayName} a ${selectedOption.name}`)) {

      const updating: UserOrganization = Object.assign({}, userOrganization);
        updating.organizationRole = Object.assign({}, selectedOption);

        this.isLoading = true;
        this.popupMessage = 'Updating user permissions';
        this.userOrganizationService.update(updating).subscribe( (value) => {
          this.toastrService.success('User permissions was updated');
          this.isLoading = false;
        });
      } else {
      dropdown.selectedOption = this.toSelectItem(userOrganization.organizationRole);
    }
  }


  createChat(userOrganization: UserOrganization): void {
    const targetUser: User = userOrganization.user;
    const users = [targetUser];

    const newChat: ChatRequest = {
      name: targetUser.displayName,
      createdById: this.currentUser.id,
      type: ChatType.BetweenUsers,
      users: users,
      organizationId: null,
      usersSettings: [{
        type: NotificationType.Chat,
        userId: this.currentUser.id,
        isMute: false,
        isEmailable: false
        } as NotificationSetting
      ]
    };
    this.chatHub.createNewChat(newChat);
  }
}

