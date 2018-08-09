import { Component, OnInit } from '@angular/core';
import { FormControl, FormBuilder, Validators } from '@angular/forms';
import { OrganizationService } from '../../core/services/organization.service';
import { ToastrService } from '../../core/services/toastr.service';
import { AuthService } from '../../core/services/auth.service';
import { Organization } from '../../shared/models/organization.model';

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
    private toastrService: ToastrService) {
      // TODO: Delete this after testing. Its need only to show how it works.
      this.editable = true;
  }

  editable: boolean;
  canUpdate: boolean;
  organization: Organization;

  organizationForm = this.fb.group({
    name: new FormControl({ value: '', disabled: true }, Validators.required),
    email: new FormControl({ value: '', disabled: true }),
    contactNumber: new FormControl({ value: '', disabled: true }),
    webSite: new FormControl({ value: '', disabled: true }),
    description: new FormControl({ value: '', disabled: true })
  });

  ngOnInit() {
    const user = this.authService.getCurrentUser();
    if (user == null) {
      return;
    }
    this.organizationService.get(user.lastPickedOrganizationId).subscribe((value: Organization) => {
      this.organization = value;
      this.subscribeOrganizationFormToData();

    // Only user who create organozation can edit it
      if (this.organization.createdByUserId === user.id) {
        this.editable = true;
      }
    });
  }

  enableEditing() {
    Object.keys(this.organizationForm.controls).forEach(field => {
      const control = this.organizationForm.get(field);
      control.enabled ? control.disable() : control.enable();
    });
    this.canUpdate ? this.canUpdate = false : this.canUpdate = true;
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
          this.toastrService.success('Organization was updated');
        },
        err => {
          this.toastrService.error('Organization was not updated');
        }
      );
    } else {
      Object.keys(this.organizationForm.controls).forEach(field => {
        const control = this.organizationForm.get(field);
        control.markAsDirty({ onlySelf: true });
      });
    }
  }
}
