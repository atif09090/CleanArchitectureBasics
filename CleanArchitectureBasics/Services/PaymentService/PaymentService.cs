namespace CleanArchitectureBasics.Services.PaymentService
{
    public class PaymentService : IPaymentService
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Payment of ${amount} processed successfully.");
        }
    }
}
