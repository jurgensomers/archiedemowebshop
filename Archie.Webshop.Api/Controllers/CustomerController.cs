using System.Collections.Generic;
using Archie.Webshop.Api.Business;
using Archie.Webshop.Api.Models;
using Archie.Webshop.Api.Models.Validation;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Archie.Webshop.Api.Controllers
{
    [Route("api/customer")]
    public class CustomerController : Controller
    {
        public CustomerController() //: this(new CustomerLogic())
        {
            _customerLogic = new CustomerLogic();

            RulesEngine.AddRule<string>(nameof(EmailUniqueAttribute), _customerLogic.IsEmailUnique);
        }

        //public CustomerController(ICustomerLogic customerLogic)
        //{
        //    _customerLogic = customerLogic;
        //}

        private readonly ICustomerLogic _customerLogic;

        // GET api/customer
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customerLogic.GetAll();
        }

        // GET api/customer/john.doe@acme.com
        [HttpGet("{email}")]
        public Customer Get(string email, [FromBody] string password)
        {
            return _customerLogic.Get(email,password);
        }
 

        // POST api/customer
        [HttpPost]
        public IActionResult Post([FromBody]Customer model)
        {
            if (model == null) return BadRequest("no data");
            TryValidateModel(model);
            if (ModelState.IsValid)
                return Ok(_customerLogic.Save(model));
            return base.BadRequest(ModelState);

        }
  
    }
}