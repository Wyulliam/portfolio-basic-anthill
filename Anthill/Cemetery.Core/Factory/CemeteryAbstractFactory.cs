using Cemetery.Core.Corpses.Getters;
using Cemetery.Core.Repositories;

namespace Cemetery.Core.Factory
{
    class CemeteryAbstractFactory : ICemeteryAbstractFactory
    {
        private ICorpseRepository _repository;

        public CemeteryAbstractFactory(ICorpseRepository repository)
        {
            _repository = repository;
        }

        public ICorpseGetter BuildCorpseGetter()
        {
            return new DefaultCorpseGetter(_repository);
        }
    }
}
