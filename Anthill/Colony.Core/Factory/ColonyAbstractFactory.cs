using Colony.Core.Ants.Getters;
using Colony.Core.Repositories;

namespace Colony.Core.Factory
{
    class ColonyAbstractFactory : IColonyAbstractFactory
    {
        private IAntsRepository _antsRepository;

        public ColonyAbstractFactory(IAntsRepository antsRepository)
        {
            _antsRepository = antsRepository;
        }

        public IAntsGetter BuildAntsGetter()
        {
            return new DefaultAntsGetter(_antsRepository);
        }
    }
}
