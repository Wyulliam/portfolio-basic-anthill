using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace Colony.Data
{
    public class ColonyContextFactory : IDesignTimeDbContextFactory<ColonyContext>
    {
        public ColonyContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ColonyContext>();
            optionsBuilder.UseSqlite("Data Source=Colony.db");

            return new ColonyContext(optionsBuilder.Options);
        }
    }
}
