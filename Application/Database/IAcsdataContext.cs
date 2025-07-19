using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.DataBase
{
    public interface IAcsdataContext
    {
        public DbSet<GeneralUserAccessLevel> GeneralUserAccessLevel { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Personal> Personals { get; set; }
        public int SaveChanges();
    }
}
