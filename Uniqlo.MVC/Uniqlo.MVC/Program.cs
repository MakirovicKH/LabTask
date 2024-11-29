using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;
using Uniqlo.DAL.Contexts;
using Uniqlo.MVC;

namespace Uniqlo.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<UniqloDbContext>(option=>
            option.UseSqlServer(builder.Configuration.GetConnectionString("MsSql")));

            var app = builder.Build();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");


            app.Run();
        }
    }
}
