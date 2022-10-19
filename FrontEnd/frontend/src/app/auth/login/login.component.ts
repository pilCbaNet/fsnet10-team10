import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html'
})
export class LoginComponent implements OnInit {

  constructor( private userService: UserService,
               private router     : Router 
  ) { }

  ngOnInit(): void {
  }

  login() {

    this.userService.login()
      .subscribe( resp => {
        console.log(resp)
      })
    // this.router.navigate(['./home'])
  }
}
