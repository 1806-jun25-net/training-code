import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class PokeapiService {

  constructor(private httpClient: HttpClient) { }

  getPokemon(
    searchText: string,
    success,
    failure
  ) {
    let url = `https://pokeapi.co/api/v2/pokemon/${searchText}`;
    var request = this.httpClient.get(url);

    this.httpClient.post(
      "http://google.com",
      { username: "", password: "" },
      { withCredentials: true }
    )

    let promise = request.toPromise();

    promise.then(success, failure);
  }

  getAllPokemon(
    success,
    failure
  ) {
    this.getPokemon("", success, failure);
  }
}
