using MediatR;
using Nursery.Core.AntTypes.Creators;
using Nursery.Core.AntTypes.DTOs;
using Nursery.Core.AntTypes.Getters;
using Nursery.Core.Factory;
using Nursery.Requests;
using System.Collections.Generic;

namespace Nursery.Core
{
    class Nursery : INursery
    {
        private readonly IAntTypeCreator _typeCreator;
        private readonly IAntTypeGetter _antTypeGetter;
        private readonly IMediator _mediator;

        public Nursery(INurseryAbstractFactory factory, IMediator mediator)
        {
            _antTypeGetter = factory.BuildAntTypeGetter();
            _typeCreator = factory.BuildAntTypeCreator();

            _mediator = mediator;
        }

        public void CreateType(string type)
        {
            _typeCreator.Create(type);
        }

        public IReadOnlyCollection<AntTypeDTO> GetAntTypes()
        {
            return _antTypeGetter.Get();
        }

        public async void IncubateEggs(string type, int quantity)
        {
            await _mediator.Send(new IncubationRequest(type, quantity));
        }
    }
}
