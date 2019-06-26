namespace Anthill.Core
{
    interface INursery
    {
        void IncubateEggs(int quantity, string type);
        void CreateType(string type);
        void GetAntTypes();
    }

    class Nursery : INursery
    {
        private readonly IEggGenerator _eggGenerator;
        private readonly IAntTypeCreator _typeCreator;
        private readonly IAntTypeGetter _antTypeGetter;

        public Nursery(IEggGenerator eggGenerator, IAntTypeCreator typeCreator, IAntTypeGetter antTypeGetter)
        {
            _antTypeGetter = antTypeGetter;
            _typeCreator = typeCreator;
            _eggGenerator = eggGenerator;
        }

        public void CreateType(string type)
        {
            _typeCreator.Create(type);
        }

        public void GetAntTypes()
        {
            _antTypeGetter.Get();
        }

        public void IncubateEggs(int quantity, string type)
        {
            _eggGenerator.Generate(quantity, type);
        }
    }
}
