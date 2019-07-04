using Nursery.Core.Eggs.Entities;
using Nursery.Core.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Nursery.Data.Repositories
{
    class EggRepository : IEggRepository
    {
        public void Create(Eggs eggs)
        {
            using (var context = new NurseryContext())
            {
                context.Eggs.Add(eggs);
                context.SaveChanges();
            }
        }

        public IReadOnlyCollection<Eggs> Get()
        {
            using(var context = new NurseryContext())
                return context.Eggs.ToList();
        }
    }
}
