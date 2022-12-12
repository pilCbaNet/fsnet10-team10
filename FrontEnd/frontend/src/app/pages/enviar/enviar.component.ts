import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Envio } from '../models/enviarDinero.mode';

@Component({
  selector: 'app-enviar',
  templateUrl: './enviar.component.html'
})

export class EnviarComponent implements OnInit {

  enviarDinero: FormGroup = this.fb.group({
    cbuEnviar: ['', [Validators.required]],
    montoEnviar: ['', [Validators.required]],
  });


  constructor(private fb: FormBuilder,
              private router: Router,) { }

  ngOnInit(): void {
  }

  enviar() {
    if(this.enviarDinero.valid) {
      // let cbuEnviar: number = this.cbuEnviar.get('cbuEnviar')?.value;
      // let montoEnviar : number = this.montoEnviar.get('montoEnviar')?.value;
      // let dineroAEnviar: Envio = new Envio(cbuEnviar, montoEnviar);


    }
  }
}
