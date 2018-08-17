import {NgModule} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
import {FeedbackComponent} from '../feedback/feedback.component';
import { InviteComponent } from '../invite/invite.component';

const userRoutes: Routes = [
  {
    path: '',
    redirectTo: 'instances',
    pathMatch: 'full'
  },
  { path: 'instances', loadChildren: '../dashboards/dashboards.module#DashboardsModule' },
  {path: 'feedback', component: FeedbackComponent},
  {path: 'settings', loadChildren: '../settings/settings.module#SettingsModule'},
  { path: 'invite/:invite', component: InviteComponent }
  ];

@NgModule({
  imports: [RouterModule.forChild(userRoutes)],
  exports: [RouterModule]
})
export class UserRoutingModule {
}
