using Nursery.Core.AntTypes.Creators;
using Nursery.Core.AntTypes.Getters;
using Nursery.Core.Eggs.Generators;
using Nursery.Core.Eggs.Getters;
using Nursery.Core.Eggs.Incubator;

namespace Nursery.Core.Factory
{
    interface INurseryAbstractFactory
    {
        IAntTypeCreator BuildAntTypeCreator();
        IAntTypeGetter BuildAntTypeGetter();
        IIncubator BuildIncubator();
    }
}
