using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ProjectCoffeeShop.Models
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using var serviceScope = applicationBuilder.ApplicationServices.CreateScope();
            var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

            context.Database.EnsureCreated();
            context.Database.Migrate();

            if (!context.roles.Any())
            {
                context.roles.AddRange(new List<roles>()
                {
                    new roles()
                    {

                        Role = "Admin",

                    },
                    new roles()
                    {
                        Role = "Customer",

                    },
                });

            }
            if (!context.coffeeStrengths.Any())
            {
                context.coffeeStrengths.AddRange(new List<CoffeeStrength>()
                {
                    new CoffeeStrength()
                    {
                        Strength = " LIGHT ROAST"

                    },
                    new CoffeeStrength()
                    {
                        Strength = "DARK ROAST",
                    },
                });

            }
        }
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using var serviceScope = applicationBuilder.ApplicationServices.CreateScope();

            //Roles
            var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
           
            if (!await roleManager.RoleExistsAsync(UserRoles.Customer))
                await roleManager.CreateAsync(new IdentityRole(UserRoles.Customer));

            //Users
            var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<customer>>();
            string adminUserEmail = "admin@FS.com";

            var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
            if (adminUser == null)
            {
                var newAdminUser = new customer()
                {
                    Id = "c6c75e08-3701-4345-b8f3-8db5be5310dc",
                    FName = "ali",
                    LName = "Mohmmed",
                    UserName = "admin",
                    Email = adminUserEmail,
                    EmailConfirmed = true,
                    RoleId = 1,
                    PhoneNumber = "773019241",
                    Password ="Admin123@",

                };
                await userManager.CreateAsync(newAdminUser, "Admin123@");
                await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
            }


            string appUserEmail = "user@FS.com";

            var appUser = await userManager.FindByEmailAsync(appUserEmail);
            if (appUser == null)
            {
                var newAppUser = new customer()
                {
                    Id = "c6c75e18-3701-4345-b8f3-8db5be5310dc",
                    FName = "Mohmmed",
                    LName="Ali",
                    UserName = "user",
                    Email = appUserEmail,
                    EmailConfirmed = true,
                    RoleId = 2,
                    PhoneNumber = "773019241",
                    Password = "User123@",
                };
                await userManager.CreateAsync(newAppUser, "User123@");
                await userManager.AddToRoleAsync(newAppUser, UserRoles.Customer);
            }
        }


    
}
}
