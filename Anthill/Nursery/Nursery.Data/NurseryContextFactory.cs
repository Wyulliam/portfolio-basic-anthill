
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Nursery.Data
{
    class NurseryContextFactory : IDesignTimeDbContextFactory<NurseryContext>
    {
        public NurseryContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<NurseryContext>();
            optionsBuilder.UseSqlite("Data Source=Nursery.db");

            return new NurseryContext(optionsBuilder.Options);
        }
    }
}
