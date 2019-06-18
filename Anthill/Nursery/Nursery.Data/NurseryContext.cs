using Microsoft.EntityFrameworkCore;
using Nursery.Data.Mappings;
using Nursery.Eggs;

namespace Nursery.Data
{
    public class NurseryContext : DbContext
    {
        public NurseryContext(DbContextOptions<NurseryContext> options) : base(options) {}

        public DbSet<Egg> Eggs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EggMapping());

            base.OnModelCreating(builder);
        }
    }
}
