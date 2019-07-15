using FluentAssertions;
using MediatR;
using NSubstitute;
using Nursery.Core.Eggs.Generators;
using Nursery.Core.Eggs.Getters;
using Nursery.Core.Eggs.Incubator;
using Nursery.Requests;
using Xunit;

namespace Nursery.Tests
{
    public class DefaultIncubatorTests
    {
        private IIncubator _incubator;
        private IEggGenerator _eggGenerator;
        private IEggGetter _eggGetter;
        private IMediator _mediator;

        public DefaultIncubatorTests()
        {
            _eggGenerator = Substitute.For<IEggGenerator>();
            _eggGetter = Substitute.For<IEggGetter>();
            _mediator = Substitute.For<IMediator>();
            _incubator = new DefaultIncubator(_eggGenerator, _eggGetter, _mediator);
        }

        [Fact]
        public void should_incubate_eggs_in_10_seconds()
        {
            _incubator.SecondsToIncubate.Should().Be(10);
        }

        [Fact]
        public void should_give_life_to_new_ants_after_incubating()
        {
          _incubator.Incubate(new IncubationRequest("Warrior", 5)).Wait();

           _mediator.Received(1).Send(Arg.Is<EggHatchedRequest>(a => a.Type == "Warrior" && a.Quantity == 5));
        }

        [Fact]
        public void should_get_all_eggs_incubating()
        {
            _incubator.GetEggs();

            _eggGetter.Received(1).Get();
        }
    }
}
