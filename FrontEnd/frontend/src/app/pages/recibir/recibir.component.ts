import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

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
  
  get email() {
    return this.recibirDinero.get('cbuRecibir');
  }

  get pass() {
    return this.recibirDinero.get('montoRecibir');
  }
  constructor(private fb: FormBuilder,
              private router: Router,) { }

  ngOnInit(): void {
  }

  enviar() {
    if(this.recibirDinero.valid) {
      let cbuRecibir: number = this.recibirDinero.get('cbuRecibir')?.value;
      let montoRecibir : number = this.recibirDinero.get('montoRecibir')?.value;
      let dineroARecibir: Login = new Login(cbuRecibir, montoRecibir);

    }
  }

}
