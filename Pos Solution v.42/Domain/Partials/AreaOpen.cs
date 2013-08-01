using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class AreaOpen : ServiceState
    {
        public override States State
        {
            get { return States.Open; }
        }

        public override void Reserve(Action action)
        {
           
        }

        public override void Open(Action action)
        {
            
        }

        public override void Close(Action action)
        {
            
        }
    }
}
