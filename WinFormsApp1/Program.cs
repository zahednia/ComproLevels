using Application.DataBase;
using Persistence.Context;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;
using Application.Services.CopyUser;
using ApplicationCompro.Services.GetListDG;

namespace WinFormsApp1
{
    static class Program
    {
        public static IServiceProvider? ServiceProvider { get; set; }
        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddScoped<IDatabaseContext, DatabaseContext>();
            services.AddScoped<IUserAccessService, UserAccessService>();
            services.AddDbContext<DatabaseContext>();
            services.AddScoped<IGetListService, GetListService>();
            services.AddScoped<IGetListServiceMaghsad, GetListServiceMaghsad>();
            ServiceProvider = services.BuildServiceProvider();
        }

        [STAThread]
        static void Main()
        {
            ConfigureServices();
            var User = (IUserAccessService)ServiceProvider.GetService(typeof(IUserAccessService));
            var serviceGetList = (IGetListService)ServiceProvider.GetService(typeof(IGetListService));
            var serviceGetListMaghsad = (IGetListServiceMaghsad)ServiceProvider.GetService(typeof(IGetListServiceMaghsad));
            System.Windows.Forms.Application.Run(new frmMain(User , serviceGetList , serviceGetListMaghsad));

        }
    }
}
