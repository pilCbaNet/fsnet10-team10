import { Component, OnInit } from '@angular/core';
import { AboutService } from '../services/about-service';

@Component({
  selector: 'app-about',
  templateUrl: './about.component.html'
})
export class AboutComponent implements OnInit {
  about: any;

  constructor( private aboutService: AboutService) { }

  ngOnInit(): void {
    this.aboutService.quienesSomosData().subscribe(data => {
      this.about = data;
    })
  }



}
