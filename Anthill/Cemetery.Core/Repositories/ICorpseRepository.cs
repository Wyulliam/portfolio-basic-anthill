using System.Collections.Generic;

namespace Cemetery.Core.Repositories
{
    interface ICorpseRepository
    {
        IReadOnlyCollection<Corpses.Entities.Corpses> Get();
    }
}
