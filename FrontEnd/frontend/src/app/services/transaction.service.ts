import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map, Observable, pipe, tap } from 'rxjs';
import { UsersService } from '../auth/services/users.service';
import { environment } from '../../environments/environment.prod';
import { Usuario } from '../auth/interfaces/interfaces';
import { TransResponse } from '../pages/interfaces/interfaces';

@Injectable({
  providedIn: 'root'
})
export class TransactionService {
  private _saldo: any;
  private _transacciones: any;

  get usuario() {
    return this.usersService.usuario;
  }

  get saldo(){
    return {...this._saldo}
  }

  get transacciones(){
    return {...this._transacciones}
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
        }
      }));
  }


  enviarDinero(id: string, Cvu: number, Cantindad: number, CvuDestino: number, idCuentaDestino: number){
    let url = environment.baseUrlTest;
    let body = {}

    return this.http.put<any>(`${url}Cuentas/api/Extraer?id=${id}&Cvu=${Cvu}&Cantidad=${Cantindad}&CvuDestino=${CvuDestino}&idCuentaDestino=${idCuentaDestino}`, body)
    // /Cuentas/api/Extraer?id=1&Cvu=34343434343434&Cantidad=1&CvuDestino=56456456&idCuentaDestino=112
  }

  recibirDinero(id: number, Cvu: number, Cantindad: number, CvuDestino: number, idCuentaDestino: string){
    let url = environment.baseUrlTest;
    let body = {}

    return this.http.put<any>(`${url}Cuentas/api/Extraer?id=${id}&Cvu=${Cvu}&Cantidad=${Cantindad}&CvuDestino=${CvuDestino}&idCuentaDestino=${idCuentaDestino}`, body)
    // /Cuentas/api/Extraer?id=1&Cvu=56456456&Cantidad=undefined&CvuDestino=34343434343434&idCuentaDestino=112
  }

  ultimosMovimientos(idCuenta: string){
    let url = environment.baseUrlTest;

    return this.http.get<any>(`${url}Operaciones/api/UltimosMovimientosAll?idCuenta=${idCuenta}`)
      .pipe(
        tap(resp => {
            let respuesta = resp[0]
            this._transacciones = {
              idOperacion: respuesta.idOperacion,
              fecha: respuesta.fecha,
              monto: respuesta.monto,
              deposito: respuesta.deposito
            }
        })
      )
  }
  }


