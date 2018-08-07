import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DashboardComponent } from '../dashboards/dashboard/dashboard.component';
import { UserComponent } from './user.component';
import { SettingsComponent } from '../settings/settings.component';


/* export const settings = '../settings/settings.module#SettingsModule'; */

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
  { path: 'settings', component: SettingsComponent }
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
