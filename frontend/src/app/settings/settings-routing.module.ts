import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { UserProfileComponent } from './user-profile/user-profile.component';
import { SettingsComponent } from './settings.component';
import { NotificationSettingsComponent } from './notification-settings/notification-settings.component';
import { OrganizationProfileComponent } from './organization-profile/organization-profile.component';
import { OrganizationMembersComponent } from './organization-members/organization-members.component';

const settingsRoutes: Routes = [{
  path: '',
  component: SettingsComponent,
  children: [{
    path: '',
    redirectTo: 'user-profile'
  }, {
    path: 'user-profile',
    component: UserProfileComponent
  }, {
    path: 'organization-profile',
    component: OrganizationProfileComponent
  }, {
    path: 'notification-settings',
    component: NotificationSettingsComponent
  }, {
    path: 'organization-members',
    component: OrganizationMembersComponent
  }]
}];

@NgModule({
  imports: [RouterModule.forChild(settingsRoutes)],
  exports: [RouterModule]
})
export class SettingsRoutingModule {}
