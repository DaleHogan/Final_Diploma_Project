using System;

namespace Domain
{
    public interface IEftposPayment
    {
        ISale Sale { get; }
        decimal Amount { get; }
    }
}
