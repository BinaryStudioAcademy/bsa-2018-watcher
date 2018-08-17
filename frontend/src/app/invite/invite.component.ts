import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthService } from '../core/services/auth.service';
import { ToastrService } from '../core/services/toastr.service';
import { OrganizationInvitesService } from '../core/services/organization-ivites.service';
import { OrganizationInvite } from '../shared/models/organization-invite.model';
import { OrganizationInviteState } from '../shared/models/organization-invite-state.enum';

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
  userId: string;

  constructor(private activatedRoute: ActivatedRoute,
              private authService: AuthService,
              private router: Router,
              private organizationInvitesService: OrganizationInvitesService,
              private toastrService: ToastrService) {
  }

  ngOnInit() {
    this.activatedRoute.params.subscribe(params => {
       this.link = params['invite'];
    });

    this.authService.currentUser.subscribe(
      user => {
        this.userId = user.id;
      }
    );

    this.organizationInvitesService.getByLink(this.link).subscribe(
      result => {
        this.invite = result;
        this.createdByUserName = this.invite.createdByUser.displayName;
        this.organizationName = this.invite.organization.name;
      },
      err => {
        console.log(err);
        this.router.navigate(['user']);
      }
    );
  }

  onAccept() {
    this.invite.invitedUserId = this.userId;
    this.invite.state = OrganizationInviteState.Accepted;
    this.updateInvite();
  }

  onReject() {
    this.invite.state = OrganizationInviteState.Declined;
    this.updateInvite();
  }

  updateInvite() {
    this.organizationInvitesService.update(this.invite.id, this.invite).subscribe(
      result => {
      this.toastrService.success('test');
      },
      err => {
        this.toastrService.error('error');
        console.log(err);
      }
    );
  }

}
