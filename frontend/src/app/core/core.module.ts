import { NgModule, Optional, SkipSelf } from '@angular/core';
import { throwIfAlreadyLoaded } from './guards/module-import.guard';
import { CommonModule } from '@angular/common';
import {AuthService} from './services/auth.service';
import {TokenService} from './services/token.service';
import {HTTP_INTERCEPTORS} from '@angular/common/http';
import {TokensInterceptor} from './interceptors/tokens-interceptor';
import { ToastrService } from './services/toastr.service';
import { MessageService, ConfirmationService } from 'primeng/api';
import {ApiService} from './services/api.service';
import {NotificationsService} from './services/notifications.service';

@NgModule({
  imports: [
    CommonModule
  ],
  providers: [
    AuthService,
    TokenService,
    ApiService,
    NotificationsService,
    ToastrService,
    ConfirmationService,
    MessageService,
    { provide: HTTP_INTERCEPTORS, useClass: TokensInterceptor, multi: true }
  ],

  declarations: []
})
export class CoreModule {
  constructor(@Optional() @SkipSelf() parentModule: CoreModule) {
    throwIfAlreadyLoaded(parentModule, 'CoreModule');
  }
}
