import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { UsersService } from '../services/users.service';
import { Router } from '@angular/router';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-create-account',
  templateUrl: './create-account.component.html'
})

export class CreateAccountComponent implements OnInit {
  

  registro: FormGroup = this.fb.group({
    nombre: ['', [Validators.required]],
    apellido: ['', [Validators.required]],
    nombreUsuario: ['', [Validators.required]],
    email: ['', [Validators.required, Validators.email]],
    CUIL: ['', [Validators.required]],
    localidad: ['', [Validators.required]],
    password: ['', [Validators.required, Validators.minLength(6)]],
    pass2: ['', [Validators.required, Validators.minLength(6)]]
  })

  get nombre() {
    return this.registro.get('nombre');
  }

  get apellido() {
    return this.registro.get('apellido');
  }

  get nombreUsuario() {
    return this.registro.get('nombreUsuario');
  }

  get email() {
    return this.registro.get('email');
  }

  get CUIL() {
    return this.registro.get('CUIL');
  }
  
  get localidad() {
    return this.registro.get('localidad');
  }

  get password() {
    return this.registro.get('password');
  }

  get pass2() {
    return this.registro.get('pass2');
  }


  constructor(    private fb: FormBuilder,
                  private router: Router,
                  private usersService: UsersService ) { }

  ngOnInit(): void {
  }
  
  crearCuenta(){

    if(this.registro.valid) {
      let nombre: string = this.registro.get('nombre')?.value;
      let apellido: string = this.registro.get('apellido')?.value;
      let nombreUsuario: string = this.registro.get('nombreUsuario')?.value;
      let email: string = this.registro.get('email')?.value;
      let CUIL: string = this.registro.get('CUIL')?.value;
      let idlocalidad: string = this.registro.get('localidad')?.value;
      let contraseña: string = this.registro.get('password')?.value;
      let pass2: string = this.registro.get('pass2')?.value;
      let idUsuario: number = 5;

      // nombre, apellido, nombreUsuario, email, CUIL, localidad, password, id
      if(contraseña === pass2) {
        let datos = {
          idUsuario, nombre, apellido, CUIL, nombreUsuario, email, contraseña, idlocalidad 
        }

        this.usersService.crearCuenta(datos)
          .subscribe(resp => {
            Swal.fire({
              position: 'center',
              icon: 'success',
              title: 'Cuenta creada exitosamente, podés iniciar sesión',
              showConfirmButton: false,
              timer: 3000
            });
            this.router.navigateByUrl('/iniciar-sesion/login');
            console.log('aca la respuesta del back', resp);
          });
      } else {
        let mensajeError = true;
        Swal.fire({
          icon: 'error',
          title: 'Oops...',
          text: 'Las contraseñas no coinciden',
          timer: 2000
        })
        console.log(mensajeError);
      }
    }
  }
}
