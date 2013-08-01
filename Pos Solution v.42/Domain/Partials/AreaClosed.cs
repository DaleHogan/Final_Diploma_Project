using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class AreaClosed : ServiceState
    {
        public override States State
        {
            get { return States.Closed; }
        }

        public override void Reserve(Action action)
        {
            throw new NotImplementedException();
        }

        public override void Open(Action action)
        {
            throw new NotImplementedException();
        }

        public override void Close(Action action)
        {
            throw new NotImplementedException();
        }
    }
}
