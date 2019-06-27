using Nursery.Core.AntTypes.DTOs;
using Nursery.Core.Repositories;

namespace Nursery.Core.AntTypes.Creators
{
    class DefaultAntTypeCreator : IAntTypeCreator
    {
        private IAntTypeRepository _repository;

        public DefaultAntTypeCreator(IAntTypeRepository repository)
        {
            _repository = repository;
        }

        public void Create(string type)
        {
            var typeDTO = new AntTypeDTO(type);

            _repository.Create(typeDTO);
        }
    }
}
