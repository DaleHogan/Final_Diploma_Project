using System;
using System.Collections.Generic;
namespace Domain
{
    public interface IProduct
    {
        ICategory Category { get; }
        Guid CategoryId { get; }
        string Description { get; }
        Guid Id { get; }
        IEnumerable<IMenuProduct> MenuProducts { get; }
        decimal Price { get; }
    }
}
