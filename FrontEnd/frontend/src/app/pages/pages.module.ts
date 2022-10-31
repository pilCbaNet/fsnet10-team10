import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { ContactComponent } from './contact/contact.component';
import { MainComponent } from './main/main.component';
import { PageRoutingModule } from './pages-routing.module';
import { SidebarComponent } from '../shared/sidebar/sidebar.component';
import { EnviarComponent } from './enviar/enviar.component';
import { RecibirComponent } from './recibir/recibir.component';

@NgModule({
  declarations: [
    HomeComponent,
    AboutComponent,
    ContactComponent,
    MainComponent,
    SidebarComponent,
    EnviarComponent,
    RecibirComponent
  ],
  imports: [
    CommonModule,
    RouterModule,
    PageRoutingModule
  ]
})
export class PagesModule { }
