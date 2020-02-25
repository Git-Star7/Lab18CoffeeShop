using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Day26Lab18and19CoffeeShop.Models
{
    public class RegisterUser
    {
        [Required]
        [RegularExpression(@"^\b[A-Z][a-z]{3,30}\b$", ErrorMessage = "Must be between 3 and 30 characters")]
        public string UserName { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9{5, 30}]+@[a-zA-A0-9{5,10}]+\.[a-zA-Z0-9{2,3}]+$", ErrorMessage = "Enter a valid Email Address")]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^[A-z0-9]{8,}$", ErrorMessage = "Must be 8 characters long and have numbers and letters")]
        public string Password { get; set; }
        [Required]
        public string Gender { get; set; }
        [RegularExpression(@"^\b\d{3}-\d{3}-\d{4}\b|\b\d{10}\b$", ErrorMessage = "Phone Number must be in correct format")]
        public string PhoneNum { get; set; }
        public int Age { get; set; }
    }
}
