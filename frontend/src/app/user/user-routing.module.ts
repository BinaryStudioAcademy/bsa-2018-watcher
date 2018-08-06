import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DashboardComponent } from '../dashboards/dashboard/dashboard.component';
import { UserComponent } from './user.component';

const userChildRoutes: Routes = [
  {
    path:"",
    redirectTo:"dashboards",
    pathMatch:"full"
  },
  {
  path:"dashboards",
  component:DashboardComponent
  }
];

const routes: Routes = [{
  path:"user",
  component:UserComponent,
  children:userChildRoutes
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class UserRoutingModule { }
