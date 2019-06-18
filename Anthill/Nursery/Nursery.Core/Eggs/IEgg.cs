using Colony.Ants.Types;
using System;

namespace Nursery.Eggs
{
    public interface IEgg
    {
        Guid Type { get; }
        DateTime DueDate { get; }

        void Hatch();
    }
}
