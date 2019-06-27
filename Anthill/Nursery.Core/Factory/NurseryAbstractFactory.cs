using Nursery.Core.AntTypes.Creators;
using Nursery.Core.AntTypes.Getters;
using Nursery.Core.Eggs.Generators;
using Nursery.Core.Eggs.Getters;
using Nursery.Core.Repositories;

namespace Nursery.Core.Factory
{
    class NurseryAbstractFactory : INurseryAbstractFactory
    {
        private IAntTypeRepository _antTypeRepository;
        private IEggRepository _eggRepository;

        public NurseryAbstractFactory(IAntTypeRepository repository, IEggRepository eggRepository)
        {
            _eggRepository = eggRepository;
            _antTypeRepository = repository;
        }

        public IAntTypeCreator BuildAntTypeCreator()
        {
            return new DefaultAntTypeCreator(_antTypeRepository);
        }

        public IAntTypeGetter BuildAntTypeGetter()
        {
            return new DefaultAntTypeGetter(_antTypeRepository);
        }

        public IEggGenerator BuildEggGenerator()
        {
            return new DefaultEggGenerator(_eggRepository);
        }

        public IEggGetter BuildEggGetter()
        {
            return new DefaultEggGetter(_eggRepository);
        }
    }
}
