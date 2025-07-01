using CleanArchitectureBasics.CleanCode;
using CleanArchitectureBasics.DirtyCode;
using CleanArchitectureBasics.Services.EmailService;
using CleanArchitectureBasics.Services.OrderValidatorService;
using CleanArchitectureBasics.Services.PaymentService;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureBasics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CleanCodeOrderController : ControllerBase
    {
        private readonly CleanOrderService _orderService;

        public CleanCodeOrderController()
        {
            var emailService = new EmailService();
            var paymentService = new PaymentService();
            var validator = new OrderValidator();

            _orderService = new CleanOrderService(emailService, paymentService, validator);
        }

        [HttpPost]
        public IActionResult PlaceOrder([FromQuery] string email, [FromQuery] double amount)
        {
            _orderService.HandleOrder(email, amount);
            return Ok("Order processed using Clean Architecture.");
        }
    }
}
