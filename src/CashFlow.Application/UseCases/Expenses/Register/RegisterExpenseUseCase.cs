﻿using CashFlow.Communication.Enums;
using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;

namespace CashFlow.Application.UseCases.Expenses.Register;

public class RegisterExpenseUseCase
{
    public ResponseRegisteredExpenseJson Execute(RequestRegisterExpenseJson request)
    {
        Validate(request);
        return new ResponseRegisteredExpenseJson();
    }

    private void Validate(RequestRegisterExpenseJson request)
    {
        var titleIsEmpty = string.IsNullOrEmpty(request.Title);
        if (titleIsEmpty)
        {
            throw new ArgumentException("O titulo é obrigatório!");
        }
        if(request.Amount <= 0)
        {
            throw new ArgumentException("O valor deve ser maio do que zero!");
        }
        var result = DateTime.Compare(request.Date, DateTime.UtcNow);
        if(result > 0)
        {
            throw new ArgumentException("A data está no futuro, portanto é invalida!");
        }
        var paymentTypeIsValid = Enum.IsDefined(typeof(PaymentType), request.PaymentType);
        if (paymentTypeIsValid == false)
        {
            throw new ArgumentException("O tipo de pagamento não é válido!");
        }
    }
}