import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { PokemonComponent } from './pokemon/pokemon.component';
import { PokemonDetailComponent } from './pokemon-detail/pokemon-detail.component';
import { AppRoutingModule } from './/app-routing.module';
import { RouterModule } from '../../node_modules/@angular/router';
import { NavbarComponent } from './navbar/navbar.component';

@NgModule({
  declarations: [
    AppComponent,
    PokemonComponent,
    PokemonDetailComponent,
    NavbarComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,         // for ngModel
    HttpClientModule,    // for HttpClient
    AppRoutingModule,    // my appRoutes to get used
    RouterModule         // for router-outlet directive
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
