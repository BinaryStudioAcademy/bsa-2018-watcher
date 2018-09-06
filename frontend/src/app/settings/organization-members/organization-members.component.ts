import { Component, OnInit, ViewChild } from '@angular/core';
import { AuthService } from '../../core/services/auth.service';
import { UserOrganizationService } from '../../core/services/user-organization.service';
import { OrganizationRoleService } from '../../core/services/organization-role.service';
import { Organization } from '../../shared/models/organization.model';
import { User } from '../../shared/models/user.model';
import { OrganizationInvite } from '../../shared/models/organization-invite.model';
import { Role } from '../../shared/models/role.model';
import { SelectItem, LazyLoadEvent } from 'primeng/api';
import { UserService } from '../../core/services/user.service';
import { ToastrService } from '../../core/services/toastr.service';
import { OrganizationInviteState } from '../../shared/models/organization-invite-state.enum';
import { UserOrganization } from '../../shared/models/user-organization.model';

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
  lstOrganizations: Organization[];
  lstUserCompany: Organization[];
  invite: OrganizationInvite;
  lstRoles: Role[];
  selectedRole: Role;
  selectedCompany: Organization;
  dropdownRole: SelectItem[];
  dropdownCompany: SelectItem[];
  lastOrganization: Organization;
  lstUnassign: Boolean[];

  data: any;
  photoUrl: string;
  photoType: string;
  display: Boolean = false;

  constructor(
    private authService: AuthService,
    private userService: UserService,
    private userOrganizationService: UserOrganizationService,
    private organizationRoleService: OrganizationRoleService,
    private toastrService: ToastrService) {

    this.lstUserCompany = new Array<Organization>();
    this.dropdownRole = new Array<SelectItem>();
    this.dropdownCompany = new Array<SelectItem>();
    this.lstUnassign = Array<Boolean>();


    this.data = {};
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
          const rows = this.userOrganizationsAll.length >= 5 ? 5 : (this.userOrganizationsAll.length - 1);
          this.userOrganizations = this.userOrganizationsAll.slice(0, rows);
        });

    this.organizationRoleService.getAll().subscribe((value: Role[]) => {
      this.lstRoles = value;
      this.fillDropdownRole();
    });
  }

  private fillDropdownRole(): void {
    this.lstRoles.forEach(element => {
      this.dropdownRole.push({ label: element.name, value: element });
    });
  }

  findWithAttr(array, attr1, value1, attr2, value2) {
    for (let i = 0; i < array.length; i += 1) {
      if (array[i][attr1] === value1 && array[i][attr2] === value2) {
        return array[i];
      }
    }
    return null;
  }

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
  onInvite(id: number) {
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
  }
}
