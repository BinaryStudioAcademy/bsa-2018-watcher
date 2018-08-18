import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PanelMenuModule } from 'primeng/panelmenu';
import { AccordionModule } from 'primeng/accordion';
import { InputTextModule, ButtonModule } from 'primeng/primeng';
import { CardModule } from 'primeng/card';
import { ScrollPanelModule } from 'primeng/scrollpanel';
import { ListboxModule } from 'primeng/listbox';
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
    ScrollPanelModule,
    ListboxModule
  ],
  declarations: [ ChatComponent ],
  exports: [ ChatComponent ]
})
export class ChatModule { }
