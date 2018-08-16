import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { AuthService } from '../core/services/auth.service';
import { ToastrService } from '../core/services/toastr.service';
import { OrganizationInvitesService } from '../core/services/organization-ivites.service';
import { OrganizationInvite } from '../shared/models/organization-invite.model';

@Component({
  selector: 'app-invite',
  templateUrl: './invite.component.html',
  styleUrls: ['./invite.component.sass']
})
export class InviteComponent implements OnInit {

  link: string;
  invite: OrganizationInvite;
  createdByUserName: string;
  organizationName: string;

  constructor(private activatedRoute: ActivatedRoute,
              private authService: AuthService,
              private organizationInvitesService: OrganizationInvitesService,
              private toastrService: ToastrService) {
  }

  ngOnInit() {
    this.activatedRoute.params.subscribe(params => {
       this.link = params['invite'];
    });

    this.organizationInvitesService.getByLink(this.link).subscribe(
      result => {
        this.invite = result;
        this.createdByUserName = this.invite.createdByUser.displayName;
        this.organizationName = this.invite.organization.name;
      },
      err => {
        console.log(err);
      }
    );
  }
}
