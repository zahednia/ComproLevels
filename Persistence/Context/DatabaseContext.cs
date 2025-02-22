using Application.DataBase;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=NewDbContact;Integrated Security=True;");
        }

        public DbSet<AccessLevel> AccessLevels { get; set; }
        public DbSet<ComproUser> ComproUsers { get; set; }
    }
}
