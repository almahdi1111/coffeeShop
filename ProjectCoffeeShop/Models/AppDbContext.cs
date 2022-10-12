using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ProjectCoffeeShop.Models
{
    public class AppDbContext: IdentityDbContext<customer>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
        public DbSet<customer> customers  { get; set; }
        public DbSet<items> items { get; set; }
        public DbSet<roles> roles{ get; set; }
        public DbSet<CoffeeStrength> coffeeStrengths { get; set; }
        public DbSet<Message> messages { get; set; }
        public DbSet<order> orders { get; set; }
    }
}
