import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DashboardsPageComponent } from './dashboards-page/dashboards-page.component';

const routes: Routes = [{
  path:"dashboards",
  component:DashboardsPageComponent
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DashboardsRoutingModule { }
