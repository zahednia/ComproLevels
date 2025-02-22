using Application.DataBase;
using Persistence.Context;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;
using Application.Services.CopyUser;

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

            ServiceProvider = services.BuildServiceProvider();
        }

        [STAThread]
        static void Main()
        {
            ConfigureServices();
            var serviceGetList = (IUserAccessService)ServiceProvider.GetService(typeof(IUserAccessService));
            System.Windows.Forms.Application.Run(new frmMain(serviceGetList));

        }
    }
}
