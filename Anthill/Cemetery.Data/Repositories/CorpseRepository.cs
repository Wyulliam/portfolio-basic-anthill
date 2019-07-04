using Cemetery.Core.Corpses.Entities;
using Cemetery.Core.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Cemetery.Data.Repositories
{
    class CorpseRepository : ICorpseRepository
    {
        public IReadOnlyCollection<Corpses> Get()
        {
            using (var context = new CemeteryContext())
            {
                return context.Corpses.ToList();
            }
        }
    }
}
