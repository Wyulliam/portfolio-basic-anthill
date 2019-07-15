using Nursery.Core.Eggs.Incubator;

namespace Nursery.Core.Factory
{
    interface IIncubatorFactory
    {
        IIncubator Build();
    }
}
