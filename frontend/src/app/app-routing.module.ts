import {NgModule} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
import {LandingComponent} from './landing/landing.component';
import { ShellComponent } from './shell/shell.component';
import { AuthGuard } from './core/guards/auth.guard';

const routes: Routes = [{
  path: '',
  component: LandingComponent,
  }, {
  path: '**',
  redirectTo: 'user/dashboards',
  canActivate: [AuthGuard]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
