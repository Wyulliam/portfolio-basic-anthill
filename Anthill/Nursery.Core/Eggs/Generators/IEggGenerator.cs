using Nursery.Core.Eggs.DTOs;
using System;

namespace Nursery.Core.Eggs.Generators
{
    interface IEggGenerator
    {
        void Generate(EggsDTO eggs);
    }
}
