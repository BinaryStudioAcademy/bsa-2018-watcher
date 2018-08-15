import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DashboardComponent } from '../dashboards/dashboard/dashboard.component';
import { FeedbackComponent } from '../feedback/feedback.component';

const userRoutes: Routes = [{
  path: '',
  children: [{
    path: '',
    children: [
      { path: '', redirectTo: 'dashboards', pathMatch: 'full' },
      { path: 'dashboards', component: DashboardComponent },
      { path: 'feedback', component: FeedbackComponent },
      { path: 'settings', loadChildren: '../settings/settings.module#SettingsModule' }
    ]
  }]
}];

@NgModule({
  imports: [RouterModule.forChild(userRoutes)],
  exports: [RouterModule]
})
export class UserRoutingModule { }
