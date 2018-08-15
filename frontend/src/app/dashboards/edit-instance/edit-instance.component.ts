import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '../../../../node_modules/@angular/router';
import { FormBuilder, FormControl, Validators, FormGroup } from '../../../../node_modules/@angular/forms';
import { ToastrService } from '../../core/services/toastr.service';
import { InstanceService } from '../../core/services/instance.service';
import { AuthService } from '../../core/services/auth.service';
import { Organization } from '../../shared/models/organization.model';

@Component({
  selector: 'app-edit-instance',
  templateUrl: './edit-instance.component.html',
  styleUrls: ['./edit-instance.component.sass']
})
export class EditInstanceComponent implements OnInit {

  id: number;
  creation: boolean;
  organizationId: number;
  instanceForm: FormGroup;

  constructor(private activateRoute: ActivatedRoute,
    private fb: FormBuilder,
    private toastrService: ToastrService,
    private instanceService: InstanceService,
    private authService: AuthService) { }

  getInstanceForm(creation: boolean) {
    let form: FormGroup;
    if (creation) {
      form = this.fb.group({
        title: new FormControl({ value: '', disabled: false }, Validators.required),
        platform: new FormControl({ value: '', disabled: false }, Validators.required),
        address: new FormControl({ value: '', disabled: false }, Validators.required)
      });
    } else {
      form = this.fb.group({
        title: new FormControl({ value: this.id, disabled: false }, Validators.required),
        platform: new FormControl({ value: this.id, disabled: false }, Validators.required),
        address: new FormControl({ value: this.id, disabled: false }, Validators.required)
      });
    }
    return form;
  }

  onSubmit() {
    if (this.instanceForm.valid) {this.toastrService.success('Valid form'); } else {
      this.toastrService.error('Invalid form');
    }
  }

  ngOnInit() {
    const x = this.activateRoute.params.subscribe(params => {
      this.id = params['id'];
      if (this.id) {
      this.creation = false;
      console.log(this.creation);
      const user = this.authService.getCurrentUser();
      if (user == null || user.lastPickedOrganizationId == null) {
        this.toastrService.error('User must taking part in organization');
        return;
      } else { this.organizationId = user.lastPickedOrganization.id; }
    }      this.instanceForm = this.getInstanceForm(this.creation);
  });
  }
}
