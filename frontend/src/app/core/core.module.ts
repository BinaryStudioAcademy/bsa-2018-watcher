import { NgModule, Optional, SkipSelf } from '@angular/core';
import { throwIfAlreadyLoaded } from './guards/module-import.guard';
import { CommonModule } from '@angular/common';
import { AuthService } from './services/auth.service';
import { TokenService } from './services/token.service';
import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { TokensInterceptor } from './interceptors/tokens-interceptor';
import { ToastrService } from './services/toastr.service';
import { MessageService, ConfirmationService } from 'primeng/api';
import { ApiService } from './services/api.service';
import { NotificationsHubService } from './services/notifications-hub.service';
import { AuthGuard } from './guards/auth.guard';
import { FeedbackService } from './services/feedback.service';
import { ResponseService } from './services/response.service';
import { RoleService } from './services/role.service';

@NgModule({
  imports: [
    CommonModule
  ],
  providers: [
    AuthService,
    TokenService,
    ApiService,
    NotificationsHubService,
    ToastrService,
    FeedbackService,
    ResponseService,
    RoleService,
    ConfirmationService,
    MessageService,
    { provide: HTTP_INTERCEPTORS, useClass: TokensInterceptor, multi: true },
    AuthGuard
  ],

  declarations: []
})
export class CoreModule {
  constructor(@Optional() @SkipSelf() parentModule: CoreModule) {
    throwIfAlreadyLoaded(parentModule, 'CoreModule');
  }
}
