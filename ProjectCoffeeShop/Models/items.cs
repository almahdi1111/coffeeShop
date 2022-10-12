using System.ComponentModel.DataAnnotations;

namespace ProjectCoffeeShop.Models
{
    public class items
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public float Cost { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public float sell { get; set; }
        public int CoffeeStrengthId { get; set; }
        public virtual CoffeeStrength CoffeeStrength { get; set; }
        public string ImagePath { get; set; } = null;
    }
}
