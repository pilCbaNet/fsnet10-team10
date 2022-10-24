import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home/home.component';
import { SharedModule } from '../shared/shared.module';
import { AboutComponent } from './about/about.component';
import { ContactComponent } from './contact/contact.component';


@NgModule({
  declarations: [
    HomeComponent,
    AboutComponent,
    ContactComponent,
  ],
  imports: [
    CommonModule,
    SharedModule
  ]
})
export class PagesModule { }
