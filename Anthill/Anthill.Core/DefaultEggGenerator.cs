namespace Anthill.Core
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
