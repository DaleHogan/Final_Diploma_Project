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
using Domain;
using MVCSharp.Winforms.Configuration;
using MVCSharp.Winforms;
using System.Text.RegularExpressions;

namespace IntelliPOS
{
    [WinformsView(typeof(MainTask), MainTask.ManageItemView, IsMdiParent = false, MdiParent = MainTask.POSView)]

    public partial class ManageItemView : WinFormView, IPOSView
    {
        public ManageItemView()
        {
            InitializeComponent();
        }

        public void UpdateView()
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblDescription.Visible = true;
            lblPrice.Visible = true;
            tbxDescription.Visible = true;
            tbxPrice.Visible = true;
            lblCategory.Visible = false;
            lblEditPrice.Visible = false;
            cboxCategory.Visible = false;
            tbxEditPrice.Visible = false;

            try
            {
                if (tbxDescription.Text.Equals("") || tbxPrice.Text.Equals(""))
                {
                    MessageBox.Show("Please Fill In The Required Fields");
                }
            }
            catch
            {
                MessageBox.Show("Product does not Exist ");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            (Controller as ItemViewController).displaySaleViewScreen();
        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            tbxDescription.Text = "";
            tbxPrice.Text = "";
            lblDescription.Visible = false;
            lblPrice.Visible = false;
            lblEditPrice.Visible = false;
            lblExeption.Visible = false;
            lblCategory.Visible = false;
            tbxDescription.Visible = false;
            tbxPrice.Visible = false;
            cboxCategory.Visible = false;
            tbxEditPrice.Visible = false;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            lblDescription.Visible = true;
            lblPrice.Visible = true;
            lblEditPrice.Visible = true;
            tbxDescription.Visible = true;
            tbxPrice.Visible = true;
            tbxEditPrice.Visible = true;
            lblCategory.Visible = false;
            cboxCategory.Visible = false;

            
            try
            {
                if (tbxDescription.Text.Equals("") || tbxPrice.Text.Equals("") || tbxEditPrice.Text.Equals(""))
                {
                    MessageBox.Show("Please Fill In The Required Fields");
                }
                else
                {
                    var categoryId = (Guid)dtvItemDetails.CurrentRow.Cells[1].Value;
                    var productId = (Guid)dtvItemDetails.FirstDisplayedCell.Value;
                    var price = Convert.ToDecimal(tbxEditPrice.Text);
                    Facade.Instance.EditProduct(categoryId, productId, price, tbxDescription.Text);
                    MessageBox.Show("Product Has been Edited");
                    tbxDescription.Text = "";
                    tbxPrice.Text = "";
                    tbxEditPrice.Text = "";
                }
            }


            catch (Exception)
            {
                MessageBox.Show("Product does not Exist ");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblDescription.Visible = true;
            lblPrice.Visible = true;
            lblCategory.Visible = true;
            lblEditPrice.Visible = false;
            tbxEditPrice.Visible = false;
            tbxDescription.Visible = true;
            tbxPrice.Visible = true;
            cboxCategory.Visible = true;
            try
            {
                if (tbxDescription.Text.Equals("") || tbxPrice.Text.Equals(""))
                {
                    MessageBox.Show("Please Fill In The Required Fields");
                }
                else
                {
                    Guid id = (Guid)cboxCategory.SelectedValue;
                    var price = Convert.ToDecimal(tbxPrice.Text);
                    var product = Facade.Instance.AddProduct(id, price, tbxDescription.Text);
                    var menu = Facade.Instance.Restaurant.Menus.FirstOrDefault();
                    Facade.Instance.AddMenuProduct(menu.Id, product.Id, price);

                    MessageBox.Show("Item Has Been Added");
                    tbxDescription.Text = "";
                    tbxPrice.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Item Already Exist");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblDescription.Visible = true;
            lblPrice.Visible = true;
            tbxDescription.Visible = true;
            tbxPrice.Visible = true;
            lblEditPrice.Visible = false;
            lblCategory.Visible = false;
            tbxEditPrice.Visible = false;
            cboxCategory.Visible = false;

            try
            {
                if (tbxDescription.Text.Equals("") || tbxPrice.Text.Equals(""))
                {
                    MessageBox.Show("Please Fill In The Required Fields");
                }
                else
                {
                    var categoryId = (Guid)dtvItemDetails.CurrentRow.Cells[1].Value;
                    var productId = (Guid)dtvItemDetails.FirstDisplayedCell.Value;
                    decimal price = Convert.ToDecimal(tbxPrice.Text);
                    Facade.Instance.DeleteMenuProduct(categoryId, productId);
                    Facade.Instance.DeleteProduct(categoryId, productId);

                    MessageBox.Show("Item Has Been Deleted");
                    lblExeption.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Item Has Been Deleted");
            }
        }

        private void btnAutomaticSearch(object sender, EventArgs e)
        {
            dtvItemDetails.Rows.Clear();


            try
            {
                string description = Convert.ToString(tbxDescription.Text);
                decimal price = Convert.ToDecimal(tbxPrice.Text);

                var itemSearch = Facade.Instance[description, price];

                foreach (IProduct p in itemSearch)
                {
                    dtvItemDetails.Rows.Add(p.Id, p.CategoryId, p.Price, p.Description);
                }
            }
            catch (FormatException) { }
            catch (Exception)
            {
                throw new BusinessRuleException("ITEM DOES NOT EXIST");
            }
        }

        private void ManageItemView_Load(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.beanSceneDataSet.Product);
            this.categoryTableAdapter.Fill(this.beanSceneDataSet.Category);

        }

    }
}
