import { Component, OnInit } from '@angular/core';
import { FormControl, FormBuilder, Validators } from '@angular/forms';
import { UserService } from '../../core/services/user.service';
import { User } from '../../shared/models/user.model';
import { AuthService } from '../../core/services/auth.service';
import { ToastrService } from '../../core/services/toastr.service';
import { Organization } from '../../shared/models/organization.model';
import { OrganizationService } from '../../core/services/organization.service';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.sass']
})
export class UserListComponent implements OnInit {

  users: User[];
  user: User;
  currentUser: User;
  display: boolean;
  totalRecords: number;
  simplelstOrganizations: Organization[];
  lstOrganizationId: number[];
  lstOrganizations: [{id: number, assign: boolean}];

  constructor(
    private fb: FormBuilder,
    private authService: AuthService,
    private userService: UserService,
    private organizationService: OrganizationService,
    private toastrService: ToastrService) {

    this.display = false;
  }

  userForm = this.fb.group({
    displayName: new FormControl({ value: '', disabled: false }, Validators.required),
    firstName: new FormControl({ value: '', disabled: false }),
    lastName: new FormControl({ value: '', disabled: false }),
    email: new FormControl({ value: '', disabled: false }, Validators.email),
    lastPickedOrganizationId: new FormControl({ value: 0, disabled: false }),
    bio: new FormControl({ value: '', disabled: false }),
    isActive: new FormControl({ value: true, disabled: false }, Validators.required)
  });

  ngOnInit() {
    this.currentUser = this.authService.getCurrentUser();
    if (this.currentUser == null) {
      return;
    }

    this.userService.getAll().subscribe((value: User[]) => {
      this.users = value;
      this.totalRecords = value.length;
    });

    this.organizationService.getAll().subscribe((value: Organization[]) => {
      this.simplelstOrganizations = value;
      this.fillLstFeedbacks();
    });
  }

  private fillLstFeedbacks(): void {
    this.simplelstOrganizations.forEach(el => this.lstOrganizations.push({ id: el.id, assign: false }));
   }

  subscribeOrganizationFormToData() {
    Object.keys(this.userForm.controls).forEach(field => {
      const control = this.userForm.get(field);
      control.setValue(this.user[field]);
    });
  }

  showPopup(user: User) {
    this.user = user;
    this.subscribeOrganizationFormToData();
    this.display = true;
    this.lstOrganizationId = user.organizations.map(x => Object.assign({}, x.id));
    this.lstOrganizationId.push(user.lastPickedOrganizationId);
    console.log(this.lstOrganizationId);
  }

  onCancel() {
    this.display = false;
  }

  onSubmit() {
    this.display = false;

    if (this.userForm.valid) {
      Object.keys(this.userForm.controls).forEach(field => {
        this.user[field] = this.userForm.get(field).value;
        });
      this.userService.update(this.user.id, this.user).subscribe(
        value => {
          this.toastrService.success('User was updated');
        },
        error => {
          this.toastrService.error(`Error ocured status: ${error.message}`);
        }
      );
    } else {
      this.toastrService.error('Form was filled incorrectly');
    }

  }

}
