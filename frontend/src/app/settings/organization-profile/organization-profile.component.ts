import { Component, OnInit } from '@angular/core';
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
    private toastrService: ToastrService) { }

  editable: boolean;
  organization: Organization;

  inviteLink: string;

  private phoneRegex = /\(?([0-9]{3})\)?[ .-]?[0-9]*$/;
  private urlRegex = /[-a-zA-Z0-9@:%_\+.~#?&//=]{2,256}\.[a-z]{2,4}/;

  organizationForm = this.fb.group({
    name: new FormControl({ value: '', disabled: true }, Validators.required),
    email: new FormControl({ value: '', disabled: true }, Validators.email),
    contactNumber: new FormControl({ value: '', disabled: true }, Validators.pattern(this.phoneRegex)),
    webSite: new FormControl({ value: '', disabled: true }, Validators.pattern(this.urlRegex)),
    description: new FormControl({ value: '', disabled: true })
  });

  ngOnInit() {
    const user = this.authService.getCurrentUser();
    if (user == null || user.lastPickedOrganizationId == null) {
      return;
    }

    if (user.lastPickedOrganization == null && user.lastPickedOrganizationId !== 0) {
      this.organizationService.get(user.lastPickedOrganizationId).subscribe((value: Organization) => {
        this.organization = value;
        this.subscribeOrganizationFormToData();

        // Only user who create organozation can edit it
        if (this.organization.createdByUserId === user.id) {
          this.editable = true;
        }
      });
    } else {
      this.organization = user.lastPickedOrganization;
      this.subscribeOrganizationFormToData();
      if (this.organization.createdByUserId === user.id) {
        this.editable = true;
      }
    }

    Object.keys(this.organizationForm.controls).forEach(field => {
      const control = this.organizationForm.get(field);
      control.enable();
    });
  }

  subscribeOrganizationFormToData() {
    Object.keys(this.organizationForm.controls).forEach(field => {
      const control = this.organizationForm.get(field);
      control.setValue(this.organization[field]);
      control.valueChanges.subscribe(value => {
        this.organization[field] = value;
      });
    });
  }

  onSubmit() {
    if (this.organizationForm.valid && this.editable) {
      this.organizationService.update(this.organization.id, this.organization).subscribe(
        value => {
          const user = this.authService.getCurrentUser();
          user.lastPickedOrganization = this.organization;
          this.toastrService.success('Organization was updated');
        },
        err => {
          this.toastrService.error('Organization was not updated');
        }
      );
    } else {
      this.toastrService.error('Form was filled incorrectly');

      Object.keys(this.organizationForm.controls).forEach(field => {
        const control = this.organizationForm.get(field);
        control.markAsDirty({ onlySelf: true });
      });
    }
  }

  onInvite() {
    const invite: OrganizationInvite = {
      id: 0,
      organizationId: this.organization.id,
      createdByUserId: this.authService.getCurrentUser().id,
      inviteEmail: 'San7Av1.0@gmail.com',
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
        this.inviteLink = `${environment.client_url}/user/invite/${value.link}`;
      },
      err => {
        this.toastrService.error('Organization Invite was not created');
      }
    );
  }

  onCopy() {
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
  }
}
