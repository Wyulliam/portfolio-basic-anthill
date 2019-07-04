namespace Colony.Core.Ants.DTOs
{
    public class AntsDTO
    {
        public AntsDTO(string type, int quantity)
        {
            Type = type;
            Quantity = quantity;
        }

        public string Type { get; }
        public int Quantity { get; }

        public override string ToString()
        {
            return $"There are {Quantity} {Type} ants";
        }
    }
}
