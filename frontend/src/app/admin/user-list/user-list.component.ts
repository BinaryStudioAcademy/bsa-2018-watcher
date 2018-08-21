import { Component, OnInit } from '@angular/core';
import { FormControl, FormBuilder, Validators } from '@angular/forms';
import { UserService } from '../../core/services/user.service';
import { User } from '../../shared/models/user.model';
import { AuthService } from '../../core/services/auth.service';
import { ToastrService } from '../../core/services/toastr.service';
import { Organization } from '../../shared/models/organization.model';
import { OrganizationService } from '../../core/services/organization.service';

import { OrganizationInvitesService } from '../../core/services/organization-ivites.service';
import { OrganizationInvite } from '../../shared/models/organization-invite.model';
import { OrganizationInviteState } from '../../shared/models/organization-invite-state.enum';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.sass']
})
export class UserListComponent implements OnInit {

  users: User[];
  user: User;
  currentUser: User;
  display: boolean;
  totalRecords: number;
  lstOrganizations: Organization[];
  lstOrganizationId: number[];
  invite: OrganizationInvite;

  constructor(
    private fb: FormBuilder,
    private authService: AuthService,
    private userService: UserService,
    private organizationService: OrganizationService,
    private organizationInvitesService: OrganizationInvitesService,
    private toastrService: ToastrService) {

    this.display = false;
  }

  userForm = this.fb.group({
    displayName: new FormControl({ value: '', disabled: false }, Validators.required),
    firstName: new FormControl({ value: '', disabled: false }),
    lastName: new FormControl({ value: '', disabled: false }),
    bio: new FormControl({ value: '', disabled: false }),
    isActive: new FormControl({ value: true, disabled: false }, Validators.required)
  });

  ngOnInit() {
    this.currentUser = this.authService.getCurrentUser();
    if (this.currentUser == null) {
      return;
    }

    this.userService.getAll().subscribe((value: User[]) => {
      this.users = value;
      this.totalRecords = value.length;
    });

    this.organizationService.getAll().subscribe((value: Organization[]) => {
      this.lstOrganizations = value;
    });
  }

  subscribeOrganizationFormToData() {
    Object.keys(this.userForm.controls).forEach(field => {
      const control = this.userForm.get(field);
      control.setValue(this.user[field]);
    });
  }

  showPopup(user: User) {
    this.user = user;
    this.subscribeOrganizationFormToData();
    this.display = true;
    this.lstOrganizationId = user.organizations.map(x => Object.assign({}, x.id));
    this.lstOrganizationId.push(user.lastPickedOrganizationId);
    console.log(user.lastPickedOrganization);
  }

  onCancel() {
    this.display = false;
    this.user = null;
  }

  onSubmit() {
    this.display = false;

    if (this.userForm.valid) {
      Object.keys(this.userForm.controls).forEach(field => {
        this.user[field] = this.userForm.get(field).value;
        });
      this.userService.update(this.user.id, this.user).subscribe(
        value => {
          this.toastrService.success('User was updated');
        },
        error => {
          this.toastrService.error(`Error ocured status: ${error.message}`);
        }
      );
    } else {
      this.toastrService.error('Form was filled incorrectly');
    }
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

    this.organizationInvitesService.create(invite).subscribe(
      value => {
        this.toastrService.success('Organization Invite was created');
        this.invite = value;
      },
      error => {
       // this.toastrService.error('Organization Invite was not created');
       this.toastrService.error(`Error ocured status: ${error.message}`);
      });
  }

  onSentInviteToEmail(id: number) {
    if (this.user.email === null) { return; }
    this.onInvite(id);
    this.invite.inviteEmail = this.user.email;
    this.organizationInvitesService.update(this.invite.id, this.invite).subscribe(
    value => {
      this.toastrService.success('Organization Invite was updated and sends to email.');
    },
    err => {
      this.toastrService.error('Organization Invite was not updated');
    });
  }
}
