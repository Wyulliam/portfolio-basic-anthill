using Colony.Ants;
using Colony.Queens;
using System.Collections.Generic;

namespace Colony
{
    class Colony : IColony
    {
        public IQueen Queen { get; }
        public IList<IAnt> Ants { get; }

        public Colony(IQueen queen)
        {
            Queen = queen;
            Ants = new List<IAnt>();
        }
    }
}
