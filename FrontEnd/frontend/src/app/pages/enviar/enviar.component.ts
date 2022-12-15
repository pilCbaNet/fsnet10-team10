import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Envio } from '../models/enviarDinero.mode';
import { TransactionService } from '../../services/transaction.service';
import { UsersService } from '../../auth/services/users.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-enviar',
  templateUrl: './enviar.component.html'
})

export class EnviarComponent implements OnInit {

  get usuario() {
    return this.userService.usuario;
  }

  get saldo() {
    return this.transactionService.saldo;
  }

  get transacciones() {
    return this.transactionService.transacciones;
  }

  enviarDinero: FormGroup = this.fb.group({
    cbuEnviar: ['', [Validators.required]],
    montoEnviar: ['', [Validators.required]],
  });

  get cbuEnviar() {
    return this.enviarDinero.get('cbuEnviar');
  }

  get montoEnviar() {
    return this.enviarDinero.get('montoEnviar');
  }

  constructor(private fb: FormBuilder,
              private router: Router,
              private transactionService: TransactionService,
              private userService: UsersService) { }

  ngOnInit(): void {
  }

  enviar() {
    if(this.enviarDinero.valid) {

      let id = this.usuario.idUsuario;
      let Cvu = 34343434343434;
      let Cantidad = this.enviarDinero.get('montoEnviar')?.value;
      let CvuDestino = this.enviarDinero.get('cbuEnviar')?.value;;
      let idCuentaDestino = 112;

      this.transactionService.enviarDinero(id, Cvu, Cantidad, CvuDestino, idCuentaDestino).subscribe(resp => {
        if(resp == true) {
          Swal.fire({
            position: 'center',
            icon: 'success',
            title: 'El dinero se envió correctamente',
            showConfirmButton: false,
            timer: 3000
          });
          this.router.navigateByUrl('/main')
        }
      })
    }
  }
}
