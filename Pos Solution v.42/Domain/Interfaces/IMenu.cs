using System;
using System.Collections.Generic;
namespace Domain
{
    public interface IMenu
    {
        Guid Id { get;}
        IEnumerable<IMenuProduct> MenuProducts { get; }
        IRestaurant Restaurant { get; }
        Guid RestaurantId { get;}
    }
}
