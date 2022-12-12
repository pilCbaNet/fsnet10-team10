import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Transaction } from 'src/app/models/transaction.model';
import { TransactionService } from 'src/app/services/transaction.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html'
})
export class HomeComponent  {
  listTransaction: Transaction[] | undefined;
  constructor( private router: Router, private transactionService: TransactionService ) { }
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
          error: (error) => console.error(error),
          complete: ()=> console.info('Peticion terminada')
        }
        )
    }
  



}
