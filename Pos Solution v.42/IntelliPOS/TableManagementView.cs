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
    [WinformsView(typeof(MainTask), MainTask.TableManagementView, IsMdiParent = false, MdiParent = MainTask.POSView)]
    public partial class TableManagementView : WinFormView, IPOSView
    {
        public TableManagementView()
        {
            InitializeComponent();
            MdiParent = MDIManager.MDIParent;
            ClientSize = MdiParent.ClientSize;
            Width -= 6;
            Height -= 145;
            cbbArea.Items.AddRange(Facade.Instance.Areas.ToArray());
            cbbArea.DisplayMember = "Description";
            cbbArea.SelectedItem = cbbArea.Items[0];
        }

        public void UpdateView()
        {
            lblError.Text = string.Empty;
            dgvTables.Rows.Clear();
            var area = cbbArea.SelectedItem as IArea;
            var tables = area.Tables.OrderBy(t => t.TableNumber).ToList();
            foreach (var t in tables)
            {
                dgvTables.Rows.Add(area.Description, t.TableNumber, t.State, t);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            (Controller as TableManagementViewController).DisplayAddTableView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Visible = false;
                var table = dgvTables.SelectedRows[0].Cells[3].Value as ITable;
                int selectedRow = dgvTables.SelectedRows[0].Index;
                (Controller as TableManagementViewController).AssignTable(table);
                (Controller as TableManagementViewController).DisplayEditTableView();
                dgvTables.ClearSelection();
                dgvTables.Rows[selectedRow].Selected = true;
            }
            catch
            {
                lblError.Visible = true;
                lblError.Text = "Choose a table";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                lblError.Visible = false;
                var table = dgvTables.SelectedRows[0].Cells[3].Value as ITable;
                int selectedRow = dgvTables.SelectedRows[0].Index;
                (Controller as TableManagementViewController).AssignTable(table);
                (Controller as TableManagementViewController).DeleteTable();
                UpdateView();

                if (selectedRow == 0)
                {
                    dgvTables.ClearSelection();
                    dgvTables.Rows[selectedRow].Selected = true;
                }
                else
                {
                    dgvTables.ClearSelection();
                    dgvTables.Rows[selectedRow - 1].Selected = true;
                }
            }
            catch
            {
                lblError.Visible = true;
                lblError.Text = "The selected table has associated sales records and can not be deleted, consider closing the table instead";

            }
        }

        #region Open / Close Table functionallity

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenCloseTable(States.Open);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            OpenCloseTable(States.Closed);
        }

        public void OpenCloseTable(Domain.States state)
        {
            try
            {
                if (dgvTables.SelectedRows.Count < 1)
                {
                    lblError.Text = "No table selected for the chosen operation, Please select a table first";
                    return;
                }

                //Get the selected table object
                var table = dgvTables.SelectedRows[0].Cells[3].Value as ITable;
                //Get the row index of the selected table object
                int selectedRowIndex = dgvTables.SelectedRows[0].Index;
                if (table.State == States.Occupied)
                {
                    lblError.Text = "Cannot close table as it is reserved";
                    return;
                }
                switch (state)
                {
                    case States.Open:
                        (Controller as TableManagementViewController).OpenTable(table);
                        break;
                    case States.Closed:
                        //Update the table status to closed in the Domain/database
                        (Controller as TableManagementViewController).CloseTable(table);
                        break;
                }
                UpdateView();
                //Clears any selected rows
                dgvTables.ClearSelection();
                //Reselect the row associated with the table being closed
                dgvTables.Rows[selectedRowIndex].Selected = true;
            }
            catch (BusinessRuleException ex)
            {
                lblError.Text = ex.Message;
                lblError.Visible = true;
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
                lblError.Visible = true;
            }
        }

        #endregion

        private void cbbArea_DropDownClosed(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void dgvTables_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTables.SelectedRows.Count < 1)
            {
                lblError.Text = "No table selected for the chosen operation, Please select a table first";
                return;
            }
            else
            {
                lblError.Text = string.Empty;
            }
            //Get the selected table object
            var table = dgvTables.SelectedRows[0].Cells[3].Value as ITable;
            btnDelete.Visible = table.TableSales.Count() < 1;

        }


    }
}
