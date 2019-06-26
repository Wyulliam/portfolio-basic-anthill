﻿using Anthill.Core;
using NSubstitute;
using Xunit;

namespace AntHill.Tests
{
    public class DefaultAntTypeGetterTests
    {
        private IAntTypeGetter _getter;
        private IAntTypeRepository _repository;

        public DefaultAntTypeGetterTests()
        {
            _repository = Substitute.For<IAntTypeRepository>();
            _getter = new DefaultAntTypeGetter(_repository);
        }

        [Fact]
        public void should_get_all_type_of_ants()
        {
            _getter.Get();

            _repository.Received(1).Get();
        }
    }
}
