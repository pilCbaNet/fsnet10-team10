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
  errorResponseTransaction: HttpErrorResponse | undefined;
  constructor(
    private router: Router,
    private transactionService: TransactionService,
    private userService: UsersService
  ) {}
    ngOnInit(): void{
      this.transactionService.obtainListTransactions().subscribe(
        {
          next: (response: Transaction[])=>{
            response.forEach((tran, i)=>{
              if (i === 0) {
                this.listTransaction = [tran]
              }
              if (i < 5 && i !== 0) {
                this.listTransaction?.push(tran)
              }
            })

          },
          error: (error) => {

            // Simulacion de espera del pedido antes del error
            setTimeout(()=>{
              this.errorResponseTransaction = error
            }, 10000)
          },
          complete: ()=> console.info('Peticion terminada')
        }
        )
    }
  
}
