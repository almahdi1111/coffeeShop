using System.ComponentModel.DataAnnotations;

namespace ProjectCoffeeShop.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string FullName { get; set; }
        public string Email { get; set; }
        public string findUs { get; set; }
        public string Content { get; set; }

    }
}
