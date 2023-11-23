using Domain.Features.Orders.Events;
using FluentValidation;
using MediatR;

namespace Application.Features.Orders.Handlers
{
    public class PlaceBouquetOrderRequestHandler
    {
        public class Command : IRequest<Guid>
        {
            public Guid OrderId { get; set; }
            public DateTime DueDate { get; set; }

            public FluentValidation.Results.ValidationResult Validate()
            {
                return new Validator().Validate(this);
            }

            public class Validator : AbstractValidator<Command>
            {
                public Validator()
                {
                    RuleFor(ia => ia.OrderId).NotEmpty();
                    RuleFor(ia => ia.DueDate).NotEmpty();
                }
            }
        }

        public class Handler : IRequestHandler<Command, Guid>
        {
            private readonly IPublisher _publisher;

            public Handler(
               IPublisher publisher)
            {
                _publisher = publisher;
            }
            public async Task<Guid> Handle(Command request, CancellationToken cancellationToken)
            {
                await PublishDomainEvent(request.OrderId, request.DueDate);

                return request.OrderId;
            }

            private async Task PublishDomainEvent(Guid orderId, DateTime dueDate)
            {
                await _publisher.Publish(new BouquetOrderPlacedEvent
                {
                    OrderId = orderId,
                    DueDate = dueDate
                });
            }
        }
    }
}
