using Colony.Ants;
using Colony.Queens;
using System.Collections.Generic;

namespace Colony
{
    interface IColony
    {
        IQueen Queen { get; }
        IList<IAnt> Ants { get; }
    }
}
