using System;
using System.Collections.Generic;
using System.Text;

namespace Cemetery.Core.Corpses.Entities
{
    class Corpses
    {
        protected Corpses(){}

        public Corpses(string type, int quantity)
        {
            Type = type;
            Quantity = quantity;
        }

        public Guid Id { get; protected set; }
        public string Type { get; protected set; }
        public int Quantity { get; protected set; }
    }
}
