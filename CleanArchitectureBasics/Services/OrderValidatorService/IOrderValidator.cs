namespace CleanArchitectureBasics.Services.OrderValidatorService
{
    public interface IOrderValidator
    {
        bool IsValid(string email, double amount);
    }
}
