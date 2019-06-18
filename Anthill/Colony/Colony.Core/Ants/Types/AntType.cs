using Infra.Common;
using System;

namespace Colony.Ants.Types
{
    public class AntType : IEntity, IAntType
    {
        public Guid Id { get; protected set; }
        public string Type { get; }


        public AntType(string type)
        {
            Type = type;
        }
    }
}
