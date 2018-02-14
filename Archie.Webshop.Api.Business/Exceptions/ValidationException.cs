using System;
using System.Collections.Generic;
using System.Text;

namespace Archie.Webshop.Api.Business.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException(IDictionary<string,IEnumerable<string>> errors)
        {
            Errors = errors;
        }

        public IDictionary<string,IEnumerable<string>> Errors { get; private set; }
    }
}
