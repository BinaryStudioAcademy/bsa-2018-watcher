import { NgModule, Optional, SkipSelf } from '@angular/core';
import { throwIfAlreadyLoaded } from './guards/module-import.guard';
import { CommonModule } from '@angular/common';

import { DefaultService } from './services/default.service';
import { ToastrService } from './services/toastr.service';
import { MessageService, ConfirmationService } from 'primeng/api';

@NgModule({
  imports: [
    CommonModule
  ],
  providers: [ DefaultService, ToastrService, ConfirmationService, MessageService ],
  declarations: []
})
export class CoreModule {
  constructor(@Optional() @SkipSelf() parentModule: CoreModule) {
    throwIfAlreadyLoaded(parentModule, 'CoreModule');
  }
}
