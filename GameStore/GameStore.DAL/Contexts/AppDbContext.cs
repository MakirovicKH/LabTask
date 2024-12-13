using GameStore.DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameStore.DAL.Contexts;

public class AppDbContext : IdentityDbContext<AppUser, IdentityRole, string>
{
    public DbSet<Game> Games { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<AppUser> Users { get; set; }


    public AppDbContext(DbContextOptions options) : base(options) { }
}
