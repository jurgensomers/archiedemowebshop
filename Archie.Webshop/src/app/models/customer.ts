import { Address } from './address';

export class Customer {

    constructor(){
        this.address = new Address();
    }
    name:String;
    firstName:String;
    dateOfBirth:Date;
    email:String;
    password:String;
    confirmPassword:String;
    gender:String;
    keepInformed:Boolean;
    address:Address;
}
