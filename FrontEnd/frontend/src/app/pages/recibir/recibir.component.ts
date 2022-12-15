import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Recepcion } from '../models/recibirDinero.model';
import { TransactionService } from '../../services/transaction.service';
import { UsersService } from '../../auth/services/users.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-recibir',
  templateUrl: './recibir.component.html',
  styleUrls: ['./recibir.component.css']
})

export class RecibirComponent implements OnInit {

  get usuario() {
    return this.userService.usuario;
  }

  get saldo() {
    return this.transactionService.saldo;
  }

  get transacciones() {
    return this.transactionService.transacciones;
  }

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
              private router: Router,
              private transactionService: TransactionService,
              private userService: UsersService) { }

  ngOnInit(): void {
  }

  recibir() {
    if(this.recibirDinero.valid) {
      let id = 112;
      let Cvu = this.recibirDinero.get('cbuRecibir')?.value;
      let Cantidad = this.recibirDinero.get('montoRecibir')?.value;
      let CvuDestino = 56456456;
      let idCuentaDestino = this.usuario.idUsuario;

      this.transactionService.recibirDinero(id, Cvu, Cantidad, CvuDestino, idCuentaDestino).subscribe(resp => {
        if(resp == true) {
          Swal.fire({
            position: 'center',
            icon: 'success',
            title: 'El dinero se recibió correctamente',
            showConfirmButton: false,
            timer: 3000
          });
          this.router.navigateByUrl('/main')
        }
      })
    }
    
  }
}
  
