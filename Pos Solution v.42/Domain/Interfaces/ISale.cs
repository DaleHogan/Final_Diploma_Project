using System;
using System.Collections.Generic;
namespace Domain
{
    public interface ISale
    {
        DateTime Date { get; }
        Guid Id { get;}
        IEnumerable<IPayment> Payments { get;  }
        IRegister Register { get; }
        Guid RegisterId { get;}
        IEnumerable<ISaleLineItem> SaleLineItems { get;}
        IUserAccount UserAccount { get;}
        Guid UserId { get; }
        decimal PaymentTotal { get; }
        decimal Change { get; }
        decimal SaleTotal { get; }
        decimal GSTTotal { get; }
        SaleType SaleType { get; }
    }
}
