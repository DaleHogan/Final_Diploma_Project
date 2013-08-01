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
using System.Text.RegularExpressions;
using Domain;

namespace IntelliPOS
{
    [WinformsView(typeof(MainTask), MainTask.ManageStaffMemberView, IsMdiParent = false, MdiParent = MainTask.POSView)]

    public partial class ManageStaffMemberView : WinFormView, IPOSView
    {

        public ManageStaffMemberView()
        {
            InitializeComponent();
        }

        public void UpdateView()
        {

        }

        #region Search Staff Member (THIS FEATURE IS WORKING) √

        private void btnAutomaticSearch(object sender, EventArgs e)
        {
            dtvStaffMemberDetails.Rows.Clear();

            string firstName = Convert.ToString(tbxFirstName.Text);
            string lastName = Convert.ToString(tbxLastName.Text);

            var peoplesNameSearch = Facade.Instance[firstName, lastName];

            foreach (IPerson p in peoplesNameSearch)
            {
                dtvStaffMemberDetails.Rows.Add(p.Id, p.FirstName, p.LastName, p.ContactNumber, p.Email);
            }
        }
        #endregion

        #region Add Staff Member (THIS FEATURE IS WORKING) √

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblFirstName.Text = "FIRST NAME :";
            lblLastName.Text = "LAST NAME :";
            lblPhoneNumber.Text = "ADD PH# :";
            lblEmail.Text = "ADD EMAIL :";

            tbxContactNumber.Visible = true;
            tbxEmail.Visible = true;
            tbxFirstName.Visible = true;
            tbxLastName.Visible = true;

            lblFirstName.Visible = true;
            lblLastName.Visible = true;
            lblPhoneNumber.Visible = true;
            lblEmail.Visible = true;

            if (tbxEmail.Text.Equals("") || tbxFirstName.Text.Equals("") || tbxFirstName.Text.Equals("") || tbxLastName.Text.Equals("") || tbxContactNumber.Text.Equals(""))
            {
                MessageBox.Show(" Please Fill In The Required Fields ");
            }

            else
            {
                Facade.Instance.AddEmployee(tbxFirstName.Text.Trim(), tbxLastName.Text.Trim(), tbxContactNumber.Text.Trim(), tbxEmail.Text.Trim());
                MessageBox.Show(" Employee has been added ");
                tbxEmail.Text = "";
                tbxFirstName.Text = "";
                tbxLastName.Text = "";
                tbxContactNumber.Text = "";
            }
        }
        #endregion

        #region Edit Staff Member (THIS FEATURE IS WORKING) √

        private void btnEdit_Click(object sender, EventArgs e)
        {
            lblFirstName.Text = "SEARCH FIRST NAME :";
            lblLastName.Text = "SEARCH LAST NAME :";

            lblPhoneNumber.Visible = true;
            lblEmail.Visible = true;
            lblFirstName.Visible = true;
            lblLastName.Visible = true;

            tbxFirstName.Visible = true;
            tbxLastName.Visible = true;
            tbxEmail.Visible = true;
            tbxContactNumber.Visible = true;

            try
            {

                if (tbxFirstName.Text.Equals("") || tbxLastName.Text.Equals("") || tbxEmail.Text.Equals("") || tbxContactNumber.Text.Equals(""))
                {
                    MessageBox.Show(" Search for the employees first name or last name then edit the desired fields ");
                }

                else
                {
                    var id = (Guid)dtvStaffMemberDetails.FirstDisplayedCell.Value;
                    Facade.Instance.EditEmployee(id, tbxFirstName.Text.Trim(), tbxLastName.Text.Trim(), tbxContactNumber.Text.Trim(), tbxEmail.Text.Trim());
                    MessageBox.Show(" Employee Has been Edited ");
                    tbxEmail.Text = "";
                    tbxFirstName.Text = "";
                    tbxLastName.Text = "";
                    tbxContactNumber.Text = "";
                }
            }

            catch (Exception)
            {
                MessageBox.Show(" Employee does not Exist ");
            }
        }

        #endregion

        #region Delete Staff Member ID's are reading as 00000000000-0000000000000-0000000000 ( THIS FEATURE NEEDS MORE WORK !!!!)

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblEmail.Text = "Email: ";
            lblPhoneNumber.Text = "PH # : ";

            lblFirstName.Visible = true;
            lblLastName.Visible = true;
            lblEmail.Visible = true;
            lblPhoneNumber.Visible = true;

            tbxLastName.Visible = true;
            tbxFirstName.Visible = true;
            tbxEmail.Visible = true;
            tbxContactNumber.Visible = true;

            if (tbxEmail.Text.Equals("") || tbxFirstName.Text.Equals("") || tbxLastName.Text.Equals("") || tbxContactNumber.Text.Equals(""))
            {
                MessageBox.Show(" Plese Fill In The Required Fields ");
            }

            else
            {
                var id = (Guid)dtvStaffMemberDetails.FirstDisplayedCell.Value;
                Facade.Instance.DeletePerson(id);
                MessageBox.Show(" Employee has been deleted ");
            }
        }

        #endregion

        #region Search , Reset & Home buttons

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            tbxFirstName.Text = "";
            tbxLastName.Text = "";
            tbxEmail.Text = "";
            tbxContactNumber.Text = "";
            dtvStaffMemberDetails.Rows.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblFirstName.Text = "SEARCH FIRST NAME :";
            lblFirstName.Visible = true;

            lblLastName.Text = "SEARCH LAST NAME : ";
            lblLastName.Visible = true;
            tbxFirstName.Visible = true;
            tbxLastName.Visible = true;

            lblPhoneNumber.Visible = false;
            lblEmail.Visible = false;
            tbxEmail.Visible = false;
            lblPhoneNumber.Visible = false;
            tbxContactNumber.Visible = false;
                
            MessageBox.Show(" Please Fill In The Required Fields ");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            (Controller as ManageStaffMemberController).displaySaleViewScreen();
        }

        #endregion
    }
}