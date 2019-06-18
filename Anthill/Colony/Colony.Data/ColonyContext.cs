using Colony.Ants.Types;
using Colony.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Colony.Data
{
    public class ColonyContext : DbContext
    {
        public ColonyContext(DbContextOptions<ColonyContext> options) : base(options){}

        public DbSet<AntType> AntTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AntTypeMapping());

            base.OnModelCreating(builder);
        }
    }
}
