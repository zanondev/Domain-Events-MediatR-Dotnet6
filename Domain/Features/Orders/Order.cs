using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Features.Orders
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime DueDate { get; set; }
        public int FlowersCount { get; set; }
        public string? Note { get; set; }
    }
}
