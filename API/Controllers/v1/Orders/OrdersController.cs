using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.v1.Orders
{
    [Route("api/[controller]")]
    public class BouquetController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BouquetController(IMediator mediator)
            => _mediator = mediator;

        [HttpPost("order")]
        public async Task<IActionResult> PlaceBouquetOrder([FromBody] PlaceBouquetOrderRequest request)
        {
            var orderId = await _mediator.Send(request);
            return Ok(orderId);
        }
    }
}
