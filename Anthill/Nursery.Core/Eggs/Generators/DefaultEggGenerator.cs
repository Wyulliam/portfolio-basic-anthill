using Nursery.Core.Eggs.DTOs;
using Nursery.Core.Repositories.Internal;

namespace Nursery.Core.Eggs.Generators
{
    class DefaultEggGenerator : IEggGenerator
    {
        private IEggRepository _repository;

        public DefaultEggGenerator(IEggRepository repository)
        {
            _repository = repository;
        }

        public void Generate(int quantity, string type)
        {
            var eggs = new EggsDTO(quantity, type);

            _repository.Create(eggs);
        }
    }
}
