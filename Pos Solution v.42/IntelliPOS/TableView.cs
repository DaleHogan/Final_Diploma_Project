using Domain;
using MVCSharp.Winforms;
using MVCSharp.Winforms.Configuration;
using POSApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntelliPOS
{
    [WinformsView(typeof(MainTask), MainTask.TableView, IsMdiParent = false, MdiParent = MainTask.POSView)]
    public partial class TableView : WinFormView, IPOSView
    {
        public TableView()
        {

            InitializeComponent();
            MdiParent = MDIManager.MDIParent;
            ClientSize = MdiParent.ClientSize;
            Width -= 6;
            Height -= 145;
            pnlTables.Width = Width;
            pnlTables.Height = Height - 100;
        }
        
        public void UpdateView()
        {

            pnlTables.Controls.Clear();
            foreach (var a in Facade.Instance.Areas)
            {
                
                var pn = new FlowLayoutPanel { AutoSize = true ,Width = this.Width };
                var lbl = new Label { Text = a.Description, Width = this.Width };
                pn.Controls.Add(lbl);
                IEnumerable<ITable> tables = a.Tables.OrderBy(t => t.TableNumber).AsEnumerable<ITable>();
                foreach (var t in tables)
                {
                    var b = new Button { Text = t.TableNumber, Tag = t };
                    b.Click += btnTableClicked; 
                    b.Width = 220;
                    b.Height = 120;
                    b.BackColor = LookupColor(t.State);
                    pn.Controls.Add(b);
                }
                pnlTables.Controls.Add(pn);
            }
        }

        private Color LookupColor(Domain.States state)
        {
            Color color;
            switch (state)
            {
                case States.Open:
                    color = Color.Green;
                    break;
                case States.Occupied:
                    color = Color.Red;
                    break;
                case States.Closed:
                    color = Color.Black;
                    break;
                default:
                    color = Color.Wheat;
                    break;
            }
            return color;
        }


        public void btnTableClicked(object sender, EventArgs e)
        {
            try
            {
                var table = (sender as Button).Tag as ITable;
                if (table.State == States.Open)
                {
                    this.Dispose();
                    (Controller as TableViewController).ReserveTable(table);
                    (Controller as TableViewController).CreateTableSale(table);
                }
                else if (table.State == States.Occupied)
                {
                    (Controller as TableViewController).FetchTableSale(table);
                }
                else
                {
                    //NoOp
                }
            }
            catch (BusinessRuleException b)
            {
                MessageBox.Show(this, b.Message, "Error", MessageBoxButtons.OK);
            }
        }

        
    }
}
