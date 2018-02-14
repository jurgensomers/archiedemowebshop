using System.Collections.Generic;
using Archie.Webshop.Api.Models;

namespace Archie.Webshop.Api.Data
{
    public interface ICustomerProxy
    {
        Customer Save(Customer model);
        IList<Customer> GetAll();
        Customer Get(string email);
    }
}