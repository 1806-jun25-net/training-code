import { Component, OnInit } from '@angular/core';
import { Pokemon } from '../models/pokemon';
import { PokeapiService } from '../pokeapi.service';
import { ActivatedRoute } from '../../../node_modules/@angular/router';

@Component({
  selector: 'app-pokemon-detail',
  templateUrl: './pokemon-detail.component.html',
  styleUrls: ['./pokemon-detail.component.css']
})
export class PokemonDetailComponent implements OnInit {
  pokemon: Pokemon;

  constructor(
    private api: PokeapiService,
    private route: ActivatedRoute) { }

  ngOnInit() {
    // this is how we get a named route parameter out of this route
    // in this case, my param is called "name"
    let name = this.route.snapshot.paramMap.get("name");
    this.api.getPokemon(name,
      (res) => { this.pokemon = res },
      (res) => console.log("failure"));
  }

}