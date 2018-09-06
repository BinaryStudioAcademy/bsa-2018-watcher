import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SettingsComponent } from './settings.component';
import { NotificationSettingsComponent } from './notification-settings/notification-settings.component';
import { OrganizationProfileComponent } from './organization-profile/organization-profile.component';

import { TabViewModule, InputTextModule, ButtonModule, ToggleButtonModule,
   InputTextareaModule, InputMaskModule, ProgressSpinnerModule} from 'primeng/primeng';
import { InputSwitchModule, DropdownModule } from 'primeng/primeng';
import { ReactiveFormsModule } from '@angular/forms';
import { FormsModule } from '@angular/forms';
import { UserProfileComponent } from './user-profile/user-profile.component';
import { SettingsRoutingModule } from './settings-routing.module';
import { UserPictureComponent } from './user-picture/user-picture.component';
import { ImageCropperModule } from 'ngx-img-cropper';
import { DialogModule } from 'primeng/dialog';
import { FileUploadModule } from 'primeng/fileupload';
import { TableModule } from 'primeng/table';
import { CheckboxModule } from 'primeng/checkbox';
import { DataViewModule } from 'primeng/dataview';
import { InvitesListComponent } from './organization-profile/invites-list.component';
import { CalendarModule } from 'primeng/calendar';
import { OrganizationMembersComponent } from './organization-members/organization-members.component';

@NgModule({
  imports: [
    CommonModule,
    TabViewModule,
    FormsModule,
    InputTextModule,
    InputTextareaModule,
    ButtonModule,
    InputSwitchModule,
    DropdownModule,
    ReactiveFormsModule,
    SettingsRoutingModule,
    ToggleButtonModule,
    ImageCropperModule,
    DialogModule,
    FileUploadModule,
    InputMaskModule,
    ProgressSpinnerModule,
    TableModule,
    CheckboxModule,
    DataViewModule,
    CalendarModule
  ],
  declarations: [
    SettingsComponent,
    NotificationSettingsComponent,
    UserProfileComponent,
    OrganizationProfileComponent,
    UserPictureComponent,
    InvitesListComponent,
    OrganizationMembersComponent
  ]
})
export class SettingsModule { }
