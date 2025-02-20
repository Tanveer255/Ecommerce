using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if(!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Muhammad Tanveer",
                    Email = "tanveerofficial244@gmail.com",
                    UserName = "muhammad@tanveer.com",
                    Address = new Address
                    {
                        FirstName = "Muhammad",
                        LastName = "Tanveer",
                        Street = "17th Street",
                        City = "Burewala",
                        State = "Vehari",
                        Zipcode = "61100"
                    }
                };

                await userManager.CreateAsync(user, "Letmein123$");
            }
        }
    }
}