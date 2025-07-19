using Application.DataBase;
using Application.Services.CopyUser;
using ApplicationCompro.Services.GetListDG;
using ApplicationCompro.Services.ShowName;
using Persistence.Context;

namespace Endpoint.WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddScoped<IDatabaseContext, DatabaseContext>();
            builder.Services.AddScoped<IUserAccessService, UserAccessService>();
            builder.Services.AddDbContext<DatabaseContext>();
            builder.Services.AddScoped<IGetListService, GetListService>();
            builder.Services.AddScoped<IShowName, ShowNameService>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
