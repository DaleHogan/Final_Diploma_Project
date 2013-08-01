using System;

namespace Domain
{
    public interface ICashPayment
    {
        ISale Sale { get; }
        decimal amount { get; }
    }
}
