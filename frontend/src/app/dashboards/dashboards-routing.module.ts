import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { EditInstanceComponent } from './edit-instance/edit-instance.component';

const dashboardRoutes: Routes = [
  {
    path: '',
    component: DashboardComponent,
    pathMatch: 'full' // TODO: Write resolver that redirect or just fetch Organization first instance to show dashboards
  },
  {
    path: ':insId/edit',
    component: EditInstanceComponent,
    canActivate: ['ManagerGuard']
  },
  {
    path: 'create',
    component: EditInstanceComponent,
    canActivate: ['ManagerGuard']
  },
  {
    path: ':insId/:guidId/dashboards',
    component: DashboardComponent
  }];

@NgModule({
  imports: [RouterModule.forChild(dashboardRoutes)],
  exports: [RouterModule]
})
export class DashboardRoutingModule {
}
