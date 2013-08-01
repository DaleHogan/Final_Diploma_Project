using System;
using System.Collections.Generic;
namespace Domain
{
    public interface IRestaurant
    {
        IEnumerable<IArea> Areas { get; }
        Guid Id { get;}
        IEnumerable<IMenu> Menus { get;}
        string Name { get; }
        IEnumerable<IPerson> People { get;}
       
    }
}
