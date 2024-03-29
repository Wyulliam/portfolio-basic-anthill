﻿using MediatR;
using NSubstitute;
using Nursery.Core;
using Nursery.Core.AntTypes.Creators;
using Nursery.Core.AntTypes.Getters;
using Nursery.Core.Eggs.Incubator;
using Nursery.Core.Factory;
using Nursery.Requests;
using Xunit;

namespace Nursery.Tests
{
    public class NurseryTests
    {
        private INursery _nursery;
        private IIncubator _incubator;
        private IAntTypeCreator _typeCreator;
        private IAntTypeGetter _typeGetter;
        private IMediator _mediator;
        private INurseryAbstractFactory _factory;

        public NurseryTests()
        {
            _incubator = Substitute.For<IIncubator>();
            _typeCreator = Substitute.For<IAntTypeCreator>();
            _typeGetter = Substitute.For<IAntTypeGetter>();
            _mediator = Substitute.For<IMediator>();

            _factory = Substitute.For<INurseryAbstractFactory>();
            _factory.BuildAntTypeCreator().Returns(_typeCreator);
            _factory.BuildAntTypeGetter().Returns(_typeGetter);
            _factory.BuildIncubator().Returns(_incubator);

            _nursery = new Core.Nursery(_factory, _mediator);
        }

        [Fact]
        public void should_incubate_eggs()
        {
            _nursery.IncubateEggs("Warrior", 5);

            _mediator
                .Received(1)
                .Send(Arg.Is<IncubationRequest>(it => it.Type == "Warrior" && it.Quantity == 5));
        }

        [Fact]
        public void should_create_new_type_of_ants()
        {
            _nursery.CreateType("Warrior");

            _typeCreator.Received(1).Create("Warrior");
        }

        [Fact]
        public void should_get_all_ant_types()
        {
            _nursery.GetAntTypes();

            _typeGetter.Received(1).Get();
        }
    }

}
