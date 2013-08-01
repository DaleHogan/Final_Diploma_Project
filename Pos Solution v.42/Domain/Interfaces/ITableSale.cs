using System;
namespace Domain
{
    public interface ITableSale
    {
        ITable Table { get; }
        Guid TableId { get; }
    }
}
