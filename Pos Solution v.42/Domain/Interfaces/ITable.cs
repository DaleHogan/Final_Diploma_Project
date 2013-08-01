using System;
using System.Collections.Generic;
namespace Domain
{
    public interface ITable
    {
        IArea Area { get; }
        Guid AreaId { get;  }
        Guid Id { get; }
        int StateId { get; }
        string TableNumber { get;}
        IEnumerable<ITableSale> TableSales { get;}
        Domain.States State { get; }
    }
}
