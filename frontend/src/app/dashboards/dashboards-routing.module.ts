import {NgModule} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
import {DashboardComponent} from './dashboard/dashboard.component';
import {EditInstanceComponent} from './edit-instance/edit-instance.component';


const dashboardRoutes: Routes = [
  {
    path: 'dashboards',
    component: DashboardComponent
  },
  {
    path: 'edit-instance/:id',
    component: EditInstanceComponent
  },
  {
    path: 'edit-instance',
    component: EditInstanceComponent
  }];

@NgModule({
  imports: [RouterModule.forChild(dashboardRoutes)],
  exports: [RouterModule]
})
export class DashboardRoutingModule {
}
