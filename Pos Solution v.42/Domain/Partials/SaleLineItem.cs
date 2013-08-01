using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal partial class SaleLineItem : ISaleLineItem
    {
        public SaleLineItem() { }
        public SaleLineItem(Sale sale,MenuProduct menuProduct)
        {
            this.Sale = sale;
            this.MenuProduct = menuProduct;
            this.Quantity = 1;
        }

        
        public decimal Total
        {
            get
            {
                return MenuProduct.Price * Quantity;
            }
        }

        public decimal GSTTotal
        {
            get
            {
                return Total / 11;
            }
        }

     
        public int IncrementQuantity()
        {
            Quantity++;
            return Quantity;
        }

        public int DecrementQuantity()
        {
            Quantity--;
            if (Quantity <= 0)
                Quantity = 1;
            return Quantity;
        }


        #region Interface Implementation
        IMenuProduct ISaleLineItem.MenuProduct
        {
            get { return MenuProduct; }
        }

        ISale ISaleLineItem.Sale
        {
            get { return Sale; }
        }
        #endregion
    }
}
