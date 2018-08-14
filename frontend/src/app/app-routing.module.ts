import {NgModule} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
import {LandingComponent} from './landing/landing.component';
import { HomeGuard } from './core/guards/home.guard';
import { NotexistGuard } from './core/guards/notexist.guard';
import { ShellComponent } from './shell/shell.component';


const routes: Routes = [
  { path: '',
    component: LandingComponent,
    canActivate: [HomeGuard]
  }, {
    path: 'user/',
    component: ShellComponent,
    canActivate: [NotexistGuard]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
