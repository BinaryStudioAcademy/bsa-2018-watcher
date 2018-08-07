import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { UserProfileComponent } from './user-profile/user-profile.component';
import { SettingsComponent } from './settings.component';
import { NotificationSettingsComponent } from './notification-settings/notification-settings.component';
import { OrganisationProfileComponent } from './organisation-profile/organisation-profile.component';

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
    path: 'organisation-profile',
    component: OrganisationProfileComponent
  }, {
    path: 'notification-settings',
    component: NotificationSettingsComponent
  }]
}];

@NgModule({
  imports: [RouterModule.forChild(settingsRoutes)],
  exports: [RouterModule]
})
export class SettingsRoutingModule {}
