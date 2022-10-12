using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectCoffeeShop.Models
{
    public class order
    {
        [Key]
        public int Id { get; set; }
        public virtual customer Customer { get; set; }
        [Required]
        public List<items> Items { get; set; }

        public DateTime OrderDate { get; set; }= DateTime.Now;

        public double TotalCost { get; set; }



    }
}
