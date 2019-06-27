using Nursery.Core.AntTypes.Creators;
using Nursery.Core.AntTypes.Getters;
using Nursery.Core.Eggs.Generators;
using Nursery.Core.Eggs.Getters;

namespace Nursery.Core.Factory
{
    interface INurseryAbstractFactory
    {
        IEggGenerator BuildEggGenerator();
        IEggGetter BuildEggGetter();
        IAntTypeCreator BuildAntTypeCreator();
        IAntTypeGetter BuildAntTypeGetter();
    }
}
