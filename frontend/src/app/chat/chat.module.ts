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
  TooltipModule,
  InputSwitchModule
} from 'primeng/primeng';

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
    TooltipModule,
    InputSwitchModule
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
