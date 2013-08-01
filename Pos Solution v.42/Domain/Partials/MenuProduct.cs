using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{

    internal partial class MenuProduct :IMenuProduct
    {
        private Domain.Menu menu;
        private Domain.Product product;

        public MenuProduct(Domain.Menu menu, Domain.Product product, decimal price)
        {
            this.menu = menu;
            this.product = product;
            this.Price = price;
        }


        #region Interface Implementation
        IMenu IMenuProduct.Menu
        {
            get { return Menu; }
        }

        IProduct IMenuProduct.Product
        {
            get { return Product; }
        }

        IEnumerable<ISaleLineItem> IMenuProduct.SaleLineItems
        {
            get { return SaleLineItems.AsEnumerable<ISaleLineItem>(); }
        }
        #endregion
    }
}
