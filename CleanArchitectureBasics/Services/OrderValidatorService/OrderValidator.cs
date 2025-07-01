namespace CleanArchitectureBasics.Services.OrderValidatorService
{
    public class OrderValidator : IOrderValidator
    {
        public bool IsValid(string email, double amount)
        {
            return !string.IsNullOrEmpty(email) && amount > 0;
        }
    }
}
