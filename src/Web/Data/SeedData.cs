using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Data.Entities;

namespace Web.Data
{
    public static class SeedData
    {
        public static async Task Seed(IServiceProvider service)
        {
            var userManager = service.GetService(typeof(UserManager<AppUser>)) as UserManager<AppUser>;
            var roleManager = service.GetService(typeof(RoleManager<AppRole>)) as RoleManager<AppRole>;
            if (!await roleManager.RoleExistsAsync("admin"))
            {
                var role = new AppRole
                {
                    Name = "Admin"
                };
                var result = await roleManager.CreateAsync(role);
            }
            if (await userManager.FindByNameAsync("admin")==null)
            {
                var user = new AppUser
                {
                    UserName = "Krv",
                    Email = "kr.inmotion@gmail.com"
                };
                if( (await userManager.CreateAsync(user, "P@ssw0rd!")).Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "admin");
                }
            }
        }
    }
}
