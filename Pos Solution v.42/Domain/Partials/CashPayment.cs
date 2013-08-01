using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal partial class CashPayment : Payment
    {
        public CashPayment() { }
        public CashPayment(Sale sale, decimal amount)
            : base(sale, amount)
        {
            
        }
        public override PaymentType PaymentType
        {
            get { return PaymentType.Cash; }
        }
    }
}
