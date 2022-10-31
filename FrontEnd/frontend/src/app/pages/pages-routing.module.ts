import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './about/about.component';
import { ContactComponent } from './contact/contact.component';
import { EnviarComponent } from './enviar/enviar.component';
import { HomeComponent } from './home/home.component';
import { MainComponent } from './main/main.component';
import { TransactionsPageComponent } from './transactions-page/transactions-page.component';
import { RecibirComponent } from './recibir/recibir.component';


const routes: Routes = [
    {
      path: '',
      component: MainComponent,
      children: [
        { path: 'inicio', component:  HomeComponent,},
        { path: 'contact', component:  ContactComponent},
        { path: 'about', component:  AboutComponent},
        { path: 'transaction', component:  TransactionsPageComponent},
        { path: 'enviar', component:  EnviarComponent},
        { path: 'recibir', component:  RecibirComponent},
        { path: '**', redirectTo: 'inicio' },
      ]
    },
  ];

  @NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
  })
  export class PageRoutingModule { }
