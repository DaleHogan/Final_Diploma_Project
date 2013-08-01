using System;
namespace Domain
{
    public interface IPayment
    {
        decimal Amount { get; }
        Guid Id { get;}
        ISale Sale { get; }
        Guid SaleId { get;}
        PaymentType PaymentType { get; }
    }
}
