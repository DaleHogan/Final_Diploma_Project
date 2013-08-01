using MVCSharp.Core.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace POSApplication
{
    public class PriceLevelViewController : BaseController
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



        public void ChangePricelevel1()
        {
            MainTask.ChangePricelevel1();
            UpdateView();
        }

        public void ChangePricelevel2()
        {
            MainTask.ChangePricelevel2();
            UpdateView();
        }
    }
}

