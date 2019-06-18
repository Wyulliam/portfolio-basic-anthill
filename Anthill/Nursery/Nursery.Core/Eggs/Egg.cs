using Colony.Ants.Types;
using Infra.Common;
using System;

namespace Nursery.Eggs
{
    public class Egg : IEntity, IEgg
    {
        public Guid Id { get; protected set; }
        public Guid Type { get; private set; }
        public DateTime DueDate { get; private set; }


        public Egg(Guid type)
        {
            Type = type;

            var random = new Random();

            DueDate = DateTime.Now.AddSeconds(random.Next(3, 6));
        }

        public void Hatch()
        {
            throw new NotImplementedException();
        }
    }
}
