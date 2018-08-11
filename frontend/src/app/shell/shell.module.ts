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
  GrowlModule
} from 'primeng/primeng';

@NgModule({
  imports: [
    CommonModule,
    ShellRoutingModule,

    ToolbarModule,
    TieredMenuModule,
    ButtonModule,
    GrowlModule,
    MessagesModule,
    MessageModule
  ],
  declarations: [ ShellComponent, HeaderComponent ]
})
export class ShellModule { }
