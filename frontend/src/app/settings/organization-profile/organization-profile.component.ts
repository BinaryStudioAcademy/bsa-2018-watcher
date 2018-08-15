import { Component, OnInit } from '@angular/core';
import { FormControl, FormBuilder, Validators } from '@angular/forms';
import { OrganizationService } from '../../core/services/organization.service';
import { ToastrService } from '../../core/services/toastr.service';
import { AuthService } from '../../core/services/auth.service';
import { Organization } from '../../shared/models/organization.model';
import { usesServiceWorker } from '../../../../node_modules/@angular-devkit/build-angular/src/angular-cli-files/utilities/service-worker';

@Component({
  selector: 'app-organization-profile',
  templateUrl: './organization-profile.component.html',
  styleUrls: ['./organization-profile.component.sass'],
  providers: [
    ToastrService, OrganizationService
  ]
})
export class OrganizationProfileComponent implements OnInit {

  constructor(
    private fb: FormBuilder,
    private organizationService: OrganizationService,
    private authService: AuthService,
    private toastrService: ToastrService) { }

  editable: boolean;
  organization: Organization;

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
}
