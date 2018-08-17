import {NgModule} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
import {DashboardComponent} from './dashboard/dashboard.component';
import {EditInstanceComponent} from './edit-instance/edit-instance.component';

const dashboardRoutes: Routes = [
  {
    path: '',
    component: DashboardComponent,
    pathMatch: 'full'
  },
  {
    path: ':insId/edit',
    component: EditInstanceComponent
  },
  {
    path: 'create',
    component: EditInstanceComponent
  },
  {
    path: ':insId/dashboards',
    component: DashboardComponent
  }];

@NgModule({
  imports: [RouterModule.forChild(dashboardRoutes)],
  exports: [RouterModule]
})
export class DashboardRoutingModule {
}
