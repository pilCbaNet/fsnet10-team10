import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Login } from '../models/login.model';

@Injectable({
  providedIn: 'root'
})
export class UsersService {


  constructor( private http: HttpClient ) { }

  iniciarSesion(login: Login):Observable<any> {

   return this.http.post('http://localhost:3000/posts', login)
      
  }
}
