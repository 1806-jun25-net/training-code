import { Component, OnInit } from '@angular/core';
import { Pokemon } from '../models/pokemon';
import { PokeapiService } from '../pokeapi.service';

@Component({
  selector: 'app-pokemon',
  templateUrl: './pokemon.component.html',
  styleUrls: ['./pokemon.component.css']
})
export class PokemonComponent implements OnInit {
  pokemons: Pokemon[] = [
    //{name: "Bulbasaur", height: 20, weight: 20}
  ];

  searchText: string;

  constructor(private api: PokeapiService) { }

  ngOnInit() {
  }

  getPokemon() {
    if (this.searchText === "") {
      this.api.getAllPokemon(
        (res) => {
          console.log("success");
          console.log(JSON.stringify(res));
          this.pokemons = res.results;
        },
        (res) => console.log("failure")
      );
    } else {
      this.api.getPokemon(this.searchText,
        (res) => {
          // console.log(JSON.stringify(res));
          this.pokemons = [res];
        },
        (res) => console.log("failure")
      );
    }
  }
}
