using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal partial class Menu : IMenu
    {

        public Menu(Restaurant restaurant)
        {
            this.Restaurant = restaurant;
        }

        public MenuProduct FetchMenuProduct(Guid menuProductId)
        {
            var menuProduct = MenuProducts.FirstOrDefault(m => m.Id.Equals(menuProductId));
            if (menuProduct == null)
            {
                throw new BusinessRuleException("Invalid menuProductId id supplied");
            }
            return menuProduct;
        }


        public MenuProduct AddMenuProduct(Product product, decimal price)
        {
            var menuProduct = new MenuProduct(this, product, price);
            this.MenuProducts.Add(menuProduct);
            return menuProduct;


        }
        #region Interface Implementation
        IEnumerable<IMenuProduct> IMenu.MenuProducts
        {
            get { return MenuProducts.AsEnumerable<IMenuProduct>(); }
        }

        IRestaurant IMenu.Restaurant
        {
            get { return Restaurant; }
        }
        #endregion


    }
}
