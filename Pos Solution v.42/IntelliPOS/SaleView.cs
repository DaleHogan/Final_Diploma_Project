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
using Domain;
using System.Collections;
using CrystalDecisions.Shared;

namespace IntelliPOS
{
    [WinformsView(typeof(MainTask), MainTask.SaleView, IsMdiParent = false, MdiParent = MainTask.POSView)]
    public partial class SaleView : WinFormView, IPOSView
    {
        public SaleView()
        {
            InitializeComponent();
            MdiParent = MDIManager.MDIParent;
            ClientSize = MdiParent.ClientSize;
            Width -= 6;
            Height -= 145;
        }
        
        public void UpdateView()
        {
            CreateCategoryButtons();
            UpdateDataGridView();
            DisplayDefaultMenu();
        }

        public void CreateCategoryButtons()
        {
            foreach (var c in Facade.Instance.Categories)
            {
                var buttonName = "btn" + c.Description;
                foreach (var b in pnlCategory.Controls.OfType<Button>())
                {
                    if (b.Name.Equals(buttonName))
                    {
                        b.Text = c.Description;
                        b.Click += CategoryClicked;
                        b.Tag = c;                        
                    }
                }
            }
        }

        public void DisplayDefaultMenu()
        {
            if (flpMenu.Controls.Count ==0)
            {
                btnCoffee.PerformClick();
            }
        }

        public void UpdateDataGridView()
        {
            dtvSaleLineItems.Rows.Clear();
            var sale = (Controller as SaleViewController).MainTask.Sale as ISale;
            var slis = (Controller as SaleViewController).FetchSalelineItems(sale);
                foreach (var sli in slis)
                {
                    dtvSaleLineItems.Rows.Add(sli.MenuProduct.Product.Description, sli.Quantity, sli.Total.ToString("c"),sli.MenuProduct);
                    if (sli.Message != null)
                    {
                        dtvSaleLineItems.Rows.Add(sli.Message);
                    }
                }
                lblsub.Text = (sale.SaleTotal - sale.GSTTotal).ToString("c");
                lblgs.Text = sale.GSTTotal.ToString("c");
                lblTot.Text = sale.SaleTotal.ToString("c");
                lblPLevel.Text = (Controller as SaleViewController).MainTask.PriceLevel;
        }

        public void CreateMenuButtons(ICategory button)
        {
            foreach (var p in button.Products)
            {
                var b = new Button { Text = p.Description };
                b.Click += ProductClicked;
                b.Width = 110;
                b.Height = 90;
                b.BackColor = Color.CadetBlue;
                b.ForeColor = Color.White;
                b.Tag = p;
                flpMenu.Controls.Add(b);
            }
        }

        public void ProductClicked(object sender, EventArgs e)
        {
            
            var _product = (sender as Button).Tag as IProduct;
            (Controller as SaleViewController).FetchProduct(_product);
            AddSaleLineItems(_product);
        }

        public void AddSaleLineItems(IProduct _product)
        {
            var priceLevel = (Controller as SaleViewController).MainTask.PriceLevel;
            var menuProducts = _product.MenuProducts.OrderBy(m => m.Price).Reverse().ToList();
            if (priceLevel.Equals("Happy Hour") && _product.MenuProducts.Count() == 2)
            {
                (Controller as SaleViewController).AddSaleLineItem(menuProducts[1]);
            }
            else
            {
                (Controller as SaleViewController).AddSaleLineItem(menuProducts[0]);
            }
        }

        public void CategoryClicked(object sender, EventArgs e)
        {
            var _category = (sender as Button).Tag as ICategory;
            resetCategoryButtonColor();
            (sender as Button).BackColor = Color.Blue;
            (Controller as SaleViewController).FetchCategory(_category);
            flpMenu.Controls.Clear();
            CreateMenuButtons(_category);
        }

