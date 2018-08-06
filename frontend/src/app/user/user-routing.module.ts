import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DashboardComponent } from '../dashboards/dashboard/dashboard.component';
import { UserComponent } from './user.component';
import { ProfileComponent } from './profile/profile.component';

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
  {
    path: 'profile',
    component: ProfileComponent
  }
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
