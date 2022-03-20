using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System;
using PhDThesisPortal.Models;
using static PhDThesisPortal.Models.Enums.MyIdentityRolenames;

namespace PhDThesisPortal.Data
{
    public class ApplicationDbContextSeed
    {
        public static async Task SeedIdentityRolesAsync(RoleManager<MyIdentityRole> rolemanager)
        {
            foreach (RoleNames role in Enum.GetValues(typeof(RoleNames)))
            {
                string rolename = role.ToString();
                if (!await rolemanager.RoleExistsAsync(rolename))
                {
                    await rolemanager.CreateAsync(
                        new MyIdentityRole { Name = rolename });
                }
            }
        }


        public static async Task SeedIdentityUserAsync(UserManager<MyIdentityUser> usermanager)
        {
            MyIdentityUser user;

            user = await usermanager.FindByNameAsync("admin@gunikitchen.com");
            if (user == null)
            {
                user = new MyIdentityUser()
                {
                    UserName = "admin@gmail.com",
                    Email = "admin@gmail.com",
                    EmailConfirmed = true,
                    DisplayName = "The Admin User",
                    DateOfBirth = new DateTime(2000, 1, 1),
                    Gender = "Female",
                    IsAdminUser = true

                };
                await usermanager.CreateAsync(user, password: "Admin@123");
                await usermanager.AddToRolesAsync(user, new string[] {
                    RoleNames.Administrator.ToString()
                });
            }


        }

    }
}
