import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';

import { AccordionModule, TabViewModule, ProgressSpinnerModule, ButtonModule } from 'primeng/primeng';
import { PanelModule } from 'primeng/primeng';
import { RadioButtonModule } from 'primeng/primeng';
import { DialogModule } from 'primeng/primeng';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule } from '@angular/forms';

import { LandingComponent } from './landing/landing.component';
import { InviteComponent } from './invite/invite.component';
import { CoreModule } from './core/core.module';
import { AuthorizationComponent } from './authorization/authorization.component';
import { AdminModule } from './admin/admin.module';
import {GMapModule} from 'primeng/gmap';

import { AngularFireModule } from 'angularfire2';
import { environment } from '../environments/environment';
import { AngularFireDatabaseModule } from 'angularfire2/database';
import { AngularFireAuthModule } from 'angularfire2/auth';
import { AuthService } from './core/services/auth.service';
import { ToastModule } from 'primeng/toast';
import { ConfirmDialogModule } from 'primeng/components/confirmdialog/confirmdialog';
import { ShellModule } from './shell/shell.module';
import { CustomConfirmDialogComponent } from './notification/custom-confirm-dialog/custom-confirm-dialog.component';
import { SystemNotificationComponent } from './notification/system-notification/system-notification.component';


@NgModule({
  declarations: [
    AppComponent,
    LandingComponent,
    InviteComponent,
    AuthorizationComponent,
    CustomConfirmDialogComponent,
    SystemNotificationComponent,
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule,
    AccordionModule,
    PanelModule,
    ButtonModule,
    RadioButtonModule,
    DialogModule,
    TabViewModule,
    ToastModule,
    ConfirmDialogModule,
    ProgressSpinnerModule,
    GMapModule,

    AngularFireModule.initializeApp(environment.firebase, 'watcherapp'),
    AngularFireDatabaseModule,
    AngularFireAuthModule,

    CoreModule,
    AppRoutingModule,
    ShellModule
  ],
  bootstrap: [AppComponent]
})
export class AppModule {}
