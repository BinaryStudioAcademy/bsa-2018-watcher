import {NgModule} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
import {FeedbackComponent} from '../feedback/feedback.component';

const userRoutes: Routes = [
  {
    path: '',
    redirectTo: 'instances',
    pathMatch: 'full' // TODO: Write resolver that redirect or just fetch Organization first instance to show dashboards
  },
  { path: 'instances', loadChildren: '../dashboards/dashboards.module#DashboardsModule' },
  {path: 'feedback', component: FeedbackComponent},
  {path: 'settings', loadChildren: '../settings/settings.module#SettingsModule'}
  ];

@NgModule({
  imports: [RouterModule.forChild(userRoutes)],
  exports: [RouterModule]
})
export class UserRoutingModule {
}
