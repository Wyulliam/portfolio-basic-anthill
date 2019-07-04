using System;

namespace Colony.Core.Ants.Entities
{
    class Ants
    {
        protected Ants(){}

        public Ants(string type, int quantity)
        {
            Type = type;
            Quantity = quantity;
        }

        public Guid Id { get; protected set; }
        public string Type { get; protected set; }
        public int Quantity { get; protected set; }
    }
}
