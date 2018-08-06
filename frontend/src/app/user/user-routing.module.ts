import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DashboardComponent } from '../dashboards/dashboard/dashboard.component';
import { UserComponent } from './user.component';
import { SettingsComponent } from '../settings/settings.component';
import { NotificationSettingsComponent } from '../settings/notification-settings/notification-settings.component';
import { UserProfileComponent } from '../settings/user-profile/user-profile.component';

const settingsChildRoutes: Routes = [
  {
    path: '',
    redirectTo: 'user-profile',
    pathMatch: 'full'
  },
  { path: 'user-profile', component: UserProfileComponent },
  { path: 'notification-settings', component: NotificationSettingsComponent }
];

const userChildRoutes: Routes = [
  {
    path: '',
    redirectTo: 'dashboards',
    pathMatch: 'full'
  },
  {
  path: 'dashboards',
  component: DashboardComponent
  },
  { path: 'settings', component: SettingsComponent, children: settingsChildRoutes }
];

const routes: Routes = [{
  path: 'user',
  component: UserComponent,
  children: userChildRoutes
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class UserRoutingModule { }
