using MediatR;
using Nursery.Core.Eggs.Generators;
using Nursery.Core.Eggs.Getters;
using Nursery.Core.Eggs.Incubator;
using Nursery.Core.Repositories;

namespace Nursery.Core.Factory
{
    class IncubatorFactory : IIncubatorFactory
    {
        private IEggRepository _eggRepository;
        private IMediator _mediator;

        public IncubatorFactory(IEggRepository eggRepository, IMediator mediator)
        {
            _eggRepository = eggRepository;
            _mediator = mediator;
        }

        public IIncubator Build()
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
