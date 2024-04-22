using CashFlow.Communication.Requests;
using FluentValidation;

namespace CashFlow.Application.UseCases.Expenses.Register;

public class RegisterExpenseValidator : AbstractValidator<RequestRegisterExpenseJson>
{
    public RegisterExpenseValidator()
    {
        RuleFor(expense => expense.Title).NotEmpty().WithMessage("O titulo é obrigatório!");
        RuleFor(expense => expense.Amount).GreaterThan(0).WithMessage("O valor deve ser maio do que zero!");
        RuleFor(expense => expense.Date).LessThanOrEqualTo(DateTime.UtcNow).WithMessage("A data está no futuro, portanto é invalida!");
        RuleFor(expense => expense.PaymentType).IsInEnum().WithMessage("O tipo de pagamento não é válido!");
    }
}
