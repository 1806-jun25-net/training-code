import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PokeapiService {

  // shorthard for declaring httpClient property and
  // setting it equal to the parameter
  constructor(private httpClient: HttpClient) { }

  getPokemon(
    searchText: string,
    success,
    failure
  ) {
    // searchText will just be the ID or name of the pokemon
    let url = "https://pokeapi.co/api/v2/pokemon/" + searchText;
    let request = this.httpClient.get(url);
    let promise = request.toPromise();

    promise.then(success, failure);
  }

  getAllPokemon(success, failure) {
    this.getPokemon("", success, failure);
  }
}
