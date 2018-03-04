using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public abstract class Address
    {

       [RegularExpression(@"^[a-zA-Z0-9._%+-]+@contoso\.edu$", ErrorMessage = "Email Address entered should be end with @contoso.edu")]
        public string Email { get; set; }

        //public Address(string EmailInput) {
            //Email = EmailInput;
        //}
    }


}