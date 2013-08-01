using System;
namespace Domain
{
    public interface IServiceState
    {
        States State { get; }
    }
}
