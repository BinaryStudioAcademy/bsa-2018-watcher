import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot } from '@angular/router';
import { UserOrganizationService } from '../services/user-organization.service';
import { OrganizationRole } from '../../shared/models/organization-role.model';

@Injectable()
export class ManagerGuard implements CanActivate {

  constructor(public userOrganizationService: UserOrganizationService, public router: Router) {
  }

  currentRole: OrganizationRole;
  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
    this.userOrganizationService.currentOrganizationRole.subscribe((role: OrganizationRole) => {
      this.currentRole = role;
    });

    if (this.currentRole.name === 'Manager') {
        return true;
      } else {
        this.router.navigate(['/user/dashboards']);
        return false;
      }
  }
}
