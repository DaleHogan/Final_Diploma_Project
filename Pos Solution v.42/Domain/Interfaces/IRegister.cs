using System;
using System.Collections.Generic;
namespace Domain
{
    public interface IRegister
    {
        IArea Area { get;}
        Guid AreaId { get;}
        Guid Id { get;}
        string Name { get;}
        IEnumerable<ISale> Sales { get;}
    }
}
