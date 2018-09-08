import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot } from '@angular/router';
import { UserOrganizationService } from '../services/user-organization.service';
import { OrganizationRole } from '../../shared/models/organization-role.model';

@Injectable()
export class ManagerGuard implements CanActivate {

  constructor(public userOrganizationService: UserOrganizationService, public router: Router) {}

  currentRole: OrganizationRole;
  async canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Promise < boolean > {
    this.currentRole = await this.userOrganizationService.getOrganizationRole();
    if (this.currentRole.name === 'Manager') {
      return true;
    } else {
      this.router.navigate(['/user/instances']);
      return false;
    }
  }
}
