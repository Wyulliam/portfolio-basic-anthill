using Colony.Ants.Types;
using System;

namespace Colony.Ants
{
    class Ant : IAnt
    {
        public IAntType Type { get; }
        public int MaxAge { get; }

        public Ant(IAntType type, int maxAge)
        {
            var random = new Random();

            Type = type;
            MaxAge = random.Next(30, 45);
        }

        public void Born()
        {
            throw new System.NotImplementedException();
        }

        public void Die()
        {
            throw new System.NotImplementedException();
        }
    }
}
