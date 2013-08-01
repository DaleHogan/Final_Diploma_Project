using MVCSharp.Core.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace POSApplication
{
    public class SettingViewController : BaseController
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
        public void DisplayAreaManagementView()
        {
            MainTask.Navigator.NavigateDirectly(MainTask.AreaManagementView);
        }

        public void DisplayTableManagementView()
        {
            MainTask.Navigator.NavigateDirectly(MainTask.TableManagementView);
            (MainTask.Navigator.GetController(MainTask.TableManagementView) as TableManagementViewController).UpdateView();
        }

        public void DisplayPriceLevelView()
        {
            MainTask.Navigator.NavigateDirectly(MainTask.PriceLevelView);
        }

        public void DisplayManageItemView()
        {
            MainTask.Navigator.NavigateDirectly(MainTask.ManageItemView);
        }

        public void DisplayManageStaffView()
        {
            MainTask.Navigator.NavigateDirectly(MainTask.ManageStaffMemberView);
        }

        public void DisplayReportsMenu()
        {
            MainTask.Navigator.NavigateDirectly(MainTask.ReportView);
        }
    }
}
