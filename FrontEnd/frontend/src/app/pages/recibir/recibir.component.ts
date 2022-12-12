import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Recepcion } from '../models/recibirDinero.model';

@Component({
  selector: 'app-recibir',
  templateUrl: './recibir.component.html',
  styleUrls: ['./recibir.component.css']
})

export class RecibirComponent implements OnInit {

  recibirDinero: FormGroup = this.fb.group({
    cbuRecibir: ['', [Validators.required]],
    montoRecibir: ['', [Validators.required]],
  });
  
  get cbuRecibir() {
    return this.recibirDinero.get('cbuRecibir');
  }

  get montoRecibir() {
    return this.recibirDinero.get('montoRecibir');
  }

  constructor(private fb: FormBuilder,
    private router: Router) { }

  ngOnInit(): void {
  }

  recibir() {
    if(this.recibirDinero.valid) {
      let cbuRecibir: number = this.recibirDinero.get('cbuRecibir')?.value;
      let montoRecibir : number = this.recibirDinero.get('montoRecibir')?.value;
      // let dineroARecibir: Recepcion = new Recepcion(cbuRecibir, montoRecibir);
      console.log(cbuRecibir, montoRecibir)
    }
  }

}
