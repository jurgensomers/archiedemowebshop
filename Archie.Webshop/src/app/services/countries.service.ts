import { Injectable } from '@angular/core';
import { HttpClient, HttpEvent, HttpInterceptor, HttpHandler, HttpRequest, HttpHeaders} from '@angular/common/http';

@Injectable()
export class CountriesService {

  constructor(private http:HttpClient) { }

  getAll(){
    let result$ = this.http.get("https://restcountries.eu/rest/v2/all");
    return result$;
  }

}
