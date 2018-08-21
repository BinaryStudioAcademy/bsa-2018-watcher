import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { FormBuilder, FormControl, Validators } from '@angular/forms';
import { OrganizationService } from '../../core/services/organization.service';
import { AuthService } from '../../core/services/auth.service';
import { ToastrService } from '../../core/services/toastr.service';
import { Organization } from '../../shared/models/organization.model';

@Component({
  selector: 'app-add-new-organization',
  templateUrl: './add-new-organization.component.html',
  styleUrls: ['./add-new-organization.component.sass']
})
export class AddNewOrganizationComponent implements OnInit {

  @Input() display = false;
  @Output() displayChange: EventEmitter<boolean> = new EventEmitter<boolean>();

  organization: Organization;
  private phoneRegex = /\(?([0-9]{3})\)?[ .-]?[0-9]*$/;
  private urlRegex = /[-a-zA-Z0-9@:%_\+.~#?&//=]{2,256}\.[a-z]{2,4}/;



  constructor(  private organizationService: OrganizationService,
                private authService: AuthService,
                private toastrService: ToastrService) { }

  ngOnInit() {
  }

  onClose() {
    this.display = false;
    this.displayChange.emit(this.display);
  }

}
