using System.Threading.Tasks;
using LibraryManagement.Entity;
using Microsoft.AspNetCore.Identity;

namespace LibraryManagement.Percistance
{
    public class DataSeedingInitializer
    {
        public static async Task UserAndRoleSeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager){
            string[] roles = {"Admin", "Student"};
            foreach(var role in roles){
                var roleExist = await roleManager.RoleExistsAsync(role);
                if(!roleExist){
                    IdentityResult result = await roleManager.CreateAsync(new IdentityRole(role));
                }

            }

            if(userManager.FindByEmailAsync("venuhegde1@gmail.com").Result == null){
                ApplicationUser user = new ApplicationUser {
                   UserName = "venuhegde1@gmail.com",
                   Email = "venuhegde1@gmail.com"
                };
                IdentityResult identityResult =await userManager.CreateAsync(user, "Password1");
                if(identityResult.Succeeded){
                    userManager.AddToRoleAsync(user, "Admin").Wait();


                }
            }

            if(userManager.FindByEmailAsync("venuhegde2@gmail.com").Result == null){
                ApplicationUser user = new ApplicationUser {
                   UserName = "venuhegde2@gmail.com",
                   Email = "venuhegde2@gmail.com"
                };
                IdentityResult identityResult =await userManager.CreateAsync(user, "Password1");
                if(identityResult.Succeeded){
                    userManager.AddToRoleAsync(user, "Student").Wait();
                    

                }
            }

        }
    }
}