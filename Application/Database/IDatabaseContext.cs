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
        public DbSet<AccessLevel> AccessLevels { get; set; }
        public DbSet<ComproUser> ComproUsers { get; set; }
        public int SaveChanges();
    }
}
