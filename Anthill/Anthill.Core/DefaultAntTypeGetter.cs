using System.Collections.Generic;

namespace Anthill.Core
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
