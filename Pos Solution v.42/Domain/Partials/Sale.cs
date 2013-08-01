using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public enum SaleType { Table, OTC, }
    internal abstract partial class Sale : ISale
    {
        public Sale(Register register, UserAccount userAccount)
        {
            this.Register = register;
            this.Date = DateTime.Now;
            this.UserAccount = userAccount;
        }

        public abstract SaleType SaleType { get; } 

        public IEnumerable<ISaleLineItem> FetchSalelineItems()
        {
            return SaleLineItems.AsEnumerable<ISaleLineItem>();
        }

        public SaleLineItem AddSaleLineItem(MenuProduct menuProduct)
        {
            SaleLineItem newLineItem = (SaleLineItems.Where(sli => sli.MenuProduct == menuProduct)).SingleOrDefault();
           
            if (newLineItem == null)
            {
                newLineItem = new SaleLineItem(this,menuProduct);
                this.SaleLineItems.Add(newLineItem);
            }
            else
            {
                newLineItem.IncrementQuantity();
            }
            return newLineItem;
        }

        public int IncrementQuantity(MenuProduct menuProduct)
        {
            SaleLineItem sli = SaleLineItems.Where(s => s.MenuProduct == menuProduct).FirstOrDefault();
            return sli.IncrementQuantity();
        }

        public int DecrementQuantity(MenuProduct menuProduct)
        {
            SaleLineItem sli = SaleLineItems.Where(s => s.MenuProduct == menuProduct).FirstOrDefault();
            return sli.DecrementQuantity();
        }

        public void CancelSaleLineItem(MenuProduct menuProduct)
        {
            SaleLineItem sli = SaleLineItems.Where(s => s.MenuProduct == menuProduct).FirstOrDefault();
            SaleLineItems.Remove(sli);
        }

        public void VoidSale()
        {
            SaleLineItem[] sliToDelete = SaleLineItems.ToArray();
            for (int i = 0; i < sliToDelete.Length; i++)
            {
                SaleLineItems.Remove(sliToDelete[i]);
            }
        }

        public ISaleLineItem CreateSLIMessage(ISale sale, string message)
        {
            var sli = sale.SaleLineItems.Last();
            sli.Message = message;
            return sli;
        }

        public decimal PaymentTotal
        {
            get
            {
                decimal total = 0;
                foreach (Payment p in Payments)
                {
                    total += p.Amount;
                }
                return total;
            }
        }

        public decimal Change
        {
            get
            {
                decimal change = PaymentTotal - SaleTotal;
                if (change < 0)
                    change = 0;
                return change;
            }
        }

        public decimal SaleTotal
        {
            get
            {
                decimal total = 0;
                foreach (var sli in SaleLineItems)
                {
                    total += sli.Total;
                }
                return total;
            }
        }

        public decimal GSTTotal
        {
            get { return SaleTotal / 11; }
        }
        
        public Payment AddCashPayment(decimal paymentAmount)
        {
            var payment = new CashPayment(this, paymentAmount);
            this.Payments.Add(payment);
            return payment;
        }

        public Payment AddEFTPOSPayment(decimal paymentAmount)
        {
            var payment = new EFTPOSPayment(this, paymentAmount);
            this.Payments.Add(payment);
            return payment;
        }

        #region Interface Implementation
        IEnumerable<IPayment> ISale.Payments
        {
            get { return Payments.AsEnumerable<IPayment>(); ; }
        }

        IRegister ISale.Register
        {
            get { return Register; }
        }

        IEnumerable<ISaleLineItem> ISale.SaleLineItems
        {
            get { return SaleLineItems.AsEnumerable<ISaleLineItem>(); ; }
        }

        IUserAccount ISale.UserAccount
        {
            get { return UserAccount; }
        }
        #endregion
    }
}
