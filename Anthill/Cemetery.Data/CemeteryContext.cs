using Cemetery.Core.Corpses.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cemetery.Data
{
    class CemeteryContext : DbContext
    {
        public DbSet<Corpses> Corpses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=corpses.db");
        }
    }
}
