using Nursery.Core.AntTypes.DTOs;
using Nursery.Core.Repositories.Internal;
using System.Collections.Generic;

namespace Nursery.Core.AntTypes.Getters
{
    class DefaultAntTypeGetter : IAntTypeGetter
    {
        private readonly IAntTypeRepository _repository;

        public DefaultAntTypeGetter(IAntTypeRepository repository)
        {
            _repository = repository;
        }

        public IReadOnlyCollection<AntTypeDTO> Get()
        {
            return _repository.Get();
        }
    }
}
