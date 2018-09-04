import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ShellRoutingModule } from './shell-routing.module';
import { ShellComponent } from './shell.component';

import { HeaderComponent } from './header/header.component';
import {
  ToolbarModule,
  TieredMenuModule,
  ButtonModule,
  DialogModule,
  MessagesModule,
  MessageModule,
  GrowlModule,
  PanelMenuModule,
  InputTextModule,
  InputTextareaModule,
  InputMaskModule,
  ProgressSpinnerModule,
  AccordionModule,
  OverlayPanelModule
} from 'primeng/primeng';
import { LeftSideMenuComponent } from './left-side-menu/left-side-menu.component';
import { ChatModule } from '../chat/chat.module';
import { query } from '@angular/core/src/render3/query';
import { AddNewOrganizationComponent } from './add-new-organization/add-new-organization.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ClickOutsideDirective } from '../shared/directives/click-outside.directive';
import { NotificationBlockComponent } from '../notification/notification-block/notification-block.component';
import { SpinnerPopupComponent } from './spinner-popup/spinner-popup.component';
import { InstanceListComponent } from './instance-list/instance-list.component';
import { DownloadAppComponent } from './download-app/download-app.component';
import { InstanceService } from '../core/services/instance.service';
import { ToastrService } from '../core/services/toastr.service';
import { AuthService } from '../core/services/auth.service';

@NgModule({
  imports: [
    CommonModule,
    ShellRoutingModule,

    ToolbarModule,
    TieredMenuModule,
    FormsModule,
    ButtonModule,
    InputTextModule,
    InputMaskModule,
    InputTextareaModule,
    DialogModule,
    GrowlModule,
    MessagesModule,
    MessageModule,
    PanelMenuModule,
    ChatModule,
    DialogModule,
    ProgressSpinnerModule,
    AccordionModule,
    OverlayPanelModule,
    ReactiveFormsModule
  ],
  declarations: [
    ShellComponent,
    HeaderComponent,
    LeftSideMenuComponent,
    InstanceListComponent,
    DownloadAppComponent,
    AddNewOrganizationComponent,
    ClickOutsideDirective,
    NotificationBlockComponent,
    SpinnerPopupComponent
  ]
})
export class ShellModule { }
