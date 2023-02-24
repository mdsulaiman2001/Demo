using Microsoft.EntityFrameworkCore;
using SwordLMS.Web.Data;
using SwordLMS.Web.Models;


namespace SwordLMS.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<SwordLMSContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("SwordLMSContext")));


            builder.Services.AddScoped<SwordLMSContext>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=User}/{action=SignUp}/{id?}");

            app.Run();
        }
    }
}