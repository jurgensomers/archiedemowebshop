using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Archie.Webshop.Api.Data;
using Archie.Webshop.Api.Models;
using Archie.Webshop.Api.Models.Validation;

namespace Archie.Webshop.Api.Business
{
    public class CustomerLogic : ICustomerLogic
    {
        public CustomerLogic() : this(new CustomerProxy())
        {

        }
        

        public CustomerLogic(ICustomerProxy customerProxy)
        {
            _customerProxy = customerProxy;
        }

        private readonly ICustomerProxy _customerProxy;


        public Customer Save(Customer customer)
        {
            return _customerProxy.Save(customer);
        }

        public IList<Customer> GetAll()
        {
            return _customerProxy.GetAll();
        }

        public Customer Get(string email,string password)
        {
            return _customerProxy.Get(email);
        }

        public bool IsEmailUnique(string email)
        {
            var existing = _customerProxy.Get(email);
            return existing == null;
        }


    }
}
