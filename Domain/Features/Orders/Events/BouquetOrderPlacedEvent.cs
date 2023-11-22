using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Features.Orders.Events
{
    public class BouquetOrderPlacedEvent : INotification
    {
        public Guid OrderId { get; init; }
        public DateTime DueDate { get; init; }
    }
}
