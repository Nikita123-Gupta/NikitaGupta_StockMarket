import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomePageComponent } from './home-page/home-page.component';
import { AdminLandPageComponent } from './Admin/admin-land-page/admin-land-page.component';
import { UserLandingPageComponent } from './User/user-landing-page/user-landing-page.component';
import { AdminLoginComponent } from './Admin/admin-login/admin-login.component';
import { UserLoginComponent } from './User/user-login/user-login.component';
import { SignUpComponent } from './User/sign-up/sign-up.component';

@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    AdminLandPageComponent,
    UserLandingPageComponent,
    AdminLoginComponent,
    UserLoginComponent,
    SignUpComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
