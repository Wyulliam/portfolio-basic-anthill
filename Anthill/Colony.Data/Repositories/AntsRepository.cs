using Colony.Core.Ants.DTOs;
using Colony.Core.Ants.Entities;
using Colony.Core.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Colony.Data.Repositories
{
    class AntsRepository : IAntsRepository
    {
        public IReadOnlyCollection<Ants> Get()
        {
            using(var context = new ColonyContext())
                return context.Ants.ToList();
        }
    }
}
