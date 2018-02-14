 
import { Injectable, Injector } from '@angular/core';
import { HttpClient, HttpEvent, HttpInterceptor, HttpHandler, HttpRequest, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs/Rx';
import { Observer } from 'rxjs/Observer'; 
import 'rxjs/add/operator/map';

import { Customer } from '../models/customer';
import { environment } from '../../environments/environment'; 

@Injectable()
export class CustomerService {

  serviceName = environment.serviceRoot + "/customer";

  constructor(private http:HttpClient) { }

  getAll(){
    let result$ = this.http.get<Customer[]>(this.serviceName );
    return result$;
  }

  get(email:String, password:String){
    let result$ = this.http.get<Customer>(this.serviceName + '/' + email);
    return result$;
  }

  save(customer:Customer){     
    return this.http.post(this.serviceName, customer);
  }
}
