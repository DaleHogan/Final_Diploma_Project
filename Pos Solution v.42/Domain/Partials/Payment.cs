using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public enum PaymentType { Cash, Eftpos }

    internal abstract partial class Payment : IPayment
    {
        public Payment() { }
        public Payment(Sale sale, decimal amount)
        {
            this.Sale = sale;
            this.Amount = amount;
        }
        public abstract PaymentType PaymentType { get; } 
        #region Interface Implementation
        
        ISale IPayment.Sale
        {
            get { return Sale; }
        }
        #endregion
    }
}
