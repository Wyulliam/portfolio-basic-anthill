using System;
using System.Collections.Generic;
using System.Text;

namespace Nursery.Core.AntTypes.DTOs
{
    public class AntTypeDTO
    {
        public AntTypeDTO(string type)
        {
            Type = type;
        }

        public string Type { get; private set; }
    }
}
