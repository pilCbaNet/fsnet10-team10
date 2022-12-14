import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Transaction } from 'src/app/models/transaction.model';
import { TransactionService } from 'src/app/services/transaction.service';
import { UsersService } from '../../auth/services/users.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {

  get usuario() {
    return this.userService.usuario;
  }

  get saldo() {
    return this.transactionService.saldo;
  }

  // listTransaction: Transaction[] | undefined;

  constructor(
    private router: Router,
    private transactionService: TransactionService,
    private userService: UsersService
  ) {}
  
  ngOnInit(): void {

    // this.transactionService.obtainListTransactions().subscribe({
    //   next: (response: Transaction[]) => {
    //     response.forEach((tran, i) => {
    //       if (i === 0) {
    //         this.listTransaction = [tran];
    //       }
    //       if (i < 5 && i !== 0) {
    //         this.listTransaction?.push(tran);
    //       }
    //     });
    //   },
    //   error: (error) => console.error(error),
    //   complete: () => console.info('Peticion terminada'),
    // });
    this.consultarSaldo()
  }

  consultarSaldo(){
    let id = this.usuario.idUsuario;
    console.log(id);
    this.transactionService.consultarSaldo(id).subscribe(resp => {
      console.log('respuesta CONSULTA', resp)
    })
  }
}
