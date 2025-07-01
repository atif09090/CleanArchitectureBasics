
namespace CleanArchitectureBasics.DirtyCode
{
    public class OrderService
    {
        public void HandleOrder(string customerEmail, double amount)
        {
            if (string.IsNullOrEmpty(customerEmail) || amount <= 0)
            {
                Console.WriteLine("Invalid order");
                return;
            }

            Console.WriteLine($"Processing payment of ${amount}...");
            // Fake payment logic
            Console.WriteLine("Payment successful!");

            Console.WriteLine($"Sending confirmation email to {customerEmail}...");
            // Fake email logic
            Console.WriteLine("Email sent!");
        }
    }
}
