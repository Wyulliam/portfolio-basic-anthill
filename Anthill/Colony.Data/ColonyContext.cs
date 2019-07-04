using Colony.Core.Ants.Entities;
using Microsoft.EntityFrameworkCore;

namespace Colony.Data
{
    class ColonyContext : DbContext
    {
        public DbSet<Ants> Ants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=colony.db");
        }
    }
}
