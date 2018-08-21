import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';
import { FormsModule } from '@angular/forms';
import {
  InputTextModule,
  ButtonModule,
  DialogModule,
  CardModule,
  ListboxModule,
  AccordionModule,
  AutoCompleteModule
} from 'primeng/primeng';
import { ScrollPanelModule } from 'primeng/scrollpanel';

import { ChatComponent } from './chat.component';

@NgModule({
  imports: [
    CommonModule,
    AccordionModule,
    InputTextModule,
    CardModule,
    ReactiveFormsModule,
    FormsModule,
    ButtonModule,
    ScrollPanelModule,
    ListboxModule,
    DialogModule,
    AutoCompleteModule
  ],
  declarations: [ChatComponent],
  exports: [ChatComponent]
})
export class ChatModule { }
