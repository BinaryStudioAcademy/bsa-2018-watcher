import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DashboardComponent } from '../dashboards/dashboard/dashboard.component';
import { FeedbackComponent } from '../feedback/feedback.component';
import { InviteComponent } from '../invite/invite.component';

const userRoutes: Routes = [{
  path: '',
  children: [{
    path: '',
    children: [
      { path: '', redirectTo: 'dashboards', pathMatch: 'full' },
      { path: 'dashboards', component: DashboardComponent },
      { path: 'feedback', component: FeedbackComponent },
      { path: 'settings', loadChildren: '../settings/settings.module#SettingsModule' },
      { path: 'invite/:invite', component: InviteComponent }
    ]
  }]
}];

@NgModule({
  imports: [RouterModule.forChild(userRoutes)],
  exports: [RouterModule]
})
export class UserRoutingModule { }
