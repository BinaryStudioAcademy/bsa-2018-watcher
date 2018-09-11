import {NgModule} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
import {LandingComponent} from './landing/landing.component';
import { HomeGuard } from './core/guards/home.guard';
import { NotexistGuard } from './core/guards/notexist.guard';
import { ShellComponent } from './shell/shell.component';
import { InviteComponent } from './invite/invite.component';
import { AboutComponent } from './about/about.component';

const routes: Routes = [{
  path: '',
  component: LandingComponent,
  canActivate: [HomeGuard],
}, {
  path: 'user/',
  component: ShellComponent,
  canActivate: [NotexistGuard]
}, {
  path: 'invite/:invite',
  component: InviteComponent
},
{
  path: 'about',
  component: AboutComponent
}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
