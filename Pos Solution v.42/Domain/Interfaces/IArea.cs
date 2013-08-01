using System;
using System.Collections.Generic;
namespace Domain
{
    public interface IArea
    {
        
        string Description { get;}
        Guid Id { get; }
        IEnumerable<IRegister> Registers { get;}
        IRestaurant Restaurant { get; }
        Guid RestaurantId { get; }
        int StateId { get; }
        IEnumerable<ITable> Tables { get; }
        Domain.States State { get; }
    }
}
