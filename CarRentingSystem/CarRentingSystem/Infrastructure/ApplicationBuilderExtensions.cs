using System;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using CarRentingSystem.Data;
using CarRentingSystem.Data.Models;

using static CarRentingSystem.WebConstants;

namespace CarRentingSystem.Infrastructure
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase(
           this IApplicationBuilder app)
        {
            using var scopredServices = app.ApplicationServices.CreateScope();

            var serviceProvider = scopredServices.ServiceProvider;

            var data = scopredServices.ServiceProvider.GetRequiredService<CarRentingDbContext>();

            data.Database.Migrate();

            SeedCategories(data);
            SeedAdministrator(serviceProvider);

            return app;
        }

        private static void SeedCategories(CarRentingDbContext data)
        {
            if (data.Categories.Any())
            {
                return;
            }

            data.Categories.AddRange(new[]
            {
                new Category {Name = "Mini"},
                new Category {Name = "Economy"},
                new Category {Name = "Midsize"},
                new Category {Name = "Large"},
                new Category {Name = "SUV"},
                new Category {Name = "Vans"},
                new Category {Name = "Luxury"},
            });

            data.SaveChanges();
        }

        private static void SeedAdministrator(IServiceProvider services)
        {
            var userManager = services.GetRequiredService<UserManager<User>>();
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

            Task.Run(async () =>
                {
                    if (await roleManager.RoleExistsAsync(AdministratorRoleName))
                    {
                        return;
                    }

                    var role = new IdentityRole
                    {
                        Name = AdministratorRoleName
                    };

                    await roleManager.CreateAsync(role);

                    const string adminEmail = "admin@crs.com";
                    const string adminPassword = "admin123";

                    var user = new User
                    {
                        Email = adminEmail,
                        UserName = adminEmail,
                        FullName = "Admin"
                    };

                    await userManager.CreateAsync(user, adminPassword);

                    await userManager.AddToRoleAsync(user, role.Name);
                })
                .GetAwaiter()
                .GetResult();
        }
    }
}
