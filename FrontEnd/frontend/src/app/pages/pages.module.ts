import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';
import { PageRoutingModule } from './pages-routing.module';

import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { ContactComponent } from './contact/contact.component';
import { MainComponent } from './main/main.component';
import { SidebarComponent } from '../shared/sidebar/sidebar.component';
import { TransactionsComponent } from '../components/transactions/transactions.component';
import { TransactionsPageComponent } from './transactions-page/transactions-page.component';
import { SpinnerComponent } from '../components/spinner/spinner.component';
import { EnviarComponent } from './enviar/enviar.component';
import { RecibirComponent } from './recibir/recibir.component';
import { ErrorResponseComponent } from '../components/error-response/error-response.component'

@NgModule({
  declarations: [
    HomeComponent,
    AboutComponent,
    ContactComponent,
    MainComponent,
    SidebarComponent,
    TransactionsComponent,
    TransactionsPageComponent,
    SpinnerComponent,
    EnviarComponent,
    RecibirComponent,
    ErrorResponseComponent
  ],
  imports: [
    CommonModule,
    RouterModule,
    PageRoutingModule,
    ReactiveFormsModule
  ]
})
export class PagesModule { }
