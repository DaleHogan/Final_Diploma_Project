using MVCSharp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSApplication
{
    public class BaseController : ControllerBase
    {

        public MainTask MainTask
        {
            get
            {
                return this.Task as MainTask; 
            }
        }
    }
}
