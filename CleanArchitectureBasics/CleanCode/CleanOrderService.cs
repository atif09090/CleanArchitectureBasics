using System.ComponentModel.DataAnnotations;
using CleanArchitectureBasics.Services.EmailService;
using CleanArchitectureBasics.Services.OrderValidatorService;
using CleanArchitectureBasics.Services.PaymentService;

namespace CleanArchitectureBasics.CleanCode
{
    public class CleanOrderService
    {
        private readonly IEmailService _emailService;
        private readonly IPaymentService _paymentService;
        private readonly IOrderValidator _validator;

        public CleanOrderService(IEmailService emailService, IPaymentService paymentService, IOrderValidator validator)
        {
            _emailService = emailService;
            _paymentService = paymentService;
            _validator = validator;
        }

        public void HandleOrder(string customerEmail, double amount)
        {
            if (!_validator.IsValid(customerEmail, amount))
            {
                Console.WriteLine("Invalid order.");
                return;
            }

            _paymentService.ProcessPayment(amount);
            _emailService.SendEmail(customerEmail, "Thank you for your order!");
        }
    }
}
