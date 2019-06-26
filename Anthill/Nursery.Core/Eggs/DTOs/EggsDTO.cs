namespace Nursery.Core.Eggs.DTOs
{
    public class EggsDTO
    {
        public EggsDTO(int quantity, string type)
        {
            Quantity = quantity;
            Type = type;
        }

        public int Quantity { get; }
        public string Type { get; }

        public override string ToString()
        {
            return $"There are {Quantity} {Type} eggs";
        }
    }
}
