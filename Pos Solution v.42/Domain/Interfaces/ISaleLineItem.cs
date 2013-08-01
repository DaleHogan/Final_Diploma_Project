using System;
namespace Domain
{
    public interface ISaleLineItem
    {
        IMenuProduct MenuProduct { get; }
        Guid MenuProductId { get; }
        int Quantity { get;}
        ISale Sale { get;}
        Guid SaleId { get; }
        decimal Total { get; }
        decimal GSTTotal { get; }
        string Message { get; set; }
    }
}
