using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal partial class OTCSale : Sale
    {
        public OTCSale() { }
        public OTCSale(Register register, UserAccount userAccount)
            : base(register, userAccount)
        {
        
        }
        public override SaleType SaleType
        {
            get { return SaleType.OTC; }
        }
    }
}
