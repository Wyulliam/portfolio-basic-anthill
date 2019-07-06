using MediatR;

namespace Nursery.Core.Eggs.Requests
{
    class IncubationRequest : IRequest
    {
        public string Type { get; protected set; }
        public int Quantity { get; protected set; }

        public IncubationRequest(string type, int quantity)
        {
            Type = type;
            Quantity = quantity;
        }
    }
}
