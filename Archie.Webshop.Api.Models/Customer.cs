using System;
using System.ComponentModel.DataAnnotations;
using Archie.Webshop.Api.Models.Validation;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Archie.Webshop.Api.Models
{
    public class Customer
    {
        public Customer()
        {
            Address = new Address();
        }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime? DateOfBirth { get; set; }

        [Required(ErrorMessage = "Email is required"), EmailAddress(ErrorMessage = "Email should be a valid email address"), EmailUnique(ErrorMessage = "Email is already registered")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Gender Gender { get; set; }

        public bool KeepInformed { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public Address Address { get; set; }
    }
}