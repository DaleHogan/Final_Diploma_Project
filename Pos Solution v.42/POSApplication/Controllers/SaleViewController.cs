using MVCSharp.Core.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace POSApplication
{
    public class SaleViewController : BaseController
    {
        public override IView View
        {
            get
            {
                return base.View;
            }
            set
            {
                base.View = value;
            }
        }

        public void UpdateView()
        {
            (View as IPOSView).UpdateView();
        }

        public void FetchCategory(ICategory Category)
        {
            var category = MainTask.FetchCategory(Category);

        }

        public void FetchProduct(IProduct _product)
        {
            var product = MainTask.FetchProduct(_product);

        }

        public void AddSaleLineItem(IMenuProduct menuProduct)
        {
            var sli = MainTask.AddSaleLineItem(menuProduct);
            UpdateView();
        }

        public void IncrementQuantity(IMenuProduct menuProduct)
        {
            
            MainTask.IncrementQuantity(menuProduct);
            UpdateView();
            
        }

        public void DecrementQuantity(IMenuProduct menuProduct)
        {
            
            MainTask.DecrementQuantity(menuProduct);
            UpdateView();
            
        }

        public void CancelSaleLineItem(IMenuProduct menuProduct)
        {
            MainTask.CancelSaleLineItem(menuProduct);
            UpdateView();

        }

        public void VoidSale()
        {
            MainTask.VoidSale();
            UpdateView();
        }

        public void NoSale()
        {
            if (MainTask.Sale.SaleType == SaleType.Table)
            {
                MainTask.OpenTable((MainTask.Sale as ITableSale).Table);
            }
            var tableController = MainTask.Navigator.GetController(MainTask.TableView) as TableViewController;
            MainTask.Navigator.NavigateDirectly(MainTask.TableView);
            tableController.UpdateView();
        }
        public IEnumerable<ISaleLineItem> FetchSalelineItems(ISale sale)
        {
            return MainTask.FetchSalelineItems(sale);
        }
        
        public void DisplayPaymentView()
        {
            MainTask.Navigator.NavigateDirectly(MainTask.PaymentView);
            var paymentController = MainTask.Navigator.GetController(MainTask.PaymentView) as PaymentViewController;
            paymentController.UpdateView();
        }

        public void DisplayOSK()
        {
            MainTask.Navigator.NavigateDirectly(MainTask.OSKView);
        }
    }
}
