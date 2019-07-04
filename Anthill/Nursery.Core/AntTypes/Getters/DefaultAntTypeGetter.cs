using Nursery.Core.AntTypes.DTOs;
using Nursery.Core.Repositories;
using System.Collections.Generic;
using System.Linq;

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
            return _repository.Get().Select(s => new AntTypeDTO(s.Type)).ToList();
        }
    }
}
