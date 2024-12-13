using Microsoft.AspNetCore.Identity;

namespace GameStore.DAL.Models;

public class AppUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }   
    public  ICollection<Comment> Comments { get; set; }
}
