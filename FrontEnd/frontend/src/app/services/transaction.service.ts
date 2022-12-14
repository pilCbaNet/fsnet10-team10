import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map, Observable, pipe, tap } from 'rxjs';
import { UsersService } from '../auth/services/users.service';
import { environment } from '../../environments/environment.prod';
import { Usuario } from '../auth/interfaces/interfaces';

@Injectable({
  providedIn: 'root'
})
export class TransactionService {
  private _saldo: any;

  get usuario() {
    return this.usersService.usuario;
  }

  get saldo(){
    return {...this._saldo}
  }

  constructor(private http: HttpClient,
              private usersService: UsersService) { }

  // obtainListTransactions(): Observable<any> {
  //   return this.http.get('http://localhost:3000/transactions')
  // }

  consultarSaldo(id: string){
    let url = environment.baseUrlTest;


    
    return this.http.get<any>(`${url}Cuentas/${id}`)
    .pipe(
      tap(resp => {
        if(resp != null){
          this._saldo = {
            saldo: resp.saldo!,
          }
          console.log(JSON.stringify(this.saldo));
        }
      }));
  }

  }

