using System;
using System.ComponentModel.DataAnnotations;

namespace Archie.Webshop.Api.Models
{
    public class Address
    {
        [Required(ErrorMessage = "Address line is required")]
        public string Line1 { get; set; }
        [Required(ErrorMessage = "Address line is required")]
        public string Line2 { get; set; }
        [Required(ErrorMessage = "City is required")]
        public string Municipality { get; set; }
        [Required(ErrorMessage = "Zip code is required")]
        public string Zipcode { get; set; }
        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; }
    }
}
