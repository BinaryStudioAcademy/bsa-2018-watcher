import { Component, OnInit } from '@angular/core';
import { FormControl, FormBuilder, Validators } from '@angular/forms';
import { Organization } from '../../shared/models/organization.model';

@Component({
  selector: 'app-organization-profile',
  templateUrl: './organization-profile.component.html',
  styleUrls: ['./organization-profile.component.sass']
})
export class OrganizationProfileComponent implements OnInit {

  organization: Organization;
  constructor(private fb: FormBuilder) { }

  organizationForm = this.fb.group({
    name: new FormControl({ value: '', disabled: true }, Validators.required),
    description: new FormControl({ value: '', disabled: true }),
    email: new FormControl({ value: '', disabled: true })
  });

  ngOnInit() {
  }

  canEdit() {
    Object.keys(this.organizationForm.controls).forEach(field => {
      const control = this.organizationForm.get(field);
      control.enable();
    });
  }

onSubmit() {
  if (this.organizationForm.valid) {

  } else {
    Object.keys(this.organizationForm.controls).forEach(field => {
      const control = this.organizationForm.get(field);
      control.markAsDirty({ onlySelf: true });
      control.enable();
    });
  }
}
}
