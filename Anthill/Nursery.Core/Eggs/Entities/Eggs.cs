using System;

namespace Nursery.Core.Eggs.Entities
{
    class Eggs
    {
        protected Eggs(){}

        public Eggs(string type, int quantity, DateTime dueDate)
        {
            Type = type;
            Quantity = quantity;
            DueDate = dueDate;
        }
        public Guid Id { get; protected set; }
        public string Type { get; protected set; }
        public int Quantity { get; protected set; }
        public DateTime DueDate { get; protected set; }
    }
}
