import {NgModule} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
import {ShellComponent} from './shell.component';
import {AuthGuard} from '../core/guards/auth.guard';
import {AdminGuard} from '../core/guards/admin.guard';

const routes: Routes = [{
  path: 'user',
  component: ShellComponent,
  canActivate: [AuthGuard],
  children: [{
    path: '',
    loadChildren: '../user/user.module#UserModule'
  }]
}, {
  path: 'admin',
  component: ShellComponent,
  canActivate: [AdminGuard],
  children: [{
    path: '',
    loadChildren: '../admin/admin.module#AdminModule'
  }]
}, {

  path: '**',
  redirectTo: 'user'
}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ShellRoutingModule {
}
