import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AdminPageComponent } from './admin-page/admin-page.component';
import { OrganizationListComponent } from './organization-list/organization-list.component';
import { UserListComponent } from './user-list/user-list.component';
import { FeedbackListComponent } from './feedback-list/feedback-list.component';

const routes: Routes = [{
  path: '',
  children: [{
    path: '',
    children: [
      { path: '', component: AdminPageComponent },
      { path: 'organization-list', component: OrganizationListComponent },
      { path: 'user-list', component: UserListComponent },
      { path: 'feedback-list', component: FeedbackListComponent }
    ]
  }]
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
