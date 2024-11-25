using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ProniaDL.Helpers;
using ProniaDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaDL.Contexts
{
    public class ProniaDBContext : DbContext
    {
        public DbSet<SliderItem> SliderItems { get; set; }  
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(SqlHelper.GetConnectionString());
            base.OnConfiguring(optionsBuilder);
        }
    }
}
