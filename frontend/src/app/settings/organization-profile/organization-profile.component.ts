import { Component, OnInit } from '@angular/core';
import { FormControl, FormBuilder, Validators } from '@angular/forms';
import { Organization } from '../../shared/models/organization';
import { OrganizationService } from '../../core/services/organization.service';
import { MessageService } from '../../../../node_modules/primeng/api';

@Component({
  selector: 'app-organization-profile',
  templateUrl: './organization-profile.component.html',
  styleUrls: ['./organization-profile.component.sass'],
  providers: [
    MessageService, OrganizationService
  ]
})
export class OrganizationProfileComponent implements OnInit {

  constructor(
    private fb: FormBuilder,
    private organizationService: OrganizationService,
    private messageService: MessageService) { }

  private editable: boolean;
  private canUpdate: boolean;
  private organization: Organization;

  private organizationForm = this.fb.group({
    name: new FormControl({ value: '', disabled: true }, Validators.required),
    email: new FormControl({ value: '', disabled: true }),
    contactNumber: new FormControl({ value: '', disabled: true }),
    webSite: new FormControl({ value: '', disabled: true }),
    description: new FormControl({ value: '', disabled: true })
  });

  ngOnInit() {
    const organizationId = 76; // currentUser.lastPickedOrganizationId
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
      this.organizationService.update(this.organization.id, this.organization).subscribe(
        value => {
          this.messageService.add({severity: 'success', summary: 'Success', detail: 'Organization was updated'});
        },
        err => {
          this.messageService.add({severity: 'error', summary: 'Error', detail: 'Organization was not updated'});
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
