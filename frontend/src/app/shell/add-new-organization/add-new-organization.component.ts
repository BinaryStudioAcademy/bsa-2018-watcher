import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { FormBuilder, FormControl, Validators } from '@angular/forms';
import { OrganizationService } from '../../core/services/organization.service';
import { AuthService } from '../../core/services/auth.service';
import { ToastrService } from '../../core/services/toastr.service';
import { Organization } from '../../shared/models/organization.model';
import { User } from '../../shared/models/user.model';

@Component({
  selector: 'app-add-new-organization',
  templateUrl: './add-new-organization.component.html',
  styleUrls: ['./add-new-organization.component.sass']
})
export class AddNewOrganizationComponent implements OnInit {

  @Input() display = false;
  @Output() displayChange: EventEmitter<boolean> = new EventEmitter<boolean>();

  user: User;

  name = '';
  email = '';
  contactNumber = '';
  webSite = '';
  description = '';
  isAdding: Boolean = false;

  constructor(  private organizationService: OrganizationService,
                private authService: AuthService,
                private toastrService: ToastrService) {
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
    this.isAdding = true;
    const org = <Organization>{};
    org.name = this.name;
    org.email = this.email;
    org.contactNumber = this.contactNumber;
    org.webSite = this.webSite;
    org.description = this.description;
    org.createdByUserId = this.user.id;
    org.usersId = new Array<string>(this.user.id);

    this.organizationService.create(org).subscribe(
      value => {
        this.user.organizations.push(value);
        this.user.lastPickedOrganization = value;
        this.user.lastPickedOrganizationId = value.id;

        this.authService.updateCurrentUser(this.user);

        this.toastrService.success(`${value.name} organization Successfully established,
          and it was set as the default organization.`);
        this.isAdding = false;
      },
      err => {
        this.toastrService.error(`Error The organization was not created!`);
        this.isAdding = false;
      }
    );
    this.onClose();
  }

}
