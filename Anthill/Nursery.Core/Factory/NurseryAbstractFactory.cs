using MediatR;
using Nursery.Core.AntTypes.Creators;
using Nursery.Core.AntTypes.Getters;
using Nursery.Core.Eggs.Generators;
using Nursery.Core.Eggs.Getters;
using Nursery.Core.Eggs.Incubator;
using Nursery.Core.Repositories;

namespace Nursery.Core.Factory
{
    class NurseryAbstractFactory : INurseryAbstractFactory
    {
        private IIncubatorFactory _incubatorFactory;
        private IAntTypeRepository _antTypeRepository;

        public NurseryAbstractFactory(IAntTypeRepository repository, 
            IIncubatorFactory incubatorFactory)
        {
            _antTypeRepository = repository;
            _incubatorFactory = incubatorFactory;
        }

        public IAntTypeCreator BuildAntTypeCreator()
        {
            return new DefaultAntTypeCreator(_antTypeRepository);
        }

        public IAntTypeGetter BuildAntTypeGetter()
        {
            return new DefaultAntTypeGetter(_antTypeRepository);
        }

        public IIncubator BuildIncubator()
        {
            return _incubatorFactory.Build();
        }
    }
}
