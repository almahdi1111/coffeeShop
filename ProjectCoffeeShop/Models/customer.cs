using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectCoffeeShop.Models
{
    public class customer: IdentityUser
    {
        [Required(ErrorMessage = "ادخل الاسم الاول ")]
        public string FName { get; set; }   
        [Required(ErrorMessage = "ادخل اللقب ")]

        public string LName { get; set; }
        public int RoleId { get; set; }
        [Required(ErrorMessage = "ادخل كلمة المرور ")]
        public string Password { get; set; }
    }
}
