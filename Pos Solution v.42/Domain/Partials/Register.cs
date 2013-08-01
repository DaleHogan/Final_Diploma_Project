using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal partial class Register : IRegister
    {
        public Register(Area area, string name)
        {
            this.Area = area;
            this.Name = name;
        }

        #region Sale
        public Sale CreateOTCSale(UserAccount userAccount)
        {
            var sale = new OTCSale(this, userAccount);
            Sales.Add(sale);
            return sale;
        }
        public Sale CreateTableSale(UserAccount userAccount, Table table)
        {
            var sale = new TableSale(this, userAccount, table);
            Sales.Add(sale);
            return sale;
        }

        public Sale FetchSale(Guid saleId)
        {
            var sale = this.Sales.FirstOrDefault(s => s.Id.Equals(saleId));
            if (sale == null)
            {
                throw new BusinessRuleException("Invalid sale id supplied");
            }
            return sale; 
        }
        public void FinaliseSale(Guid saleId)
        {
            var sale = FetchSale(saleId);
            sale.Date = DateTime.Now;
            
        }
        
        #endregion

        #region SalelineItem
        public SaleLineItem AddSaleLineItem(Guid saleId,MenuProduct menuProduct)
        {
            var sale = FetchSale(saleId);
            return sale.AddSaleLineItem(menuProduct);
        }

        public int IncrementQuantity(Guid saleId, MenuProduct menuProduct)
        {
            var sale = FetchSale(saleId);
            return sale.IncrementQuantity(menuProduct);
        }

        public int DecrementQuantity(Guid saleId, MenuProduct menuProduct)
        {
            var sale = FetchSale(saleId);
            return sale.DecrementQuantity(menuProduct);
        }

        public void CancelSaleLineItem(Guid saleId, MenuProduct menuProduct)
        {
            var sale = FetchSale(saleId);
            sale.CancelSaleLineItem(menuProduct);
        }
        public void VoidSale(Guid saleId)
        {
            var sale = FetchSale(saleId);
            sale.VoidSale();
        }
        public ISaleLineItem CreateSLIMessage(Guid saleId, string message)
        {
            var sale = FetchSale(saleId);
            return sale.CreateSLIMessage(sale, message);
        }
        public IEnumerable<ISaleLineItem> FetchSalelineItems(Guid saleId)
        {
            var sale = FetchSale(saleId);
            return sale.FetchSalelineItems();
        }
        
        #endregion

        #region Payment
        public Payment AddCashPayment(Guid saleId, decimal paymentAmount)
        {
            var sale = FetchSale(saleId);
            return sale.AddCashPayment(paymentAmount);
        }
        public Payment AddEFTPOSPayment(Guid saleId, decimal paymentAmount)
        {
            var sale = FetchSale(saleId);
            return sale.AddEFTPOSPayment(paymentAmount);
        }
        
        #endregion

        #region Interface Implementation
        IArea IRegister.Area
        {
            get { return Area; }
        }

        IEnumerable<ISale> IRegister.Sales
        {
            get { return Sales.AsEnumerable<ISale>(); }
        }
        #endregion
    }
}
