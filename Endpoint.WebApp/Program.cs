using Application.DataBase;
using Application.Services.CopyUser;
using ApplicationCompro.Services.GetListDG;
using ApplicationCompro.Services.ShowName;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;

namespace Endpoint.WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Add services to the container.
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddScoped<IAcsdataContext, AcsdataContext>();
            builder.Services.AddScoped<IUserAccessService, UserAccessService>();
            builder.Services.AddScoped<IGetListService, GetListService>();
            builder.Services.AddScoped<IShowName, ShowNameService>();
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AcsdataContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
