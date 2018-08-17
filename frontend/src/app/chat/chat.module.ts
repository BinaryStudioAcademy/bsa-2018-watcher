import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PanelMenuModule } from 'primeng/panelmenu';
import { AccordionModule } from 'primeng/accordion';
import { InputTextModule, ButtonModule } from 'primeng/primeng';
import { CardModule } from 'primeng/card';
import { ScrollPanelModule } from 'primeng/scrollpanel';
import { ReactiveFormsModule } from '@angular/forms';
import { FormsModule } from '@angular/forms';
import { ChatComponent } from './chat.component';

@NgModule({
  imports: [
    CommonModule,
    PanelMenuModule,
    AccordionModule,
    InputTextModule,
    CardModule,
    ReactiveFormsModule,
    FormsModule,
    ButtonModule,
    ScrollPanelModule
  ],
  declarations: [ ChatComponent ],
  exports: [ ChatComponent ]
})
export class ChatModule { }
