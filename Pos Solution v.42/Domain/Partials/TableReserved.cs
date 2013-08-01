using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    internal class TableOccupied : ServiceState
    {

        public override States State
        {
            get { return States.Occupied; }
        }

        public override void Reserve(Action action)
        {
            throw new BusinessRuleException("The table is already"); 
        }

        public override void Open(Action action)
        {
            action(); 
        }

        public override void Close(Action action)
        {
            throw new BusinessRuleException("An occupied table can not be closed"); 
        }
    }
}
