import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Account } from './_models/account';
import { environment } from '../environments/environment';

@Injectable()
export class AuthenticationService {

  constructor(private http: HttpClient) { }

  login(
    client: Account,
    pass = (data: Object) => { },
    fail = err => { }) {
    // Http call
    this.http.post(
      environment.libraryServiceUri + '/api/account/login',
      client,
      { withCredentials: true }
    ).subscribe(
      data => {
        client = <Account>data;
        sessionStorage.setItem("AccountKey", JSON.stringify(client));
        pass(data);
      },
      fail
      );
  }

  logout(pass = (data: Object) => { }, fail = err => { }): void {
    var client = JSON.parse(sessionStorage.getItem('AccountKey'));
    this.http.post(
      environment.libraryServiceUri + '/api/account/logout',
      client,
      { withCredentials: true }
    ).subscribe(pass, fail);
    sessionStorage.removeItem('AccountKey');
  }

  register(client: Account, pass = (data: Object) => { }, fail = err => { }): void {
    this.http.post(
      environment.libraryServiceUri + '/api/account/register',
      client,
      { withCredentials: true }
    ).subscribe(pass, fail);
  }

  update(client: Account, pass = (data: Object) => { }, fail = err => { }): void {
    this.http.post(
      environment.libraryServiceUri + '/api/account/update',
      client,
      { withCredentials: true }
    ).subscribe(pass, fail);
  }
}
