import { NgModule, Optional, SkipSelf } from '@angular/core';
import { throwIfAlreadyLoaded } from './guards/module-import.guard';
import { CommonModule } from '@angular/common';
import { DefaultService } from './services/default.service';
import { ToastnotificationService } from './services/toastnotification.service';
import { OrganizationService } from './services/organization.service';

@NgModule({
  imports: [
    CommonModule
  ],
  providers: [
    DefaultService,
    ToastnotificationService,
    OrganizationService
  ],
  declarations: []
})
export class CoreModule {
  constructor(@Optional() @SkipSelf() parentModule: CoreModule) {
    throwIfAlreadyLoaded(parentModule, 'CoreModule');
  }
}
