using Cemetery.Core.Corpses.Getters;

namespace Cemetery.Core.Factory
{
    interface ICemeteryAbstractFactory
    {
        ICorpseGetter BuildCorpseGetter();
    }
}
