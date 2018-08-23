import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SettingsComponent } from './settings.component';
import { NotificationSettingsComponent } from './notification-settings/notification-settings.component';
import { OrganizationProfileComponent } from './organization-profile/organization-profile.component';

import { TabViewModule, InputTextModule, ButtonModule, ToggleButtonModule, InputTextareaModule, InputMaskModule } from 'primeng/primeng';
import { InputSwitchModule, DropdownModule } from 'primeng/primeng';
import { ReactiveFormsModule } from '@angular/forms';
import { FormsModule } from '@angular/forms';
import { UserProfileComponent } from './user-profile/user-profile.component';
import { SettingsRoutingModule } from './settings-routing.module';
import { UserPictureComponent } from './user-picture/user-picture.component';
import { ImageCropperModule } from 'ngx-img-cropper';
import { DialogModule } from 'primeng/dialog';
import { FileUploadModule } from 'primeng/fileupload';


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
    InputMaskModule,
    FileUploadModule
  ],
  declarations: [
    SettingsComponent,
    NotificationSettingsComponent,
    UserProfileComponent,
    OrganizationProfileComponent,
    UserPictureComponent
  ]
})
export class SettingsModule { }
