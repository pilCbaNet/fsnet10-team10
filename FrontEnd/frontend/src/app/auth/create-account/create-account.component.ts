import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { UsersService } from '../services/users.service';
import { Router } from '@angular/router';
import { CrearCuenta } from '../models/login.model';


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
    fechaNacimiento: ['', [Validators.required]],
    pass: ['', [Validators.required, Validators.minLength(6)]],
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

  get fechaNacimiento() {
    return this.registro.get('fechaNacimiento');
  }

  get pass() {
    return this.registro.get('pass');
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
    console.log(this.registro.value)
    console.log(this.registro.valid)

    if(this.registro.valid) {
      let nombre: string = this.registro.get('nombre')?.value;
      let apellido: string = this.registro.get('apellido')?.value;
      let nombreUsuario: string = this.registro.get('nombreUsuario')?.value;
      let email: string = this.registro.get('email')?.value;
      let CUIL: string = this.registro.get('CUIL')?.value;
      let localidad: string = this.registro.get('localidad')?.value;
      let fechaNacimiento: string = this.registro.get('fechaNacimiento')?.value;
      let pass1: string = this.registro.get('pass')?.value;
      let pass2: string = this.registro.get('pass2')?.value;

      let crearCuenta: CrearCuenta = new CrearCuenta(nombre, apellido, nombreUsuario, email, CUIL, localidad, fechaNacimiento, pass1, pass2);

      if(pass1 === pass2) {
        console.log('perfecto lince');
      } else {
        let mensajeError = true;
        console.log(mensajeError);
      }
    }

    
  }
}
