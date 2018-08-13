import {NgModule} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
import {LandingComponent} from './landing/landing.component';
import { ShellComponent } from './shell/shell.component';
import { HomeGuard } from './core/guards/home.guard';


const routes: Routes = [
{ path: '',
  component: LandingComponent,
  canActivate: [HomeGuard] },
{ path: 'user/dashboards', component: ShellComponent},
{ path: '**',  redirectTo: ''}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
