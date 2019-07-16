using MediatR;
using Nursery.Core.Eggs.Generators;
using Nursery.Core.Eggs.Getters;

namespace Nursery.Core.Eggs.Incubator
{

    internal class DefaultIncubator : Incubator
    {
        public DefaultIncubator(IEggGenerator eggGenerator, 
            IEggGetter eggGetter, 
            IMediator mediator) : base(eggGenerator, eggGetter, mediator, 5)
        {
        }
    }
}
