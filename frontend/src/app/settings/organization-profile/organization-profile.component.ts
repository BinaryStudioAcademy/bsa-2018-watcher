import { Component, OnInit } from '@angular/core';
import { FormControl, FormBuilder, Validators } from '@angular/forms';
import { Organization } from '../../shared/models/organization';
import { OrganizationService } from '../../core/services/organization.service';

@Component({
  selector: 'app-organization-profile',
  templateUrl: './organization-profile.component.html',
  styleUrls: ['./organization-profile.component.sass'],
  providers: [OrganizationService]
})
export class OrganizationProfileComponent implements OnInit {

  constructor(private fb: FormBuilder, private organizationService: OrganizationService) {
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
    const organizationId = 76; // currentUser.choosedOrganizationId
    this.organizationService.get(organizationId).subscribe((value: Organization) => {
      this.organization = value;
      this.subscribeOrganizationFormToData();
    });

    // There need to check if organization created by current user
    // if (this.organization.createdByUserId == currentUser.id)
    this.editable = true;
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
      this.organizationService.update(this.organization.id, this.organization).subscribe();
    } else {
      Object.keys(this.organizationForm.controls).forEach(field => {
        const control = this.organizationForm.get(field);
        control.markAsDirty({ onlySelf: true });
      });
    }
  }
}
