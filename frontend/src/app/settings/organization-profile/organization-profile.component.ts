import { Component, OnInit } from '@angular/core';
import { FormControl, FormBuilder, Validators, FormGroup } from '@angular/forms';
import { Observable } from 'rxjs';
import { Organization } from '../../shared/models/organization';
import { OrganizationService } from '../../core/services/organization.service';

@Component({
  selector: 'app-organization-profile',
  templateUrl: './organization-profile.component.html',
  styleUrls: ['./organization-profile.component.sass'],
  providers: [ OrganizationService ]
})
export class OrganizationProfileComponent implements OnInit {

  editable: boolean;
  canUpdate: boolean;

  organization: Organization;
  organizationForm: FormGroup;

  constructor(private fb: FormBuilder, private organizationService: OrganizationService) {
    // There need to check if organization created by current user
    this.editable = true;

    this.organization = {
      id: 1,
      name: 'Binary-Studio',
      email: 'example@gmail.com',
      description: 'The is description of this organization.',
      contactNumber: '300-200-100',
      webSite: 'example.com',
      isActive: true,
      themeId: 1,
      chatId: 1,
      createdByUserId: 1,
      usersId: [],
      instancesId: [],
      notificationsId: []
    };
   }

  ngOnInit( ) {
    this.organizationForm = this.fb.group({
      name: new FormControl({ value: this.organization.name, disabled: true }, Validators.required),
      email: new FormControl({ value: this.organization.email, disabled: true }),
      contactNumber: new FormControl({ value: this.organization.contactNumber, disabled: true }),
      webSite: new FormControl({ value: this.organization.webSite, disabled: true }),
      description: new FormControl({ value: this.organization.description, disabled: true })
    });
  }

  enableEditing() {
    Object.keys(this.organizationForm.controls).forEach(field => {
      const control = this.organizationForm.get(field);
      control.enable();
    });
    this.canUpdate = true;
  }

onSubmit() {
  if (this.organizationForm.valid) {
    this.organization = this.organizationForm.value;
    // Update through request
  } else {
    Object.keys(this.organizationForm.controls).forEach(field => {
      const control = this.organizationForm.get(field);
      control.markAsDirty({ onlySelf: true });
      control.enable();
    });
  }
}
}
