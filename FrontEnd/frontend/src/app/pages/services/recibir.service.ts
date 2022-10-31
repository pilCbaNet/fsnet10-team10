import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Recepcion } from '../models/recibirDinero.model';

@Injectable({
  providedIn: 'root'
})
export class UsersService {


  constructor( private http: HttpClient ) { }

  iniciarSesion(recepcion: Recepcion):Observable<any> {

   return this.http.post('http://localhost:3000/posts', recepcion)
      
  }
}