import { Component, OnInit, Input, Output, EventEmitter, ViewChild } from '@angular/core';
import { FormBuilder, FormControl, Validators, MinLengthValidator } from '@angular/forms';
import { OrganizationService } from '../../core/services/organization.service';
import { AuthService } from '../../core/services/auth.service';
import { ToastrService } from '../../core/services/toastr.service';
import { Organization } from '../../shared/models/organization.model';
import { User } from '../../shared/models/user.model';
import { Spinner } from 'primeng/spinner';
import { tree } from 'd3';

@Component({
  selector: 'app-add-new-organization',
  templateUrl: './add-new-organization.component.html',
  styleUrls: ['./add-new-organization.component.sass']
})
export class AddNewOrganizationComponent implements OnInit {

  @Input() display = false;
  @Output() displayChange: EventEmitter<boolean> = new EventEmitter<boolean>();

  user: User;
  organization: Organization;

  organizationForm = this.fb.group({
    name: new FormControl('' , Validators.compose([Validators.required, Validators.minLength(4)])),
    email: new FormControl('', Validators.required),
    contactNumber: new FormControl(''),
    webSite: new FormControl('', Validators.pattern('^(http|https|ftp)?(://)?(www|ftp)?.?[a-z0-9-]+(.|:)([a-z0-9-]+)+([/?].*)?$')),
    description: new FormControl('')
  });

  constructor(  private organizationService: OrganizationService,
                private authService: AuthService,
                private toastrService: ToastrService,
                private fb: FormBuilder) {
  }

  ngOnInit() {
    this.authService.currentUser.subscribe(
      (userData) => {
        this.user = { ...userData };
    });
  }

  onClose() {
    this.display = false;
    this.displayChange.emit(this.display);
  }

  onAdd() {
    console.log('Add');
    if (!this.organizationForm.valid) { return; }

    this.organization = this.organizationForm.value;

    this.organizationService.create(this.organization).subscribe(
      value => {
        this.user.organizations.push(value);
        this.user.lastPickedOrganization = value;
        this.user.lastPickedOrganizationId = value.id;

        this.authService.updateCurrentUser(this.user);

        this.toastrService.success(`${value.name} organization Successfully established,
          and it was set as the default organization.`);
          this.clearFields();
      },
      err => {
        this.toastrService.error(`Error The organization was not created!`);
        this.clearFields();
      }
    );
    this.onClose();
  }

  private clearFields(): void {
    // Object.keys(this.organizationForm.controls).forEach(field => {
    //   const control = this.organizationForm.get(field);
    //   control.markAsUntouched({ onlySelf: true });
    //   control.setValue('');
    // });
  }

}
