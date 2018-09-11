import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder, FormControl, Validators, FormGroup } from '@angular/forms';
import { ToastrService } from '../../core/services/toastr.service';
import { InstanceService } from '../../core/services/instance.service';
import { AuthService } from '../../core/services/auth.service';
import { Instance } from '../../shared/models/instance.model';
import { InstanceRequest } from '../models/instance-request.model';
import { SelectItem } from 'primeng/api';

@Component({
  selector: 'app-edit-instance',
  templateUrl: './edit-instance.component.html',
  styleUrls: ['./edit-instance.component.sass']
})
export class EditInstanceComponent implements OnInit {

  id: number;
  organizationId: number;
  instanceForm: FormGroup;
  instance: Instance;
  instanceTitle: string;
  platformsDropdown: SelectItem[];
  selectedPlatform: string;
  isSaving: Boolean = false;

  constructor(private activateRoute: ActivatedRoute,
    private fb: FormBuilder,
    private toastrService: ToastrService,
    private instanceService: InstanceService,
    private authService: AuthService,
    private router: Router) {
    this.platformsDropdown = [];
  }

  ngOnInit() {
    const x = this.activateRoute.params.subscribe(params => {
      this.id = params['insId'];
      if (this.id) {
        this.instanceService.getOne(this.id).subscribe((data: Instance) => {
          if (data) {
            this.instance = data;
            this.instanceForm = this.getInstanceForm(this.instance);
          }
        });
      }
    });
    const user = this.authService.getCurrentUser();
    if (user == null || user.lastPickedOrganizationId == null) {
      this.toastrService.error('User must taking part in organization');
      return;
    } else {
      this.organizationId = user.lastPickedOrganization.id;
    }
    this.instanceForm = this.getInstanceForm(this.instance);
    this.fillPlatformsDropdown();
    this.instanceForm.controls['platform'].setValue(this.platformsDropdown[0].value);
  }

  getInstanceForm(instance: Instance) {
    let form: FormGroup;

    if (instance) {
      this.instanceTitle = 'EDIT INSTANCE';
    } else {
      instance = {
        title: '',
        platform: '',
        address: '',
        guidId: '',
        aggregationForHour: true,
        aggregationForDay: true,
        aggregationForMonth: true,
        aggregationForWeek: true,
        cpuMaxPercent: 90,
        ramMaxPercent: 90,
        diskMaxPercent: 90,
        isActive: true
      };
      this.instanceTitle = 'NEW INSTANCE';
    }
    form = this.fb.group({
      title: new FormControl({ value: instance.title, disabled: false }, Validators.required),
      platform: new FormControl({ value: instance.platform, disabled: false }, Validators.required),
      address: new FormControl({ value: instance.address, disabled: false }), // , Validators.required
      guid: new FormControl({ value: instance.guidId, disabled: false }),
      aggregationHour: new FormControl({value: instance.aggregationForHour, disabled: false}),
      aggregationDay: new FormControl({value: instance.aggregationForDay, disabled: false}),
      aggregationMonth: new FormControl({value: instance.aggregationForMonth, disabled: false}),
      aggregationWeek: new FormControl({value: instance.aggregationForWeek, disabled: false}),
      cpuMax: new FormControl({value: instance.cpuMaxPercent, disabled: false}),
      ramMax: new FormControl({value: instance.ramMaxPercent, disabled: false}),
      diskMax: new FormControl({value: instance.diskMaxPercent, disabled: false})
    });
    return form;
  }

  onSubmit() {
    if (this.instanceForm.valid) {
      this.isSaving = true;
      const request: InstanceRequest = this.getNewInstance();
      if (this.id) {
        request.guidId = this.instance.guidId;
        this.instanceService.update(request, this.id).subscribe((res: Response) => {
          this.toastrService.success('updated instance');

          const updatedInstance: Instance = Object.assign({}, request,
            {id: this.id,
            dashboards: this.instance.dashboards,
            organization: this.instance.organization
            });

          this.instanceService.instanceEdited.emit(updatedInstance);
          this.router.navigate([`/user/instances/${updatedInstance.id}/${this.instance.guidId}/dashboards`]);
          this.isSaving = false;
        });
      } else {
        this.instanceService.create(request).subscribe((res: Instance) => {
          this.toastrService.success('created instance');
          this.instanceService.instanceAdded.emit(res);
          this.router.navigate([`/user/instances/${res.id}/${res.guidId}/dashboards`]);
          this.isSaving = false;
        });
      }
    } else {
      this.toastrService.error('Invalid form');
      this.isSaving = false;
    }
  }

  getNewInstance(): InstanceRequest {

    const newInstance: InstanceRequest = {
      title: this.instanceForm.controls.title.value,
      address: this.instanceForm.controls.address.value,
      platform: this.instanceForm.controls.platform.value,
      isActive: true,
      aggregationForDay: this.instanceForm.controls.aggregationDay.value,
      aggregationForHour: this.instanceForm.controls.aggregationHour.value,
      aggregationForMonth: this.instanceForm.controls.aggregationMonth.value,
      aggregationForWeek: this.instanceForm.controls.aggregationWeek.value,
      cpuMaxPercent: this.instanceForm.controls.cpuMax.value,
      ramMaxPercent: this.instanceForm.controls.ramMax.value,
      diskMaxPercent: this.instanceForm.controls.diskMax.value,
      organizationId: this.organizationId
    };
    return newInstance;
  }

  private fillPlatformsDropdown(): void {
    this.platformsDropdown.push(
      { label: 'Windows', value: 'Windows' },
      { label: 'Linux', value: 'Linux' });
  }

  copyToClipboard(message: string): void {
    const selBox = document.createElement('textarea');
    selBox.style.position = 'fixed';
    selBox.style.left = '0';
    selBox.style.top = '0';
    selBox.style.opacity = '0';
    selBox.value = message;
    document.body.appendChild(selBox);
    selBox.focus();
    selBox.select();
    document.execCommand('copy');
    document.body.removeChild(selBox);
    this.toastrService.info(`Copied to clipboard`);
  }
}
