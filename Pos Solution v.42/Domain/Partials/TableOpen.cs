using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class TableOpen : ServiceState
    {
        public override States State
        {
            get { return States.Open; }
        }

        public override void Reserve(Action action)
        {
            action(); 
        }

        public override void Open(Action action)
        {
            throw new BusinessRuleException("Table is already open");
        }

        public override void Close(Action action)
        {
            action(); 
        }
    }
}
