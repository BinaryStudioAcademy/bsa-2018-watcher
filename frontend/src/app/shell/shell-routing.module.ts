import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ShellComponent } from './shell.component';
import { UserComponent } from '../user/user.component';

const routes: Routes = [{
  path: 'user',
  component: ShellComponent,
  loadChildren: '../user/user.module#UserModule'
}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class ShellRoutingModule { }
