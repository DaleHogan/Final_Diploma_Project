using System;
using System.Collections.Generic;
namespace Domain
{
    public interface ICategory
    {
        string Description { get; }
        Guid Id { get; }
        IEnumerable<IProduct> Products { get; }

    }
}
