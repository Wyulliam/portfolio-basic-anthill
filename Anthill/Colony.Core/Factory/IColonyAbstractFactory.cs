
using Colony.Core.Ants.Getters;

namespace Colony.Core.Factory
{
    interface IColonyAbstractFactory
    {
        IAntsGetter BuildAntsGetter();
    }
}
