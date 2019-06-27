namespace Anthill.Core
{
    public interface IQueen
    {
        void CreateType(string type);
        void GetAntTypes();
        void LayEggs(int quantity, string type);
        void CheckColony();
    }
}
