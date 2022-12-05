import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { UsersService } from '../services/users.service';
import { Router } from '@angular/router';


@Component({
  selector: 'app-create-account',
  templateUrl: './create-account.component.html'
})
export class CreateAccountComponent implements OnInit {

  registro: FormGroup = this.fb.group({
    nombre: ['', []],
    apellido: ['', []],
    nombreUsuario: ['', []],
    email: ['', [Validators.required, Validators.email]],
    CUIL: ['', []],
    localidad: ['', []],
    fechaNacimiento: ['', []],
    pass: ['', [Validators.required, Validators.minLength(6)]],
    pass2: ['']
  })

  constructor(    private fb: FormBuilder,
                  private router: Router,
                  private usersService: UsersService ) { }

  ngOnInit(): void {
  }

  crearCuenta(){
    console.log(this.registro.value)
  }
}
