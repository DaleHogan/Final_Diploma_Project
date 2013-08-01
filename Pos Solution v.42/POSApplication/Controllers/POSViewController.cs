using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVCSharp.Core;
using POSApplication;
using MVCSharp.Core.Views;
using Domain;

namespace POSApplication
{
    public class POSViewController : BaseController
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

        public void DisplayTableView()
        {

           var tableController =  MainTask.Navigator.GetController(MainTask.TableView) as TableViewController; 
            MainTask.Navigator.NavigateDirectly(MainTask.TableView);
            tableController.UpdateView();
            UpdateView();
            
        }

        public void CreateOTCSale()
        {
            var sale = MainTask.CreateOTCSale(MainTask.Register.AreaId, MainTask.Register.Id, MainTask.UserAccount.Id);
            MainTask.Navigator.NavigateDirectly(MainTask.SaleView);
            var saleController = MainTask.Navigator.GetController(MainTask.SaleView) as SaleViewController;
            saleController.UpdateView();
            UpdateView();
        }


        public void DisplaySettingView()
        {
            MainTask.Navigator.NavigateDirectly(MainTask.SettingView);
        }
        
    }
}
