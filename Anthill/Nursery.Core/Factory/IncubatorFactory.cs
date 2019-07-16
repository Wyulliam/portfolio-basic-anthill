using MediatR;
using Nursery.Core.Eggs.Generators;
using Nursery.Core.Eggs.Getters;
using Nursery.Core.Eggs.Incubator;
using Nursery.Core.Repositories;
using System;

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
            var random = new Random();
            var incubatorChoice = random.Next(1, 3);
            switch (incubatorChoice)
            {
                case 1:
                    return new DefaultIncubator(
                        BuildEggGenerator(),
                        BuildEggGetter(),
                        _mediator
                        );
                case 2:
                    return new TurboIncubator(
                        BuildEggGenerator(),
                        BuildEggGetter(),
                        _mediator
                        );
                case 3:
                    return new BrokenIncubator(
                        BuildEggGenerator(),
                        BuildEggGetter(),
                        _mediator
                        );
                default:
                    return new DefaultIncubator(
                        BuildEggGenerator(),
                        BuildEggGetter(),
                        _mediator
                        );
            }
            
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
