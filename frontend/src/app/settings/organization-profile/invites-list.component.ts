import { Component, OnInit, ViewChild } from '@angular/core';
import { OrganizationInvite } from '../../shared/models/organization-invite.model';
import { OrganizationInvitesService } from '../../core/services/organization-invites.service';
import { OrganizationInvitesHub } from '../../core/hubs/organization-invites.hub';
import { AuthService } from '../../core/services/auth.service';
import { User } from '../../shared/models/user.model';
import { ToastrService } from '../../core/services/toastr.service';
import { DataTable } from 'primeng/primeng';
import { DataView } from 'primeng/dataview';

@Component({
  selector: 'app-invites-list',
  templateUrl: './invites-list.component.html',
  styleUrls: ['./invites-list.component.sass']
})
export class InvitesListComponent implements OnInit {

  @ViewChild('dt') dataTable: DataView;

  invites: OrganizationInvite[];

  currentUser: User;

  indexFirstRecordPage = 0;
  rowsPerPage = 2;

  constructor(private organizationInvitesService: OrganizationInvitesService,
              private organizationInvitesHub: OrganizationInvitesHub,
              private authService: AuthService,
              private toastrService: ToastrService) { }

  ngOnInit() {
    this.currentUser = this.authService.getCurrentUser();
    this.organizationInvitesService.getByUser(this.currentUser.id).subscribe((value: OrganizationInvite[]) => {
      value.forEach(item => item.experationDate = new Date(item.experationDate));
      this.invites = value;
    });

    this.registerOnHubEvents();
  }

  onUpdate(id: number): void {
    const invite = this.invites.find(item => item.id === id);

    this.organizationInvitesService.update(id, invite).subscribe(value => {
      this.toastrService.success('Invite was updated');
    }, err => {
      this.toastrService.error('Invite wasn`t updated');
    });
  }

  onDelete(id: number): void {
    this.organizationInvitesService.delete(id).subscribe(value => {
      this.toastrService.success('Invite was deleted');
    }, err => {
      this.toastrService.error('Invite wasn`t deleted');
    });
  }

  onPaginate(event): void {
    this.indexFirstRecordPage = event.first;
  }

  setCurrentPage(index: number) {
      const paging = {
        first: index,
        rows: this.rowsPerPage
    };
    this.dataTable.paginate(paging);
  }

  registerOnHubEvents(): void {
    this.organizationInvitesHub.onAddInvite.subscribe((invite: OrganizationInvite) => {
      invite.experationDate = new Date(invite.experationDate);
      this.invites.push(invite);
    });

    this.organizationInvitesHub.onDeleteInvite.subscribe((id: number) => {
      const index = this.invites.map(item => item.id).indexOf(id);

      if (index === this.invites.length - 1 && this.indexFirstRecordPage === index && index > 0) {
        this.setCurrentPage(this.indexFirstRecordPage - this.rowsPerPage);
      }

      this.invites.splice(index, 1);
    });
  }
}
