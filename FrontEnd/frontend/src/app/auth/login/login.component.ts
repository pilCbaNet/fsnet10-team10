import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { UsersService } from '../services/users.service';
import { Login } from '../models/login.model';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
})

export class LoginComponent {

  miLogin: FormGroup = this.fb.group({
    email: ['', [Validators.required, Validators.email]],
    pass: ['', [Validators.required, Validators.minLength(6)]],
  });

  get email() {
    return this.miLogin.get('email');
  }

  get pass() {
    return this.miLogin.get('pass');
  }
  constructor(
    private fb: FormBuilder,
    private router: Router,
    private usersService: UsersService
  ) {}

  login() {
    if(this.miLogin.valid) {
      let email: string = this.miLogin.get('email')?.value;
      let pass : string = this.miLogin.get('pass')?.value;
      let login: Login = new Login(email, pass);

      this.usersService.iniciarSesion(login).subscribe((resp) => {
        this.router.navigate(['./main/home']);
        
      });
    } 
    
  }
}