        private void resetCategoryButtonColor()
        {
            foreach (var c in pnlCategory.Controls.OfType<Button>())
            {
                c.BackColor = Color.FromArgb(6, 52, 83);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtvSaleLineItems.SelectedRows[0].Index > 0)
                {
                    int selectedRow = dtvSaleLineItems.SelectedRows[0].Index;
                    dtvSaleLineItems.ClearSelection();
                    dtvSaleLineItems.Rows[selectedRow-1].Selected = true;
                }
            }
            catch { }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtvSaleLineItems.SelectedRows[0].Index != dtvSaleLineItems.RowCount - 1)
                {
                    int selectedRow = dtvSaleLineItems.SelectedRows[0].Index;
                    dtvSaleLineItems.ClearSelection();
                    dtvSaleLineItems.Rows[selectedRow +1].Selected = true;
                }
            }
            catch { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = dtvSaleLineItems.SelectedRows[0].Index;
                var menuProduct = dtvSaleLineItems.SelectedRows[0].Cells[3].Value as IMenuProduct;
                (Controller as SaleViewController).IncrementQuantity(menuProduct);
                dtvSaleLineItems.ClearSelection();
                dtvSaleLineItems.Rows[selectedRow].Selected = true;

            }
            catch { }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = dtvSaleLineItems.SelectedRows[0].Index;
                var menuProduct = dtvSaleLineItems.SelectedRows[0].Cells[3].Value as IMenuProduct;
                (Controller as SaleViewController).DecrementQuantity(menuProduct);
                dtvSaleLineItems.ClearSelection();
                dtvSaleLineItems.Rows[selectedRow].Selected = true;
            }
            catch { }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = dtvSaleLineItems.SelectedRows[0].Index;
                var menuProduct = dtvSaleLineItems.SelectedRows[0].Cells[3].Value as IMenuProduct;
                (Controller as SaleViewController).CancelSaleLineItem(menuProduct);
                if (selectedRow == 0)
                {
                    dtvSaleLineItems.ClearSelection();
                    dtvSaleLineItems.Rows[selectedRow].Selected = true;
                }
                else
                {
                    dtvSaleLineItems.ClearSelection();
                    dtvSaleLineItems.Rows[selectedRow - 1].Selected = true;
                }
            }
            catch { }
        }

        private void btnVoidSale_Click(object sender, EventArgs e)
        {
            (Controller as SaleViewController).VoidSale();
        }

        private void btnNoSale_Click(object sender, EventArgs e)
        {
            (Controller as SaleViewController).NoSale();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (dtvSaleLineItems.Rows.Count > 0)
            {
                (Controller as SaleViewController).DisplayPaymentView();
            }
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtvSaleLineItems.Rows.Count > 0)
                {
                    (Controller as SaleViewController).DisplayOSK();
                }
            }
            catch (Exception error)
            {
                string err = error.ToString();
            }
        }

        private void SaleView_Load(object sender, EventArgs e)
        {

        }

        private void ConnectReporter()
        {
            ConnectionInfo myConnectionInfo = new ConnectionInfo();

            myConnectionInfo.ServerName = @"localhost";
            myConnectionInfo.DatabaseName = "BeanScene";
            myConnectionInfo.UserID = "sa_tafe";
            myConnectionInfo.Password = "sql_tafe";

            TableLogOnInfos mytableloginfos = new TableLogOnInfos();
            mytableloginfos = crystalReportViewer1.LogOnInfo;
            foreach (TableLogOnInfo myTableLogOnInfo in mytableloginfos)
            {
                myTableLogOnInfo.ConnectionInfo = myConnectionInfo;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var facade = new Facade();
            ArrayList source = new ArrayList();
            var register = facade.Restaurant.Areas.SelectMany(a => a.Registers);
            var sale = (Controller as SaleViewController).MainTask.Sale as ISale;
            var saleLineItems = sale.SaleLineItems;

            var categories = facade.Categories;
            var products = categories.SelectMany(p => p.Products);

            
            foreach (var sli in saleLineItems)
            {
                source.Add(new
                {
                    RegisterName = register.First().Name,
                    UserFirstName = sale.UserAccount.ToString(),
                    SaleId = sale.Id,
                    ProductDescription = products.Where(p => p.Id.Equals(sli.MenuProduct.ProductId)).FirstOrDefault().Description,
                    Message = sli.Message,
                    Quantity = sli.Quantity,
                    ProductPrice = sli.Total,
                });
            }

            var report = new ProductionDocket();
            report.SetDataSource(source);

            crystalReportViewer1.ReportSource = report;
            ConnectReporter();
            crystalReportViewer1.RefreshReport();
            report.PrintToPrinter(1, false, 1, 1);
        }
    }
}
