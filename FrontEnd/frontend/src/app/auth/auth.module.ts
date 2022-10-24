import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { ChangePasswordComponent } from './change-password/change-password.component';
import { CreateAccountComponent } from './create-account/create-account.component';
import { LoginComponent } from './login/login.component';
import { MainComponent } from './main/main.component';
import { AuthRoutingModule } from './auth-routing.module';
import { ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    ChangePasswordComponent,
    CreateAccountComponent,
    LoginComponent,
    MainComponent
  ],
  imports: [
    CommonModule,
    RouterModule,
    AuthRoutingModule,
    ReactiveFormsModule
  ]
})
export class AuthModule { }
