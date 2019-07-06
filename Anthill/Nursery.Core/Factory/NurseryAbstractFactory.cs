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
        private IAntTypeRepository _antTypeRepository;
        private IEggRepository _eggRepository;
        private IMediator _mediator;

        public NurseryAbstractFactory(IAntTypeRepository repository, IEggRepository eggRepository, IMediator mediator)
        {
            _mediator = mediator;
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

        public IIncubator BuildIncubator()
        {
            return new DefaultIncubator(
                BuildEggGenerator(),
                BuildEggGetter(),
                _mediator
                );
        }

        private IEggGenerator BuildEggGenerator()
        {
            return new DefaultEggGenerator(_eggRepository);
        }

        private IEggGetter BuildEggGetter()
        {
            return new DefaultEggGetter(_eggRepository);
        }
    }
}
