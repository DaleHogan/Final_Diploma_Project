using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class TableClosed : ServiceState
    {
        public override States State
        {
            get { return States.Closed; }
        }

        public override void Reserve(Action action)
        {
            throw new BusinessRuleException("The table is closed"); 
        }

        public override void Open(Action action)
        {
            action(); 
        }

        public override void Close(Action action)
        {
            throw new BusinessRuleException("The table is already closed"); 
        }
    }
}
