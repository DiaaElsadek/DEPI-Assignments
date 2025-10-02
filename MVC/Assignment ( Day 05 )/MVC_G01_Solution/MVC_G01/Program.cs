using MVC_G01.Data.DbContexts;

namespace MVC_G01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            // Builder Design pattern >> self
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<CorporateDbContext>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action}/{id?}");

            app.Run();
        }
    }
}
