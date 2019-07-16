using System;

namespace Nursery.Core.Eggs.Entities
{
    class Eggs
    {
        protected Eggs(){}

        public Eggs(string type, int quantity)
        {
            Type = type;
            Quantity = quantity;
            GeneratedDate = DateTime.Now;
        }
        public Guid Id { get; protected set; }
        public string Type { get; protected set; }
        public int Quantity { get; protected set; }
        public DateTime GeneratedDate { get; protected set; }
    }
}
