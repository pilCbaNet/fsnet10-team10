import { Component, OnInit } from '@angular/core';
import { Transaction } from 'src/app/models/transaction.model';
import { TransactionService } from 'src/app/services/transaction.service';

@Component({
  selector: 'app-transactions-page',
  templateUrl: './transactions-page.component.html',
  styleUrls: ['./transactions-page.component.css']
})
export class TransactionsPageComponent implements OnInit {
  // listTransaction: Transaction[] | undefined;
  // constructor(private transactionService: TransactionService ) { }

  ngOnInit(): void {
    // this.transactionService.obtainListTransactions().subscribe(
    //   {
    //     next: (response: Transaction[])=>{
    //       this.listTransaction = response
    //     },
    //     error: (error) => console.error(error),
    //     complete: ()=> console.info('Peticion terminada')
    //   }
    //   )
  }
}

