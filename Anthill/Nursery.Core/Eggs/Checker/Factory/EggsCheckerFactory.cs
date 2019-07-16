using Nursery.Core.Factory;

namespace Nursery.Core.Eggs.Checker.Factory
{
    class EggsCheckerFactory : IEggsCheckerFactory
    {
        private IIncubatorFactory _incubatorFactory;

        public EggsCheckerFactory(IIncubatorFactory incubatorFactory)
        {
            _incubatorFactory = incubatorFactory;
        }

        public IEggsChecker Build()
        {
            return new DefaultEggsChecker(_incubatorFactory);
        }
    }
}
