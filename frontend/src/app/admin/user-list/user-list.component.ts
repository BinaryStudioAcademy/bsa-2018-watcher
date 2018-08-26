import { Component, OnInit, ViewChild } from '@angular/core';
import { FormControl, FormBuilder, Validators } from '@angular/forms';
import { UserService } from '../../core/services/user.service';
import { User } from '../../shared/models/user.model';
import { AuthService } from '../../core/services/auth.service';
import { ToastrService } from '../../core/services/toastr.service';
import { Organization } from '../../shared/models/organization.model';
import { OrganizationService } from '../../core/services/organization.service';
import { RoleService } from '../../core/services/role.service';
import { SelectItem } from 'primeng/api';

import { UserOrganizationService } from '../../core/services/user-organization.service';
import { UserOrganization } from '../../shared/models/user-organization.model';
import { OrganizationInvitesService } from '../../core/services/organization-ivites.service';
import { OrganizationInvite } from '../../shared/models/organization-invite.model';
import { OrganizationInviteState } from '../../shared/models/organization-invite-state.enum';
import { Role } from '../../shared/models/role.model';

import { ImageCropperComponent, CropperSettings } from 'ngx-img-cropper';
import { PathService } from '../../core/services/path.service';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.sass']
})

export class UserListComponent implements OnInit {

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

  data: any;
  photoUrl: string;
  photoType: string;
  display: Boolean = false;

  @ViewChild('cropper', undefined)

  cropper: ImageCropperComponent;

  cropperSettings: CropperSettings;

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

    this.cropperSettings = new CropperSettings();
    this.cropperSettings.width = 200;
    this.cropperSettings.height = 200;
    this.cropperSettings.minWidth = 100;
    this.cropperSettings.minHeight = 100;
    this.cropperSettings.croppedWidth = 70;
    this.cropperSettings.croppedHeight = 70;
    this.cropperSettings.canvasWidth = 500;
    this.cropperSettings.canvasHeight = 500;
    this.cropperSettings.noFileInput = true;
    this.cropperSettings.preserveSize = true;

    this.data = {};
  }

  userForm = this.fb.group({
    displayName: new FormControl({ value: '', disabled: false }, Validators.required),
    firstName: new FormControl({ value: '', disabled: false }, Validators.required),
    lastName: new FormControl({ value: '', disabled: false }, Validators.required),
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

  subscribeOrganizationFormToData() {
    Object.keys(this.userForm.controls).forEach(field => {
      const control = this.userForm.get(field);
      control.setValue(this.user[field]);
    });
  }
  /*
    isAssign(id: number) {
      return this.lstOrganizationId.includes(id);
    }*/
  findWithAttr(array, attr1, value1,  attr2, value2) {
      for (let i = 0; i < array.length; i += 1) {
          if (array[i][attr1] === value1 && array[i][attr2] === value2) {
              return array[i];
          }
      }
      return null;
  }

  onUnassign(company: Organization) {
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
        if (this.user.id === this.currentUser.id) {console.log('I am here');
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

  showPopup(user: User) {
    // debugger;
    this.user = user;
    this.subscribeOrganizationFormToData();
    this.displayPopup = true;
    this.lstUserCompany = user.organizations.map(x => Object.assign({}, x));
    /*if (user.lastPickedOrganizationId) {
      this.organizationService.get(user.lastPickedOrganizationId).subscribe((value: Organization) => this.lastOrganization = value);
      this.lstUserCompany.push(this.lastOrganization);
  }*/
    this.selectedRole = user.role;
    this.photoUrl = this.pathService.convertToUrl(this.user.photoURL);
  }

  onCancel() {
    this.displayPopup = false;
    this.user = null;
  }

  onSubmit() {
    this.displayPopup = false;

    if (this.userForm.valid) {
      Object.keys(this.userForm.controls).forEach(field => {
        this.user[field] = this.userForm.get(field).value;
      });
      this.user.role = this.selectedRole;
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
    this.invite = invite;
/*
    this.organizationInvitesService.create(invite).subscribe(
      value => {
        this.toastrService.success('Organization Invite was created');
        this.invite = value;
      },
      error => {
        // this.toastrService.error('Organization Invite was not created');
        this.toastrService.error(`Error ocured status: ${error.message}`);
      });*/
  }

  onSentInviteToEmail() {
    if (this.user.email === null) { return; }
    this.onInvite(this.selectedCompany.id);

    this.invite.inviteEmail = this.user.email;
   /* this.invite.state = OrganizationInviteState.Pending; console.log(this.invite.inviteEmail );
    this.invite.createdByUserId = this.authService.getCurrentUser().id;
    this.invite.organizationId = this.selectedCompany.id;*/
    this.organizationInvitesService.createdAndSend(this.invite).subscribe(
      value => {
        this.toastrService.success('Organization Invite was created and sends to email.');
      },
      error => {
        this.toastrService.error(`Error ocured status: ${error.message}`);
      });
  }

  onImageSelected(upload) {
    // debugger;
    const image: any = new Image();
    const reader: FileReader = new FileReader();
    const that = this;
    this.photoType = upload[0].type;
    reader.onloadend = (eventLoad: any) => {
      image.src = eventLoad.target.result;
      that.cropper.setImage(image);
      this.display = true;
    };
    reader.readAsDataURL(upload[0]);
    upload.splice(0, upload.length);
  }

  onCropCancel() {
    this.photoType = '';
    this.display = false;
  }

  onCropSave() {
    this.user.photoURL = this.data.image;
    this.user.photoType = this.photoType;
    this.photoUrl = this.data.image;
    this.display = false;
  }
}
