using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCSharp.Core.Views;
using Domain;

namespace POSApplication
{
    public class OSKViewController : BaseController
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
                (View as IPOSView).UpdateView();
            }
        }

        public ISaleLineItem CreateSLIMessage(string message)
        {
            var saleController = MainTask.Navigator.GetController(MainTask.SaleView) as SaleViewController;
            return MainTask.CreateSLIMessage(saleController.MainTask.Sale, message);
        }
    }
}

