using Domain.Features.Orders.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Features.Orders.DomainEvents
{
    public class BouquetOrderPlacedEventHandler : INotificationHandler<BouquetOrderPlacedEvent>
    {
        private readonly ILogger _logger;

        public BouquetOrderPlacedEventHandler(
            ILogger<BouquetOrderPlacedEventHandler> logger)
        {
            _logger = logger;
        }
        public Task Handle(BouquetOrderPlacedEvent notification, CancellationToken cancellationToken)
        {
            SendReminderToCalendarAt(notification.DueDate);

            return Task.CompletedTask;
        }

        private void SendReminderToCalendarAt(DateTime dueDate)
        {
            _logger.LogInformation("Event triggered successfully");
        }
    }
}
