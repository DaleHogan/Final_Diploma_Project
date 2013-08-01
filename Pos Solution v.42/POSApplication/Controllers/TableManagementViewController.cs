using MVCSharp.Core.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace POSApplication
{
    public class TableManagementViewController : BaseController
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

        public void DisplayAddTableView()
        {
            MainTask.Navigator.NavigateDirectly(MainTask.AddTableView);
        }

        public void DisplayEditTableView()
        {
            MainTask.Navigator.NavigateDirectly(MainTask.EditTableView);
        }

        public void OpenTable(ITable table)
        {
            MainTask.OpenTable(table);
        }

        public void CloseTable(ITable table)
        {
            MainTask.CloseTable(table); 
        }

        public void AssignTable(ITable table)
        {
            MainTask.AssignTable(table);
        }
        public void DeleteTable()
        {
            MainTask.DeleteTable();
        }
    }
}
