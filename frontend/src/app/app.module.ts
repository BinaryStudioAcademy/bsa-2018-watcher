import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { LandingComponent } from './landing/landing.component';
import { AppRoutingModule } from './app-routing.module';
import { CoreModule } from './core/core.module';
import { HttpClientModule } from '@angular/common/http';
import { ButtonModule } from '../../node_modules/primeng/primeng';
import { RouterModule }   from '@angular/router';

@NgModule({
  declarations: [
    AppComponent,
    LandingComponent
  ],
  imports: [
    RouterModule.forRoot([]),
    BrowserModule,
    HttpClientModule,
    CoreModule,
    ButtonModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
