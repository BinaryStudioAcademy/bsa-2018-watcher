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
    PanelMenuModule
  ],
  declarations: [ ShellComponent, HeaderComponent, LeftSideMenuComponent ]
})
export class ShellModule { }
