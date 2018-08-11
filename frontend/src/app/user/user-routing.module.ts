import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DashboardComponent } from '../dashboards/dashboard/dashboard.component';
import { UserComponent } from './user.component';

const userRoutes: Routes = [{
  path: '',
  component: UserComponent,
  children: [{
      path: '',
      redirectTo: 'dashboards',
      pathMatch: 'full'
    }, {
      path: 'dashboards',
      component: DashboardComponent
    }, {
      path: 'settings',
      loadChildren: '../settings/settings.module#SettingsModule'
  }]
}];

@NgModule({
  imports: [RouterModule.forChild(userRoutes)],
  exports: [RouterModule]
})
export class UserRoutingModule { }
