import { ModuleWithProviders } from "@angular/core";
import { Routes, RouterModule } from '@angular/router';
 
import { RegistrationComponent } from './components/registration/registration.component'; 
import { HomeComponent } from './components/home/home.component'; 

/* Routes */
const routes: Routes = [ 
  {
    path: 'home',
    component : HomeComponent
  }  ,
    {
      path: 'register',
      component : RegistrationComponent
    }    
  ]

  export const routing: ModuleWithProviders = RouterModule.forRoot(routes);
  