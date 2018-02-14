using System.ComponentModel.DataAnnotations; 

namespace Archie.Webshop.Api.Models.Validation
{
    public class EmailUniqueAttribute : ValidationAttribute
    {
        public EmailUniqueAttribute()
        {
           
        }
         

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if ( !RulesEngine.Execute(nameof(EmailUniqueAttribute), value))
            {
                return new ValidationResult(this.ErrorMessage);
            }
          
            return ValidationResult.Success;
        }
    }
}