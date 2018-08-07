import { NgModule, ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { UserProfileComponent } from './user-profile/user-profile.component';
import { NotificationSettingsComponent } from './notification-settings/notification-settings.component';


const routes: Routes = [
    {
      path: '',
      redirectTo: 'user-profile',
      pathMatch: 'full'
    },
    { path: 'user-profile', component: UserProfileComponent },
    { path: 'notification-settings', component: NotificationSettingsComponent }
  ];

  @NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
  })
  export class SettingsRoutingModule { }
