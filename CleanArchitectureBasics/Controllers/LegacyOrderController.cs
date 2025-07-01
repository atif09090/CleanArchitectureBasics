using CleanArchitectureBasics.DirtyCode;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureBasics.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LegacyOrderController : ControllerBase
    {
        private readonly OrderService _legacyOrderService;

        public LegacyOrderController()
        {
            _legacyOrderService = new OrderService();
        }

        [HttpPost("LegacyOrderService")]
        public IActionResult PlaceOrder([FromQuery] string email, [FromQuery] double amount)
        {
            _legacyOrderService.HandleOrder(email, amount);
            return Ok("Order processed using legacy (non-clean) approach.");
        }
    }
}
