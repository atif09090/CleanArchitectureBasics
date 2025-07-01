namespace CleanArchitectureBasics.Services.EmailService
{
    public interface IEmailService
    {
        void SendEmail(string to, string message);
    }
}
