using System.Collections.Generic;
using Nursery.Core.AntTypes.Creators;
using Nursery.Core.AntTypes.Getters;
using Nursery.Core.Eggs.DTOs;
using Nursery.Core.Eggs.Generators;
using Nursery.Core.Eggs.Getters;

namespace Nursery.Core
{
    class Nursery : INursery
    {
        private readonly IEggGenerator _eggGenerator;
        private readonly IEggGetter _eggGetter;
        private readonly IAntTypeCreator _typeCreator;
        private readonly IAntTypeGetter _antTypeGetter;

        public Nursery(INurseryAbstractFactory factory)
        {
            _antTypeGetter = factory.BuildAntTypeGetter();
            _typeCreator = factory.BuildAntTypeCreator();
            _eggGenerator = factory.BuildEggGenerator();
            _eggGetter = factory.BuildEggGetter();
        }

        public void CreateType(string type)
        {
            _typeCreator.Create(type);
        }

        public void GetAntTypes()
        {
            _antTypeGetter.Get();
        }

        public IReadOnlyCollection<EggsDTO> GetEggs()
        {
            return _eggGetter.Get();
        }

        public void IncubateEggs(int quantity, string type)
        {
            _eggGenerator.Generate(quantity, type);
        }
    }
}
