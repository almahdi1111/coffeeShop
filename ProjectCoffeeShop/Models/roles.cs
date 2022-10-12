using System.ComponentModel.DataAnnotations;

namespace ProjectCoffeeShop.Models
{
    public class roles
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Role { get; set; }
    }
}
