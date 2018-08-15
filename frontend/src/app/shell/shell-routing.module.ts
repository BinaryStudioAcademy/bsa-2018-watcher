import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ShellComponent } from './shell.component';
import { AuthGuard } from '../core/guards/auth.guard';
import { TestSignalRComponent } from './test-signal-r/test-signal-r.component';


const routes: Routes = [{
  path: 'user',
  component: ShellComponent,
  canActivate: [AuthGuard],
  children: [{
    path: '',
    loadChildren: '../user/user.module#UserModule'
  }, {
    path: 'testSignalR',
    component: TestSignalRComponent
  }]
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ShellRoutingModule { }
