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
  AutoCompleteModule,
} from 'primeng/primeng';
import { ToastModule } from 'primeng/toast';

import { ChatComponent } from './chat.component';
import { ConversationPanelComponent } from './conversation-panel/conversation-panel.component';
import { ConversationSettingsPopupComponent } from './conversation-settings-popup/conversation-settings-popup.component';
import { ChatCreatePopupComponent } from './chat-create-popup/chat-create-popup.component';

@NgModule({
  imports: [
    CommonModule,
    AccordionModule,
    InputTextModule,
    CardModule,
    ReactiveFormsModule,
    FormsModule,
    ButtonModule,
    ListboxModule,
    DialogModule,
    AutoCompleteModule,
    ToastModule
  ],
  declarations: [
    ChatComponent,
    ConversationPanelComponent,
    ConversationSettingsPopupComponent,
    ChatCreatePopupComponent
  ],
  exports: [ChatComponent]
})
export class ChatModule { }
