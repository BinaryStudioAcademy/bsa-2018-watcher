import { Component, OnInit } from '@angular/core';
import { OrganizationInvite } from '../../shared/models/organization-invite.model';

@Component({
  selector: 'app-invites-list',
  templateUrl: './invites-list.component.html',
  styleUrls: ['./invites-list.component.sass']
})
export class InvitesListComponent implements OnInit {

  values: number[];
  invites: OrganizationInvite[];

  constructor() { }

  ngOnInit() {
    this.values = [1, 2, 3, 4, 5];
  }

}
