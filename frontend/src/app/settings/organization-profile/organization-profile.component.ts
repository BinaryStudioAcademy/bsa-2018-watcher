import { Component, OnInit, ViewChild } from '@angular/core';
import { FormControl, FormBuilder, Validators } from '@angular/forms';
import { OrganizationService } from '../../core/services/organization.service';
import { ToastrService } from '../../core/services/toastr.service';
import { AuthService } from '../../core/services/auth.service';
import { Organization } from '../../shared/models/organization.model';
import { usesServiceWorker } from '../../../../node_modules/@angular-devkit/build-angular/src/angular-cli-files/utilities/service-worker';
import { OrganizationInvitesService } from '../../core/services/organization-ivites.service';
import { OrganizationInvite } from '../../shared/models/organization-invite.model';
import { OrganizationInviteState } from '../../shared/models/organization-invite-state.enum';
import { environment } from '../../../environments/environment';
import { ImageCropperComponent, CropperSettings } from 'ngx-img-cropper';
import { User } from '../../shared/models/user.model';

@Component({
  selector: 'app-organization-profile',
  templateUrl: './organization-profile.component.html',
  styleUrls: ['./organization-profile.component.sass'],
  providers: [
    ToastrService, OrganizationService, OrganizationInvitesService
  ]
})
export class OrganizationProfileComponent implements OnInit {

  constructor(
    private fb: FormBuilder,
    private organizationService: OrganizationService,
    private organizationInvitesService: OrganizationInvitesService,
    private authService: AuthService,
    private toastrService: ToastrService) {
      this.cropperSettings = new CropperSettings();
      this.cropperSettings.width = 200;
      this.cropperSettings.height = 200;
      this.cropperSettings.minWidth = 100;
      this.cropperSettings.minHeight = 100;
      this.cropperSettings.croppedWidth = 70;
      this.cropperSettings.croppedHeight = 70;
      this.cropperSettings.canvasWidth = 400;
      this.cropperSettings.canvasHeight = 400;
      this.cropperSettings.noFileInput = true;
      this.cropperSettings.preserveSize = true;
      this.data = {};
    }

  editable: boolean;
  organization: Organization;

  inviteLink = '';
  inviteEmail: string;
  invite: OrganizationInvite;

  @ViewChild('cropper', undefined)
  cropper: ImageCropperComponent;
  cropperSettings: CropperSettings;
  display: Boolean = false;
  imageUrl = '';
  data: any;

  user: User;

  isUpdating: Boolean = false;
  isInviting: Boolean = false;
  isCopying: Boolean = false;
  isSending: Boolean = false;

  private phoneRegex = /\(?([0-9]{3})\)?[ .-]?[0-9]*$/;
  private urlRegex = /[-a-zA-Z0-9@:%_\+.~#?&//=]{2,256}\.[a-z]{2,4}/;

  ngOnInit() {
    this.authService.currentUser.subscribe(
      (userData) => {
        this.user = { ...userData };
        this.organization = this.user.lastPickedOrganization;

        if (this.organization.createdByUserId === this.user.id) {
          this.editable = true;
        }
      });
  }

  onSubmit() {
    if (this.editable) {
      // Update Organization
      this.isUpdating = true;
      this.organizationService.update(this.organization.id, this.organization).subscribe(
        value => {
          // Update lastPickedOrganization in User on frontend
          this.user.lastPickedOrganization = this.organization;

          // TODO: Update Organization in User.organizations on frontend
          this.user.organizations = this.user.organizations.map(item => {
            return item.id === this.organization.id ? this.organization : item;
          });

          // Update user in localStorage and notify all subscribers
          this.authService.updateCurrentUser(this.user);

          this.toastrService.success('Organization was updated');
          this.isUpdating = false;
        },
        err => {
          this.toastrService.error('Organization was not updated');
          this.isUpdating = false;
        }
      );
    } else {
      this.toastrService.error('You do not have the right to change this organization.');
    }
  }

  onInvite() {
    const invite: OrganizationInvite = {
      id: 0,
      organizationId: this.organization.id,
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
    this.isInviting = true;
    this.organizationInvitesService.create(invite).subscribe(
      value => {
        this.toastrService.success('Organization Invite was created');
        this.invite = value;
        this.inviteLink = `${environment.client_url}/user/invite/${value.link}`;
        this.isInviting = false;
      },
      err => {
        this.toastrService.error('Organization Invite was not created');
        this.isInviting = false;
      });
  }

  onSentInviteToEmail() {
    if (this.inviteEmail === null) { return; }
    this.invite.inviteEmail = this.inviteEmail;
    this.isSending = true;
    this.organizationInvitesService.update(this.invite.id, this.invite).subscribe(
    value => {
      this.toastrService.success('Organization Invite was updated and sends to email.');
      this.isSending = false;
    },
    err => {
      this.toastrService.error('Organization Invite was not updated');
      this.isSending = false;
    });
  }

  onCopy() {
    this.isCopying = true;
    const selBox = document.createElement('textarea');
    selBox.style.position = 'fixed';
    selBox.style.left = '0';
    selBox.style.top = '0';
    selBox.style.opacity = '0';
    selBox.value = this.inviteLink;
    document.body.appendChild(selBox);
    selBox.focus();
    selBox.select();
    document.execCommand('copy');
    document.body.removeChild(selBox);
    this.isCopying = false;
  }

  onImageSelected(upload) {
    const image: any = new Image();
    const reader: FileReader = new FileReader();
    const that = this;
    reader.onloadend = (eventLoad: any) => {
      image.src = eventLoad.target.result;
      that.cropper.setImage(image);
      this.display = true;
    };

    reader.readAsDataURL(upload[0]);
    upload.splice(0, upload.length);
  }

  onCropCancel() {
    this.display = false;
  }

  onCropSave() {
    this.organization.imageURL = this.data.image;
    this.imageUrl = this.data.image;
    this.display = false;
  }
}
