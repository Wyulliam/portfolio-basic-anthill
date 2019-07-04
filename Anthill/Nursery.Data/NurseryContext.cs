using Microsoft.EntityFrameworkCore;
using Nursery.Core.AntTypes.Entities;
using Nursery.Core.Eggs.Entities;

namespace Nursery.Data
{
    class NurseryContext : DbContext
    {
        public DbSet<AntType> AntTypes { get; set; }
        public DbSet<Eggs> Eggs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=nursery.db");
        }
    }
}
