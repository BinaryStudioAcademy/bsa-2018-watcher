import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AdminPageComponent } from './admin-page/admin-page.component';
import { FeedbackListComponent } from './feedback-list/feedback-list.component';

const routes: Routes = [{
  path:  '', // 'admin',
  component: AdminPageComponent,
  children: [{
    path: '',
    redirectTo: 'feedback-list'
  }, {
    path: 'feedback-list',
    component: FeedbackListComponent
  }]
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
