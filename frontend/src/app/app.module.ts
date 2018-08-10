import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';

import { AccordionModule, TabViewModule } from 'primeng/primeng';
import { PanelModule } from 'primeng/primeng';
import { ButtonModule } from 'primeng/components/button/button';
import { RadioButtonModule } from 'primeng/primeng';
import { DialogModule } from 'primeng/primeng';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule } from '@angular/forms';

import { LandingComponent } from './landing/landing.component';
import { CoreModule } from './core/core.module';
import { AuthorizationComponent } from './authorization/authorization.component';
import { AdminModule } from './admin/admin.module';
import { UserModule } from './user/user.module';
import { NotificationsModule } from './notifications/notifications.module';

import { AngularFireModule } from 'angularfire2';
import { environment } from '../environments/environment';
import { AngularFireDatabaseModule } from 'angularfire2/database';
import { AngularFireAuthModule } from 'angularfire2/auth';
import { AuthService } from './core/services/auth.service';
import { ToastModule } from 'primeng/toast';
import { ConfirmDialogModule } from 'primeng/components/confirmdialog/confirmdialog';

@NgModule({
  declarations: [
    AppComponent,
    LandingComponent,
    AuthorizationComponent
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

    AngularFireModule.initializeApp(environment.firebase, 'watcherapp'),
    AngularFireDatabaseModule,
    AngularFireAuthModule,

    CoreModule,
    NotificationsModule,
    UserModule,
    AdminModule,

    AppRoutingModule
  ],
  providers: [AuthService],
  bootstrap: [AppComponent]
})
export class AppModule {}
