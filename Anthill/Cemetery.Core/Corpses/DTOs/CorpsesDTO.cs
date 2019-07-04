namespace Cemetery.Core.Corpses.DTOs
{
    public class CorpsesDTO
    {
        public CorpsesDTO(string type, int quantity)
        {
            Type = type;
            Quantity = quantity;
        }

        public string Type { get; }
        public int Quantity { get; }

        public override string ToString()
        {
            return $"There are {Quantity} dead {Type} ants";
        }
    }
}
