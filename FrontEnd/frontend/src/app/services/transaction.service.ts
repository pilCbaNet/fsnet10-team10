import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { UsersService } from '../auth/services/users.service';
import { environment } from '../../environments/environment.prod';
import { Usuario } from '../auth/interfaces/interfaces';

@Injectable({
  providedIn: 'root'
})
export class TransactionService {
  
  get usuario() {
    return this.usersService.usuario;
  }

  constructor(private http: HttpClient,
              private usersService: UsersService) { }

  obtainListTransactions(): Observable<any> {
    return this.http.get('http://localhost:3000/transactions')
  }

  consultarSaldo(){
    let url = environment.baseUrlTest;

    this.http.get(`${url}Cuentas/`, )
  }
}
