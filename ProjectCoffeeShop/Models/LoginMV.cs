using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectCoffeeShop.Models
{
    public class LoginMV
    {

        [Required(ErrorMessage ="Enter Email Address")]
        public string Email { get; set; }  
        [Required(ErrorMessage ="Enter Password")]
        public string Password { get; set; }
    }
}
