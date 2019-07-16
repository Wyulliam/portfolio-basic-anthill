using MediatR;
using NSubstitute;
using Nursery.Core.Eggs.Handlers;
using Nursery.Core.Eggs.Incubator;
using Nursery.Core.Factory;
using Nursery.Requests;
using System.Threading;
using Xunit;

namespace Nursery.Tests.Incubators
{
    public class IncubationHandlerTests
    {
        private IRequestHandler<IncubationRequest> _handler;
        private IIncubatorFactory _incubatorFactory;

        public IncubationHandlerTests()
        {
            _incubatorFactory = Substitute.For<IIncubatorFactory>();
            _handler = new IncubationHandler(_incubatorFactory);
        }

        [Fact]
        public void should_start_the_incubator()
        {
            var request = new IncubationRequest("Warrior", 5);

            var incubator = Substitute.For<IIncubator>();
            _incubatorFactory.Build().Returns(incubator);
            
            _handler.Handle(request, new CancellationToken());

            _incubatorFactory.Received(1).Build();
            incubator.Received(1).Incubate(Arg.Is<IncubationRequest>(it => it.Type == "Warrior" && it.Quantity == 5));
        }
    }
}
