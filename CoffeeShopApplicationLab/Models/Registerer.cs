using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShopApplicationLab.Models
{
    public class Registerer
    {

        [MinLength(3)]
        [Required]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "That is not a valid name")]
        public string FirstName { get; set; }


        [MinLength(3)]
        [Required]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "That is not a valid name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpressionAttribute(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$", ErrorMessage = "Password must contain one uppercase, one lowercase, one number, and one special character")]
        public string Password { get; set; }

    }
}