using System;
using System.Collections.Generic;
using System.Linq;
using Archie.Webshop.Api.Data.Firebase;
using Archie.Webshop.Api.Models;

namespace Archie.Webshop.Api.Data
{
    public class CustomerProxy : ICustomerProxy
    {
        public Customer Get(string email)
        {
            if (!string.IsNullOrWhiteSpace(email))
            {
                var all = this.GetAll();
                return all.FirstOrDefault(x => x.Email.ToUpper() == email.ToUpper());
            }
            return null;
        }

        public IList<Customer> GetAll()
        {
            var firebaseDb = new FirebaseDB("https://archiewebshop-demo.firebaseio.com");
            var firebaseTarget = firebaseDb.Node("customers");

            var response = firebaseTarget.Get();
            var all = response.JSONContent.DeserializeJson<Dictionary<string,Customer>>();
            return all.Values.ToList();
        }

        public Customer Save(Customer model)
        {
            var firebaseDb = new FirebaseDB("https://archiewebshop-demo.firebaseio.com");
            var firebaseTarget = firebaseDb.Node("customers");
            var request = firebaseTarget.Post(model.SerializeJson());
            return model;
        }
    }
}
