using Domain;
using MVCSharp.Core;
using MVCSharp.Core.Views;
using POSApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSApplication
{
    public class ManageStaffMemberController : BaseController
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

        public void displaySaleViewScreen()
        {
            MainTask.Navigator.NavigateDirectly(MainTask.SaleView);

        }
    }
}
