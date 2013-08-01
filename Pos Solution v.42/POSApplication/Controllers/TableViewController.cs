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
    public class TableViewController : BaseController
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

        //public IEnumerable<ITable> Tables { get; set; }

        public void CreateTableSale(ITable table)
        {
            var sale = MainTask.CreateTableSale(MainTask.Register.AreaId, MainTask.Register.Id, MainTask.UserAccount.Id, table.Id);
            MainTask.Navigator.NavigateDirectly(MainTask.SaleView);
            var saleController = MainTask.Navigator.GetController(MainTask.SaleView) as SaleViewController;
            saleController.UpdateView();

        }
        public void FetchTableSale(ITable table)
        {
            MainTask.FetchTableSale(table);
            MainTask.Navigator.NavigateDirectly(MainTask.SaleView);
            var saleController = MainTask.Navigator.GetController(MainTask.SaleView) as SaleViewController;
            saleController.UpdateView();
        }
        public void UpdateView()
        {
            (View as IPOSView).UpdateView();
        }
        public void ReserveTable(ITable table)
        {
            MainTask.ReserveTable(table);
        }
        public void OpenTable(ITable table)
        {
            MainTask.OpenTable(table);
        }
    }
}
