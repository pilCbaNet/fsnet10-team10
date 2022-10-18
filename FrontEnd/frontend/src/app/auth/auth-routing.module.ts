import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ChangePasswordComponent } from './change-password/change-password.component';
import { CreateAccountComponent } from './create-account/create-account.component';
import { LoginComponent } from './login/login.component';

const routes: Routes = [
    {
      path: '',
      component: MainComponent,
      children: [
        { path: 'login', component:  LoginComponent},
        { path: 'change/:id', component:  ChangePasswordComponent},
        { path: 'create', component:  CreateAccountComponent},
        { path: '**', redirectTo: 'login' },
      ]
    },
  ];

  @NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
  })
  export class AuthRoutingModule { }