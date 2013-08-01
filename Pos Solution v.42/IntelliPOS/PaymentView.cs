using CrystalDecisions.Shared;
using Domain;
using MVCSharp.Winforms;
using MVCSharp.Winforms.Configuration;
using POSApplication;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace IntelliPOS
{
    [WinformsView(typeof(MainTask), MainTask.PaymentView, IsMdiParent = false, MdiParent = MainTask.POSView)]
    public partial class PaymentView : WinFormView, IPOSView
    {

        public PaymentView()
        {

            InitializeComponent();
            MdiParent = MDIManager.MDIParent;
            ClientSize = MdiParent.ClientSize;
            Width -= 6;
            Height -= 145;

        }
        public void UpdateView()
        {
            UpdateDataGridView();
        }
        public void UpdateDataGridView()
        {
            dtvSaleLineItems.Rows.Clear();
            var sale = (Controller as PaymentViewController).MainTask.Sale as ISale;
            foreach (var sli in sale.SaleLineItems)
            {
                dtvSaleLineItems.Rows.Add(sli.MenuProduct.Product.Description, sli.Quantity, sli.Total.ToString("c"));
            }
            lbltot.Text = sale.SaleTotal.ToString("c");
            lblpa.Text = sale.PaymentTotal.ToString("c");
            lblCh.Text = sale.Change.ToString("c");


        }
        private void btnM5_Click(object sender, EventArgs e)
        {
            txtpay.Text = (sender as Button).Tag.ToString();
            pay(PaymentType.Cash);
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtpay.Text = string.Empty;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (!((sender as Button).Text.Equals(".") && txtpay.Text.Contains(".")))
            {
                txtpay.Text += (sender as Button).Text;
            }
        }
        private void pay(PaymentType paymentType)
        {
            var sale = (Controller as PaymentViewController).MainTask.Sale as ISale;
            if (txtpay.Text != "" && decimal.Parse(txtpay.Text) >= sale.SaleTotal && txtpay.Text.Count() <= 6)
            {
                switch (paymentType)
                {
                    case PaymentType.Cash:
                        (Controller as PaymentViewController).CreateCashPayment(decimal.Parse(txtpay.Text));
                        break;
                    case PaymentType.Eftpos:
                        (Controller as PaymentViewController).CreateEftposPayment(decimal.Parse(txtpay.Text));
                        break;
                }
                //PrintReceipt();
                MessageBox.Show(this, string.Format("Total:\t{0:c}\nPaid:\t{1:c}\nChange:\t{2:c}\nTime:\t{3}", sale.SaleTotal, sale.PaymentTotal, sale.Change, DateTime.Now), "Payment Complete", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
                if (sale.SaleType == SaleType.Table)
                {
                    (Controller as PaymentViewController).OpenTable((sale as ITableSale).Table);
                    var c = (Controller as PaymentViewController).MainTask.Navigator.GetController(MainTask.TableView) as TableViewController;
                    c.UpdateView();
                }
                txtpay.Text = string.Empty;
                (Controller as PaymentViewController).MainTask.Navigator.NavigateDirectly(MainTask.TableView);
            }
            else
            {
                
                MessageBox.Show(this, "Paid Amount Must Be Greater Than Sale Total ", "Insufficient Fund", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtpay.Text = string.Empty;
            }
        }
        private void btnEftpos_Click(object sender, EventArgs e)
        {
            var sale = (Controller as PaymentViewController).MainTask.Sale as ISale;
            txtpay.Text = string.Format("{0:0.00}", sale.SaleTotal);
            pay(PaymentType.Eftpos);
        }
        private void btnCash_Click(object sender, EventArgs e)
        {
            pay(PaymentType.Cash);
        }
        private void PrintReceipt()
        {
            var facade = new Facade();
            ArrayList source = new ArrayList();
            var register = facade.Restaurant.Areas.SelectMany(a => a.Registers);
            var sale = (Controller as PaymentViewController).MainTask.Sale as ISale;
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
                    Quantity = sli.Quantity,
                    ProductPrice = sli.Total,
                    GstTotal = sale.GSTTotal,
                    SaleTotal = sale.SaleTotal,
                });
            }

            var report = new SalesReport();
            report.SetDataSource(source);

            crystalReportViewer1.ReportSource = report;
            ConnectReporter();
            crystalReportViewer1.RefreshReport();
            report.PrintToPrinter(1, false, 1, 1);
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
