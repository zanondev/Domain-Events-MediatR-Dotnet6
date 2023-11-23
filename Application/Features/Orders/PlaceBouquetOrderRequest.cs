using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Orders
{
    public class PlaceBouquetOrderRequest : IRequest<Guid>
    {
        public DateTime DueDate { get; init; }
        public int FlowersCount { get; init; }
        public string? Note { get; init; }
    }
}
