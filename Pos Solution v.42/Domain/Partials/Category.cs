using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal partial class Category :ICategory
    {
        public Category(string description)
        {
            this.Description = description;
        }

        public Product AddProduct(decimal price, string description)
        {
             foreach (var p in Products)
                {
                    if (p.Description.Equals(description))
                    {
                        throw new BusinessRuleException("Product name must be unique");
                    }
                }
            var product = new Product(this, price, description);
            this.Products.Add(product);
            return product;
        }

       
        public Product EditProduct(Guid productId, decimal price, string description)
        {
            var product = FetchProduct(productId);
            product.Price = price;
            product.Description = description;
            return product;
        }
        public string invalidProductId = "Invalid product id supplied";
        public Product FetchProduct(Guid productId)
        {
            var product = this.Products.FirstOrDefault(p => p.Id.Equals(productId));
            if (product == null)
            {
                throw new BusinessRuleException(invalidProductId);
            }
            return product;
        }
        
        #region Interface Implementation
        IEnumerable<IProduct> ICategory.Products
        {
            get { return Products.AsEnumerable<IProduct>(); }
        }
        #endregion
    }
}
