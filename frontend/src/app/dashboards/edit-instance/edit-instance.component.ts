import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '../../../../node_modules/@angular/router';
import { FormBuilder, FormControl, Validators, FormGroup } from '../../../../node_modules/@angular/forms';
import { ToastrService } from '../../core/services/toastr.service';
import { InstanceService } from '../../core/services/instance.service';
import { AuthService } from '../../core/services/auth.service';
import { Instance } from '../../shared/models/instance.model';
import { InstanceRequest } from '../models/instance-request.model';

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

  constructor(private activateRoute: ActivatedRoute,
    private fb: FormBuilder,
    private toastrService: ToastrService,
    private instanceService: InstanceService,
    private authService: AuthService,
    private router: Router) { }

  getInstanceForm(instance: Instance) {
    let form: FormGroup;
    if (instance === undefined) {
      form = this.fb.group({
        title: new FormControl({ value: '', disabled: false }, Validators.required),
        platform: new FormControl({ value: '', disabled: false }, Validators.required),
        address: new FormControl({ value: '', disabled: false }, Validators.required)
      });
    } else {
      form = this.fb.group({
        title: new FormControl({ value: instance.title, disabled: false }, Validators.required),
        platform: new FormControl({ value: instance.platform, disabled: false }, Validators.required),
        address: new FormControl({ value: instance.address, disabled: false }, Validators.required)
      });
    }
    return form;
  }

  getNewInstance() {
    const newInstance: InstanceRequest = {
      title: this.instanceForm.controls.title.value,
      address: this.instanceForm.controls.address.value,
      platform: this.instanceForm.controls.platform.value,
      organizationId: this.organizationId
    };
    return newInstance;
  }

  onSubmit() {
    if (this.instanceForm.valid) {
      const instance: InstanceRequest = this.getNewInstance();
      if (this.id) {
        this.instanceService.update(instance, this.id).subscribe((res: Response) => {
          this.toastrService.success('updated instance');
          const instanceEvent: Instance = {
            title: instance.title,
            address: instance.address,
            id: this.id,
            platform: instance.platform
          };
          this.instanceService.instanceEdited.emit(instanceEvent);
          this.router.navigate([`/user/instance/${instanceEvent.id}/dashboards`]);
        });
      } else {
        this.instanceService.create(instance).subscribe((res: Instance) => {
          this.toastrService.success('created instance');
          this.instanceService.instanceAdded.emit(res);
          this.router.navigate([`/user/instance/${res.id}/dashboards`]);
        });
      }
    } else {
      this.toastrService.error('Invalid form');
    }
  }

  ngOnInit() {
    const x = this.activateRoute.params.subscribe(params => {
      this.id = params['id'];
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
  }
}
