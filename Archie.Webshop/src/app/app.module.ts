import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms'; 
import { HttpClientModule } from '@angular/common/http';
import { MatDialogModule, MatSortModule } from '@angular/material';

/* routing */
import { routing } from "./app.routing";

/* components */
import { AppComponent } from './app.component';
import { RegistrationComponent } from './components/registration/registration.component'; 

/* services */
import { CustomerService } from './services/customer.service';
import { CountriesService } from './services/countries.service';

/* directives */
import { EqualValidator } from './validators/passwordvalidation';
import { HomeComponent } from './components/home/home.component';


export const firebaseConfig={
  apiKey: "AIzaSyBPs8_npqv5gwU3aXy4XbMe7C97WzPfbjw",
  authDomain: "archiesummit-283cc.firebaseapp.com",
  databaseURL: "https://archiesummit-283cc.firebaseio.com",
  projectId: "archiesummit-283cc",
  storageBucket: "archiesummit-283cc.appspot.com",
  messagingSenderId: "236708631450"
}


@NgModule({
  declarations: [
    AppComponent,
    RegistrationComponent,
    EqualValidator,
    HomeComponent
  ],
  imports: [
    routing,
    BrowserModule,
    BrowserAnimationsModule,
    FormsModule,
    HttpClientModule,
    MatDialogModule,
    MatSortModule,
  ],
  entryComponents : [ ],
  providers: [CustomerService, CountriesService],
  bootstrap: [AppComponent]
})
export class AppModule { }
