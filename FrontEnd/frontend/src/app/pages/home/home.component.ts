import { HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Transaction } from 'src/app/models/transaction.model';
import { TransactionService } from 'src/app/services/transaction.service';
import { UsersService } from '../../auth/services/users.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {

  get usuario() {
    return this.userService.usuario;
  }

  listTransaction: Transaction[] | undefined;
  constructor(
    private router: Router,
    private transactionService: TransactionService,
    private userService: UsersService
  ) {}
  
  ngOnInit(): void {
    this.consultarSaldo()
    this.consultarMovimientos()
  }

  consultarSaldo(){
    let id = this.usuario.idUsuario;
    this.transactionService.consultarSaldo(id).subscribe(resp => {
    })
  }

  consultarMovimientos(){
    let idCuenta = '1';

    this.transactionService.ultimosMovimientos(idCuenta).subscribe(resp => {
      
    })
  }
}
