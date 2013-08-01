using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVCSharp.Core;

namespace POSApplication.Tasks
{
    public class ParentViewController : ControllerBase
    {
        protected MainTask MainTask
        {
            get
            {
                return Task as MainTask;
            }
        }
    }
}
