﻿using MediatR;

namespace Nursery.Core.Eggs.Requests
{
    class EggHatchedRequest : IRequest
    {
        public EggHatchedRequest(string type, int quantity)
        {
            Type = type;
            Quantity = quantity;
        }

        public string Type { get; protected set; }
        public int Quantity { get; protected set; }
    }
}
