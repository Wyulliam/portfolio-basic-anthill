namespace Cemetery.Core.Corpses.DTOs
{
    public class CorpsesDTO
    {
        public CorpsesDTO(int quantity, string type)
        {
            Quantity = quantity;
            Type = type;
        }

        public int Quantity { get; }
        public string Type { get; }

        public override string ToString()
        {
            return $"There are {Quantity} dead {Type} ants";
        }
    }
}
