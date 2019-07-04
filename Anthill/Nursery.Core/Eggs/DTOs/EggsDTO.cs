namespace Nursery.Core.Eggs.DTOs
{
    public class EggsDTO
    {
        public EggsDTO(string type, int quantity)
        {
            Type = type;
            Quantity = quantity;
        }

        public string Type { get; }
        public int Quantity { get; }

        public override string ToString()
        {
            return $"There are {Quantity} {Type} eggs";
        }
    }
}
