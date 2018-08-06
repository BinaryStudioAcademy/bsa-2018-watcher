import {NgModule} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
import {LandingComponent} from './landing/landing.component';
import {AuthorizationComponent} from './authorization/authorization.component';
import {NotificationComponent} from './notifications/notification/notification.component';

const routes: Routes = [
  {
    path: '',
    component: LandingComponent
  },
  {
    path: 'authorization',
    component: AuthorizationComponent
  },
  {
    path: 'notification',
    component: NotificationComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
