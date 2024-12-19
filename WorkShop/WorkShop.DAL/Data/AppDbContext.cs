using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using WorkShopModel.Models;

namespace WorkShop.DAL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<WorkShopItem> WorkshopModels { get; set; }
        public DbSet<Participant> Participants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WorkShopItem>().HasKey(w => w.Id);
            modelBuilder.Entity<Participant>().HasKey(p => p.Id);

            modelBuilder.Entity<WorkShopItem>()
                .HasMany(w => w.Participants)
                .WithOne(p => p.Workshop)
                .HasForeignKey(p => p.WorkshopId);
        }
    }
}
