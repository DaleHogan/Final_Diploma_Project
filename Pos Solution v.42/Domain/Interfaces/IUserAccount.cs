using System;
using System.Collections.Generic;
namespace Domain
{
    public interface IUserAccount
    {
        IEmployee Employee { get;}
        Guid Id { get; }
        int Password { get; }
        int StateId { get; }
        IEnumerable<ISale> Sales { get;  }
    }
}
