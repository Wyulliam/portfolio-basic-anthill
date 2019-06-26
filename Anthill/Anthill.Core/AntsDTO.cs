namespace Anthill.Core
{
    class AntsDTO
    {
        public AntsDTO(int quantity, string type)
        {
            Quantity = quantity;
            Type = type;
        }

        public int Quantity { get; }
        public string Type { get; }

        public override string ToString()
        {
            return $"There are {Quantity} {Type} ants";
        }
    }
}
