import { TestBed, inject } from '@angular/core/testing';

import { PokeapiService } from './pokeapi.service';
import { HttpClientModule } from '@angular/common/http';

describe('PokeapiService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [PokeapiService],
      imports: [HttpClientModule]
    });
  });

  it('should be created', inject([PokeapiService], (service: PokeapiService) => {
    expect(service).toBeTruthy();
  }));
});
