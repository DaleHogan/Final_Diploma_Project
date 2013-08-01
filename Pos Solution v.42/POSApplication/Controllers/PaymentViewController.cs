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
    public class PaymentViewController : BaseController
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
                UpdateView();

            }
        }

        public void UpdateView()
        {
            (View as IPOSView).UpdateView();
        }
        public void CreateCashPayment(decimal amount)
        {
            MainTask.CreateCashPayment(amount);

            UpdateView();

        }
        public void OpenTable(ITable table)
        {
            MainTask.OpenTable(table);
        }
        public void CreateEftposPayment(decimal amount)
        {
            MainTask.CreateEftposPayment(amount);
            UpdateView();
        }
    }
}
