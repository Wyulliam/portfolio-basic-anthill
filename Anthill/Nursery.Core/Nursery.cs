using System.Collections.Generic;
using Nursery.Core.AntTypes.Creators;
using Nursery.Core.AntTypes.DTOs;
using Nursery.Core.AntTypes.Getters;
using Nursery.Core.Eggs.DTOs;
using Nursery.Core.Eggs.Generators;
using Nursery.Core.Eggs.Getters;
using Nursery.Core.Eggs.Incubator;
using Nursery.Core.Factory;

namespace Nursery.Core
{
    class Nursery : INursery
    {
        private readonly IIncubator _incubator;
        private readonly IAntTypeCreator _typeCreator;
        private readonly IAntTypeGetter _antTypeGetter;

        public Nursery(INurseryAbstractFactory factory)
        {
            _incubator = factory.BuildIncubator();
            _antTypeGetter = factory.BuildAntTypeGetter();
            _typeCreator = factory.BuildAntTypeCreator();
        }

        public void CreateType(string type)
        {
            _typeCreator.Create(type);
        }

        public IReadOnlyCollection<AntTypeDTO> GetAntTypes()
        {
            return _antTypeGetter.Get();
        }

        public IReadOnlyCollection<EggsDTO> GetEggs()
        {
            return _incubator.GetEggs();
        }

        public void IncubateEggs(string type, int quantity)
        {
            //_incubator.Incubate(new EggsDTO(type, quantity));
        }
    }
}
