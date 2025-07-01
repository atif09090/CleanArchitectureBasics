# 🛒 Clean Code vs Non-Clean Code – Real-World: Order Processing

## 🧪 Scenario
Simulating an order handling process in an e-commerce application.

### ❌ Non-Clean Code
All logic crammed into one method:
- No abstractions
- No testing
- Not reusable

### ✅ Clean Code
Breaks logic into:
- `OrderValidator`
- `PaymentService`
- `EmailService`

Each one can be mocked/tested individually.

---

Run the project using:

```bash
dotnet run
