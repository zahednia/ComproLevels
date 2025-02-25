﻿using Application.DataBase;
using Persistence.Context;
using Microsoft.Extensions.DependencyInjection;
using Application.Services.CopyUser;
using ApplicationCompro.Services.GetListDG;
using ApplicationCompro.Services.ShowName;

namespace WinFormsApp1
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }
        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddScoped<IDatabaseContext, DatabaseContext>();
            services.AddScoped<IUserAccessService, UserAccessService>();
            services.AddDbContext<DatabaseContext>();
            services.AddScoped<IGetListService, GetListService>();
            services.AddScoped<IShowName, ShowNameService>();
            services.AddScoped<IGetListServiceMaghsad, GetListServiceMaghsad>();
            ServiceProvider = services.BuildServiceProvider();
        }
        [STAThread]
        static void Main()
        {
            ConfigureServices();
            var serviceAdd = (IShowName)Program.ServiceProvider.GetService(typeof(IShowName));
            var User = (IUserAccessService)ServiceProvider.GetService(typeof(IUserAccessService));
            var serviceGetList = (IGetListService)ServiceProvider.GetService(typeof(IGetListService));
            var serviceGetListMaghsad = (IGetListServiceMaghsad)ServiceProvider.GetService(typeof(IGetListServiceMaghsad));
            System.Windows.Forms.Application.Run(new frmMain(User , serviceGetList , serviceGetListMaghsad, serviceAdd ));
        }
    }
}
