using System;
using System.Collections.Generic;
namespace Domain
{
    public interface IMenuProduct
    {
        Guid Id { get; }
        IMenu Menu { get; }
        Guid MenuId { get; }
        decimal Price { get; }
        IProduct Product { get;}
        Guid ProductId { get;}
        IEnumerable<ISaleLineItem> SaleLineItems { get; }
    }
}
