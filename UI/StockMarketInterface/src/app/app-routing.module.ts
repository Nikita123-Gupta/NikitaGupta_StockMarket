import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomePageComponent } from './home-page/home-page.component';
import { AdminLandPageComponent } from './Admin/admin-land-page/admin-land-page.component';
import { UserLandingPageComponent } from './User/user-landing-page/user-landing-page.component';
import { AdminLoginComponent } from './Admin/admin-login/admin-login.component';
import { UserLoginComponent } from './User/user-login/user-login.component';
import { SignUpComponent } from './User/sign-up/sign-up.component';


const routes: Routes = [
  { path: 'home-page', component: HomePageComponent },
  { path: 'admin-login', component: AdminLoginComponent },
  { path: 'admin-land-page', component: AdminLandPageComponent },
  { path: 'user-land-page', component: UserLandingPageComponent },
  { path: 'user-login', component: UserLoginComponent },
  { path: 'sign-up', component: SignUpComponent },
  { path: '', redirectTo: 'home-page', pathMatch:"full"}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
