import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from "@angular/router";
import { PokemonComponent } from './pokemon/pokemon.component';
import { PokemonDetailComponent } from './pokemon-detail/pokemon-detail.component';

const appRoutes: Routes = [
  { path: "pokemon", component: PokemonComponent },
  { path: "pokemondetail/:name", component: PokemonDetailComponent }
];

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forRoot(appRoutes)
  ],
  declarations: []
})
export class AppRoutingModule { }
