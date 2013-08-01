using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public enum States
    {
        Open, Closed, Occupied,
    }

    internal abstract class ServiceState : IServiceState
    {
        
        public abstract States State { get;}
        
        public abstract void Reserve(Action action);

        public abstract void Open(Action action);

        public abstract void Close(Action action); 


    }
}
