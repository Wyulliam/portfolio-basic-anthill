using System.Collections.Generic;

namespace Nursery.Core.Repositories
{
    interface IEggRepository
    {
        void Create(Eggs.Entities.Eggs eggs);
        IReadOnlyCollection<Eggs.Entities.Eggs> Get();
    }
}
