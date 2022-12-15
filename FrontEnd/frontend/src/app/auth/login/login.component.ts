import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import Swal from 'sweetalert2';
import { UsersService } from '../services/users.service';
import { Login } from '../models/login.model';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
})

export class LoginComponent {

  miLogin: FormGroup = this.fb.group({
    nombreUsuario: ['', [Validators.required]],
    pass: ['', [Validators.required, Validators.minLength(6)]],
  });

  get nombreUsuario() {
    return this.miLogin.get('nombreUsuario');
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
      let nombreUsuario: string = this.miLogin.get('nombreUsuario')?.value;
      let contraseña : string = this.miLogin.get('pass')?.value;
      let login: Login = new Login(nombreUsuario, contraseña);

      this.usersService.iniciarSesion(login).subscribe((resp) => {
        if(resp === null) {
          Swal.fire({
            icon: 'error',
            title: 'Oops...',
            text: 'Credenciales incorrectas, contacte al administrador',
            timer: 2000
          });
        } else {
          this.router.navigate(['./main/home']);
        }
      });
    } 
    
  }
}
