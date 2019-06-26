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

        public Nursery(IEggGenerator eggGenerator, IEggGetter eggGetter, IAntTypeCreator typeCreator, IAntTypeGetter antTypeGetter)
        {
            _antTypeGetter = antTypeGetter;
            _typeCreator = typeCreator;
            _eggGenerator = eggGenerator;
            _eggGetter = eggGetter;
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
