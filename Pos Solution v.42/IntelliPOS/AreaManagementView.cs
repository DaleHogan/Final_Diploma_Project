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
    [WinformsView(typeof(MainTask), MainTask.AreaManagementView, IsMdiParent = false, MdiParent = MainTask.POSView)]
    public partial class AreaManagementView : WinFormView, IPOSView
    {
        public AreaManagementView()
        {
            InitializeComponent();
            MdiParent = MDIManager.MDIParent;
            ClientSize = MdiParent.ClientSize;
            Width -= 6;
            Height -= 150;
        }

        public void UpdateView()
        {
            dgvArea.Rows.Clear();
            lblError.Text = string.Empty;
            foreach(var a in Facade.Instance.Areas)
            {
                dgvArea.Rows.Add(a.Description,a.State,a);
            }
        }

        private void OpenCloseArea(Domain.States state)
        {
            try
            {
                //Get the selected Area object
                var a = dgvArea.SelectedRows[0].Cells[2].Value as IArea;
                //Get the row index of the selected Area object
                int selectedRowIndex = dgvArea.SelectedRows[0].Index;
                switch (state)
                {
                    case States.Open:
                        (Controller as AreaManagementViewController).OpenArea(a);
                        break;
                    case States.Closed:
                        //Update the table status to closed in the Domain/database
                        (Controller as AreaManagementViewController).CloseArea(a);
                        break;
                }
                UpdateView();
                //Clears any selected rows
                dgvArea.ClearSelection();
                //Reselect the row associated with the table being closed
                dgvArea.Rows[selectedRowIndex].Selected = true;
            }
            catch (BusinessRuleException ex)
            {
                lblError.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }   
        }

        private void btnOpen_Click_1(object sender, EventArgs e)
        {
            OpenCloseArea(States.Open);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            OpenCloseArea(States.Closed);
        }

        private void dgvArea_SelectionChanged(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
        }


    }
}
