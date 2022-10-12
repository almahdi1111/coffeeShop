using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectCoffeeShop.Models
{
    public class CoffeeStrength
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Strength { get; set; }
        public virtual ICollection<items> items { get; set; }

    }
}
