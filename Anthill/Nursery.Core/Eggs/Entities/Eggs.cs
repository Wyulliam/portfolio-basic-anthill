using System;

namespace Nursery.Core.Eggs.Entities
{
    class Eggs
    {
        protected Eggs(){}

        public Eggs(string type, int quantity, DateTime generatedDate)
        {
            Type = type;
            Quantity = quantity;
            GeneratedDate = generatedDate;
        }
        public Guid Id { get; protected set; }
        public string Type { get; protected set; }
        public int Quantity { get; protected set; }
        public DateTime GeneratedDate { get; protected set; }
    }
}
