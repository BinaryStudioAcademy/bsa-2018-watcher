import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { EditInstanceComponent } from './edit-instance/edit-instance.component';


const dashboardRoutes: Routes = [{
  path: 'dashboards',
  component: DashboardComponent},
  {
    path: 'instance/:id/edit',
    component: EditInstanceComponent
}, {
    path: 'instance/create',
    component: EditInstanceComponent
},
{
  path: 'instance/:id/dashboards',
  component: DashboardComponent
}];

@NgModule({
  imports: [RouterModule.forChild(dashboardRoutes)],
  exports: [RouterModule]
})
export class DashboardRoutingModule {}
