using System.Collections.Generic;
using Archie.Webshop.Api.Models;

namespace Archie.Webshop.Api.Business
{
    public interface ICustomerLogic
    {
        IList<Customer> GetAll();
        Customer Get(string email, string password);

        Customer Save(Customer model);

        bool IsEmailUnique(string email);
    }
}