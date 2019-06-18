using Nursery.Eggs;
using System.Collections.Generic;

namespace Nursery
{
    interface INursery
    {
        IList<IEgg> Eggs { get; }
    }
}
