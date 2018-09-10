import { Component, OnInit } from '@angular/core';
import { FormControl, FormBuilder, Validators } from '@angular/forms';
import { OrganizationService } from '../../core/services/organization.service';
import { InstanceService } from '../../core/services/instance.service';
import { User } from '../../shared/models/user.model';
import { Feedback } from '../../shared/models/feedback.model';
import { AuthService } from '../../core/services/auth.service';
import { ToastrService } from '../../core/services/toastr.service';
import { Organization } from '../../shared/models/organization.model';
import { Instance } from '../../shared/models/instance.model';
import { InstanceRequest } from '../../dashboards/models/instance-request.model';
import { LazyLoadEvent } from '../../../../node_modules/primeng/api';

@Component({
  selector: 'app-organization-list',
  templateUrl: './organization-list.component.html',
  styleUrls: ['./organization-list.component.sass']
})
export class OrganizationListComponent implements OnInit {

  organization: Organization;
  organizations: Organization[];
  user: User;
  display: boolean;
  totalRecords: number;
  lstInstances: Instance[];

  constructor(
              private fb: FormBuilder,
              private authService: AuthService,
              private organizationService: OrganizationService,
              private instanceService: InstanceService,
              private toastrService: ToastrService) {
    this.display = false;
  }

  private phoneRegex = /\(?([0-9]{3})\)?[ .-]?[0-9]*$/;
  private urlRegex = /[-a-zA-Z0-9@:%_\+.~#?&//=]{2,256}\.[a-z]{2,4}/;

  organizationForm = this.fb.group({
    name: new FormControl({ value: '', disabled: false }, Validators.required),
    email: new FormControl({ value: '', disabled: false }, Validators.email),
    contactNumber: new FormControl({ value: '', disabled: false }, Validators.pattern(this.phoneRegex)),
    webSite: new FormControl({ value: '', disabled: false }, Validators.pattern(this.urlRegex)),
    description: new FormControl({ value: '', disabled: false }),
    isActive: new FormControl({ value: true, disabled: false })
  });

  ngOnInit() {
    this.user = this.authService.getCurrentUser();
    if (this.user == null) {
      return;
    }

    this.organizationService.getNumber().subscribe((value: number) => this.totalRecords = value);

    this.organizationService.getRange(1, 5).subscribe((value: Organization[]) => {
      this.organizations = value;
    });
  }

  subscribeOrganizationFormToData() {
    Object.keys(this.organizationForm.controls).forEach(field => {
      const control = this.organizationForm.get(field);
      control.setValue(this.organization[field]);
    });
  }

  showPopup(organization: Organization) {
    this.organization = organization;
    this.subscribeOrganizationFormToData();
    this.display = true;
    this.lstInstances = organization.instances.map(x => Object.assign({}, x));
  }

  onCancel() {
    this.display = false;
    this.lstInstances = this.organization.instances;
    this.organization = null;
  }

  getNewInstance(instance: Instance) {
    const newInstance: InstanceRequest = {
      title: instance.title,
      address: instance.address,
      platform: instance.platform,
      isActive: instance.isActive,
      organizationId: this.organization.id
    };
    return newInstance;
  }

  uniqueFields(name: string, email: string) {
    let flag = true;
    this.organizations.forEach(o => {
      if ((o.name === name || o.email === email) && o.id !== this.organization.id) {
        flag = false; }});
    return flag;
  }

  loadOrganizationsLazy(event: LazyLoadEvent) {
    const currentPage = event.first / event.rows + 1;
    this.organizationService.getRange(currentPage, event.rows).subscribe((value: Organization[]) => {
      this.organizations = value;
    });
  }

  onSubmit() {
    this.display = false;
    const name = this.organizationForm.get('name').value;
    const email = this.organizationForm.get('email').value;
    if (this.organizationForm.valid && this.uniqueFields(name, email)) {
      this.organization.theme = null;
      Object.keys(this.organizationForm.controls).forEach(field => {
        this.organization[field] = this.organizationForm.get(field).value;
        });
      this.organization.instances = this.lstInstances;
      this.organizationService.update(this.organization.id, this.organization).subscribe(
        value => {
          this.toastrService.success('Organization was updated');
        },
        error => {
          this.toastrService.error(`Error ocured status: ${error.message}`);
        }
      );
    } else {
      this.toastrService.error('Form was filled incorrectly');
    }
    this.lstInstances.forEach(instance => {
      const instanceNew: InstanceRequest = this.getNewInstance(instance);
        this.instanceService.update(instanceNew, instance.id).subscribe(
        value => {
          this.toastrService.success(`Instance with id ${instance.id} was updated`);
        },
        error => {
          this.toastrService.error(`Error ocured status: ${error.message}`);
        }
      ); });
  }
}
