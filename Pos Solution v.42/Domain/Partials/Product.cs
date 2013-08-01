using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal partial class Product :IProduct
    {
        public Product(Category category, decimal price, string description)
        {
            this.Category = category;
            this.Price = price;
            this.Description = description;
        }


        #region Interface Implementation
        ICategory IProduct.Category
        {
            get { return Category; }
        }

        IEnumerable<IMenuProduct> IProduct.MenuProducts
        {
            get { return MenuProducts.AsEnumerable<IMenuProduct>(); }
        }
        #endregion
    }
}
