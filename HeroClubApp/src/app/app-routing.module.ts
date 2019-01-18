import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { HeroiComponent } from './heroi/heroi.component';
import { EquipeComponent } from './equipe/equipe.component';
import { BatalhaComponent } from './batalha/batalha.component';

const routes: Routes = [
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
  { path: 'herois', component: HeroiComponent },
  { path: 'equipes', component: EquipeComponent },
  { path: 'batalhas', component: BatalhaComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
