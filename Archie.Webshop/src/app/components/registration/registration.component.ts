import { Component, OnInit, ViewChild } from '@angular/core'; 
import { Router, ActivatedRoute } from '@angular/router';
import { Customer } from '../../models/customer';
import { CustomerService } from '../../services/customer.service';
import { CountriesService } from '../../services/countries.service'; 

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {

  model:Customer;
  countries:any; 
  isRegistered:Boolean;
  errors:String[];
  @ViewChild('registrationForm') form;

  constructor(private customerService:CustomerService, private countriesService:CountriesService) {
    
   }

  ngOnInit() {
    this.isRegistered = false;
    this.model = new Customer();
    this.countriesService.getAll().subscribe(
      data => {this.countries = data;}, 
      error => console.log(error));
  }

  submit(){  
    this.customerService.save(this.model).subscribe( 
      data => {  this.isRegistered=true;},
      err => { console.log(err);this.openFailed(err);});
  }

   

  openFailed(errors:any)   {
     this.errors = [];
    for (var key in errors.error) {
      this.errors.push(errors.error[key][0]);
      //console.log(key, errors.error[key]); 
      //console.log(errors.error[key][0]);
      //formData.form.controls[key].setErrors({'incorrect': true});
    }
    

  }

}
