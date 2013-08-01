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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntelliPOS
{
    [WinformsView(typeof(MainTask), MainTask.EditTableView, IsMdiParent = false, MdiParent = MainTask.POSView)]
    public partial class EditTableView : WinFormView, IPOSView
    {
        public EditTableView()
        {
            InitializeComponent();
        }
        public void UpdateView()
        {
            var table = (Controller as EditTableViewController).MainTask.Table;
            lblAreaName.Text = table.Area.Description;
            txtTableNumber.Text = table.TableNumber;
        }


        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            try
            {
                string tableNumber = txtTableNumber.Text;
                string pattern = @"^[0-9]{2}$";
                Regex regex = new Regex(pattern);

                MatchCollection collection = regex.Matches(tableNumber);
                foreach (Match m in collection)
                {
                    (Controller as EditTableViewController).EditTable(tableNumber);
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
    }
}
