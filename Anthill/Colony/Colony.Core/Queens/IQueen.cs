using Colony.Ants.Types;

namespace Colony.Queens
{
    interface IQueen
    {
        string CheckNursery();
        string CheckColony();
        string CheckCemetery();

        void LayEggs(IAntType type, int Quantity);

        void CreateType(string type);
        string CheckTypes();
    }
}