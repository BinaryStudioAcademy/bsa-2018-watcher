import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ShellRoutingModule } from './shell-routing.module';
import { ShellComponent } from './shell.component';

import { HeaderComponent } from './header/header.component';
import {
  ToolbarModule,
  TieredMenuModule,
  ButtonModule,
  MessagesModule,
  MessageModule,
  GrowlModule,
  PanelMenuModule
} from 'primeng/primeng';
import { LeftSideMenuComponent } from './left-side-menu/left-side-menu.component';
import { ChatModule } from '../chat/chat.module';
import { query } from '@angular/core/src/render3/query';


@NgModule({
  imports: [
    CommonModule,
    ShellRoutingModule,

    ToolbarModule,
    TieredMenuModule,
    ButtonModule,
    GrowlModule,
    MessagesModule,
    MessageModule,
    PanelMenuModule,
    ChatModule
  ],
  declarations: [ ShellComponent, HeaderComponent, LeftSideMenuComponent ]
})
export class ShellModule { }
