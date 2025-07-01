namespace CleanArchitectureBasics.Services.EmailService
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string to, string message)
        {
            Console.WriteLine($"Email sent to {to}: {message}");
        }
    }
}
