using Domain.Entities;
using Microsoft.EntityFrameworkCore; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataBase
{
    public interface IDatabaseContext
    {
        public DbSet<GeneralUserAccessLevel> GeneralUserAccessLevel { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Personals> Personals { get; set; }
        public int SaveChanges();
    }
}
