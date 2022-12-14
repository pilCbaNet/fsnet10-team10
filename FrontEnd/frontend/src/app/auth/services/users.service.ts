import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { catchError, Observable, of, tap } from 'rxjs';
import { Login } from '../models/login.model';
import { environment } from '../../../environments/environment.prod';
import { Usuario } from '../interfaces/interfaces';

@Injectable({
  providedIn: 'root'
})
export class UsersService {

  private _usuario!: Usuario;

  get usuario(){
    return { ...this._usuario };
  }

  constructor( private http: HttpClient ) { }

  //LOGIN
  iniciarSesion(login: Login):Observable<any> {
  let url = environment.baseUrlTest;

   return this.http.post<any>(`${url}login`, login)
    .pipe(
      tap(resp => {
        if(resp != null){
          this._usuario = {
            nombreUsuario: resp.nombreUsuario!,
            idUsuario: resp.idUsuario!,
          }
        }
      }));
  }

  crearCuenta( datos:any ){

    let url = environment.baseUrlTest;
    return this.http.post<any>(`${url}Usuarios`, datos);
  }
}
