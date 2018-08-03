import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LandingComponent } from './landing/landing.component';
import { AuthorizationComponent } from './authorization/authorization.component';

const routes: Routes = [{
path:"",
redirectTo:"landing",
pathMatch:"full"
},
{
  path: 'landing',
  component: LandingComponent
},
{
  path: 'authorization',
  component: AuthorizationComponent
}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
