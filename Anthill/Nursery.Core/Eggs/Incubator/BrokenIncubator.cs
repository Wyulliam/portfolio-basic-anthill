using MediatR;
using Nursery.Core.Eggs.Generators;
using Nursery.Core.Eggs.Getters;

namespace Nursery.Core.Eggs.Incubator
{
    internal class BrokenIncubator : Incubator
    {
        public BrokenIncubator(IEggGenerator eggGenerator,
            IEggGetter eggGetter,
            IMediator mediator) : base(eggGenerator, eggGetter, mediator, 10)
        {
        }
    }
}
