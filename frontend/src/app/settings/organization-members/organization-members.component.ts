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
  lstUnassign: Boolean[];

  constructor(
    private authService: AuthService,
    private userService: UserService,
    private userOrganizationService: UserOrganizationService,
    private organizationRoleService: OrganizationRoleService,
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
    this.lstRoles.forEach(element => {
      this.dropdownRole.push({ label: element.name, value: element });
    });
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
    console.log(dropdown.selectedOption);
    console.log(typeof(dropdown));
    if (await this.toastrService.confirm(`You sure you want to make ${userOrganization.user.displayName} a ${selectedOption.name}`)) {
        console.log('CONFIRMED');
        console.log(selectedOption);
    } else {
      dropdown.selectedOption = this.toSelectItem(userOrganization.organizationRole);
    }
  }
  loaded() {
    console.log('loaded');
  }

 /* findWithAttr(array, attr1, value1, attr2, value2) {
    for (let i = 0; i < array.length; i += 1) {
      if (array[i][attr1] === value1 && array[i][attr2] === value2) {
        return array[i];
      }
    }
    return null;
  }*/

  /*onUnassign(company: Organization, i: number) {
    this.lstUnassign[i] = true;
    if (this.lstUserCompany.length <= 1) {
      this.toastrService.warning('The user must have at least one organization.');
      return;
    }
    if (this.user.lastPickedOrganizationId === company.id) {
      this.user.lastPickedOrganizationId = 0;
      this.user.lastPickedOrganization = null;
    }
    this.userOrganizationService.delete(company.id, this.user.id).subscribe(
      value => {
        this.toastrService.success(`Now last picked organization - not selected.`);
        if (this.user.id === this.currentUser.id) {
          console.log('I am here');
          const index = this.currentUser.organizations.indexOf(company);
          this.currentUser.organizations.splice(index, 1);
          this.authService.updateCurrentUser(this.currentUser);
        }
      },
      error => {
        this.toastrService.error(`Error occurred status: ${error.message}`);
      }
    );
  }
*/
  /*onInvite(id: number) {
    const invite: OrganizationInvite = {
      id: 0,
      organizationId: id,
      createdByUserId: this.authService.getCurrentUser().id,
      inviteEmail: null,
      invitedUserId: null,
      createdByUser: null,
      organization: null,
      createdDate: null,
      expirationDate: null,
      link: null,
      state: OrganizationInviteState.Pending
    };
    this.invite = invite;
  }*/
}
