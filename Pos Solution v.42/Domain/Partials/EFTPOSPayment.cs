using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal partial class EFTPOSPayment : Payment
    {

        public EFTPOSPayment() { }
        public EFTPOSPayment(Sale sale, decimal amount)
            : base(sale, amount)
        {
            
        }
        public override PaymentType PaymentType
        {
            get { return PaymentType.Eftpos; }
        }
    }
}
