using Nursery.Eggs;
using System.Collections.Generic;

namespace Nursery
{
    class Nursery : INursery
    {
        public IList<IEgg> Eggs { get; }

        public Nursery()
        {
            Eggs = new List<IEgg>();
        }
    }
}
