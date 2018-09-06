import { Component, OnInit, ViewChild } from '@angular/core';
import { CropperSettings } from 'ngx-img-cropper/src/cropperSettings';
import { FormBuilder, FormControl, Validators } from '@angular/forms';
import { AuthService } from '../../core/services/auth.service';
import { UserOrganizationService } from '../../core/services/user-organization.service';
import { RoleService } from '../../core/services/role.service';
import { Organization } from '../../shared/models/organization.model';
import { User } from '../../shared/models/user.model';
import { OrganizationInvite } from '../../shared/models/organization-invite.model';
import { Role } from '../../shared/models/role.model';
import { SelectItem, LazyLoadEvent } from 'primeng/api';
import { UserService } from '../../core/services/user.service';
import { OrganizationService } from '../../core/services/organization.service';
import { ImageCropperComponent } from 'ngx-img-cropper';
import { ToastrService } from '../../core/services/toastr.service';
import { OrganizationInvitesService } from '../../core/services/organization-invites.service';
import { PathService } from '../../core/services/path.service';
import { OrganizationInviteState } from '../../shared/models/organization-invite-state.enum';

@Component({
  selector: 'app-organization-members',
  templateUrl: './organization-members.component.html',
  styleUrls: ['./organization-members.component.sass']
})
export class OrganizationMembersComponent implements OnInit {

  users: User[];
  user: User;
  currentUser: User;
  displayPopup: boolean;
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
    private fb: FormBuilder,
    private authService: AuthService,
    private userService: UserService,
    private organizationService: OrganizationService,
    private organizationInvitesService: OrganizationInvitesService,
    private roleService: RoleService,
    private pathService: PathService,
    private userOrganizationService: UserOrganizationService,
    private toastrService: ToastrService) {

    this.displayPopup = false;
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

    this.userService.getRange(1, 5).subscribe((value: User[]) => {
      this.users = value;
    });

    this.organizationService.getAll().subscribe((value: Organization[]) => {
      this.lstOrganizations = value;
      this.fillDropdownCompany();
    });

    this.roleService.getAll().subscribe((value: Role[]) => {
      this.lstRoles = value;
      this.fillDropdownRole();
    });
  }

  private fillDropdownRole(): void {
    this.lstRoles.forEach(element => {
      this.dropdownRole.push({ label: element.name, value: element });
    });
  }

  private fillDropdownCompany(): void {
    this.lstOrganizations.forEach(element => {
      this.dropdownCompany.push({ label: element.name, value: element });
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

  onUnassign(company: Organization, i: number) {
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
        this.toastrService.error(`Error ocured status: ${error.message}`);
      }
    );
  }


  onCancel() {
    this.displayPopup = false;
    this.user = null;
    this.lstUnassign = [];
  }

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
      experationDate: null,
      link: null,
      state: OrganizationInviteState.Pending
    };
    this.invite = invite;
  }

  onSentInviteToEmail() {
    if (this.user.email === null) { return; }
    this.onInvite(this.selectedCompany.id);

    this.invite.inviteEmail = this.user.email;
    this.organizationInvitesService.createdAndSend(this.invite).subscribe(
      value => {
        this.toastrService.success('Organization Invite was created and sends to email.');
      },
      error => {
        this.toastrService.error(`Error ocured status: ${error.message}`);
      });
  }

  loadUsersLazy(event: LazyLoadEvent) {
    const currentPage = event.first / event.rows + 1;
    this.userService.getRange(currentPage, event.rows).subscribe((value: User[]) => {
      this.users = value;
    });
  }

}
