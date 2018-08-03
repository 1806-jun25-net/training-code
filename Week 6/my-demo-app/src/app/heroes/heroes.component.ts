import { Component, OnInit } from '@angular/core';
import { hero } from '../hero';
import { Heroes } from '../mock-hero';
 
@Component({
  selector: 'app-heroes',
  templateUrl: './heroes.component.html',
  styleUrls: ['./heroes.component.css']
})
export class HeroesComponent implements OnInit {
 
  heroes = Heroes;
 
  selectedHero: hero;
 
 
  constructor() { }
 
  ngOnInit() {
  }
 
  onSelect(hero: hero): void {
    this.selectedHero = hero;
  }
}