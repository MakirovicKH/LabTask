using Ecommerce.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DAL.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<OrderItem>()
               .HasOne(o => o.Order)
               .WithMany(m => m.OrderItems)
               .HasForeignKey(o => o.OrderId)
               .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<OrderItem>()
               .HasOne(o => o.Product)
               .WithMany(m => m.OrderItems)
               .HasForeignKey(o => o.ProductId)
               .OnDelete(DeleteBehavior.Cascade);

        }
    }
}