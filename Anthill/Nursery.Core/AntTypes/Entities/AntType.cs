using System;

namespace Nursery.Core.AntTypes.Entities
{
    class AntType
    {
        protected AntType() { }

        public AntType(string type)
        {
            Type = type;
        }

        public Guid Id { get; protected set; }
        public string Type { get; protected set; }
    }
}
