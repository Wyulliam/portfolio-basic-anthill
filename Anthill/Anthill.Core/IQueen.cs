using System.Collections.Generic;

namespace Anthill.Core
{
    public interface IQueen
    {
        string CreateType(string type);
        IReadOnlyCollection<string> GetAntTypes();
        string LayEggs(int quantity, string type);
        string CheckAnthill();
    }
}
