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
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace IntelliPOS
{
    [WinformsView(typeof(MainTask), MainTask.AddTableView, IsMdiParent = false, MdiParent = MainTask.POSView)]
    public partial class AddTableView : WinFormView, IPOSView
    {
        public AddTableView()
        {
            InitializeComponent();
            cbbArea.Items.AddRange(Facade.Instance.Areas.ToArray());
            cbbArea.DisplayMember = "Description";
            cbbArea.SelectedItem = cbbArea.Items[0];
        }
        public void UpdateView()
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            try
            {
                var area = cbbArea.SelectedItem as IArea;
                string tableNumber = txtTableNumber.Text;
                string pattern = @"^[0-9]{2}$";
                Regex regex = new Regex(pattern);

                MatchCollection collection = regex.Matches(tableNumber);
                foreach (Match m in collection)
                {
                    (Controller as AddTableViewController).AddTable(area, tableNumber);
                    this.Dispose();
                }

                if (tableNumber.Equals(string.Empty))
                {
                    throw new BusinessRuleException("Table number must not be empty");
                }
                else if (regex.IsMatch(tableNumber) == false)
                {
                    throw new BusinessRuleException("Please enter a valid two digit number");
                }
            }
            catch (BusinessRuleException b)
            {
                lblError.Text = b.Message;
                lblError.Visible = true;
            }
            catch 
            {
                lblError.Text = "Invalid Format";
                lblError.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
