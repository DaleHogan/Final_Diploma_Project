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
using CrystalDecisions.Shared;
using System.Collections;


namespace IntelliPOS
{
    [WinformsView(typeof(MainTask), MainTask.ReportView, IsMdiParent = false, MdiParent = MainTask.POSView)]
    public partial class ReportView : WinFormView, IPOSView
    {
        public ReportView()
        {
            InitializeComponent();
            MdiParent = MDIManager.MDIParent;
            ClientSize = MdiParent.ClientSize;
            Width -= 6;
            Height -= 140;
        }

        public void UpdateView()
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

        private void btnXRead_Click(object sender, EventArgs e)
        {
            var facade = new Facade();
            ArrayList source = new ArrayList();
            var register = facade.Restaurant.Areas.SelectMany(a => a.Registers);
            var people = from p in facade.People select new { Id = p.Id, FirstName = p.FirstName, LastName = p.LastName };

            var sales = facade.Restaurant.Areas.SelectMany(a => a.Registers.SelectMany(r => r.Sales)).ToList();
            var salesTotal = sales.Sum(s => s.SaleTotal);
            var gst = sales.Sum(s => s.GSTTotal);

            var cashPayments = sales.SelectMany(s => s.Payments.Where(p => p.PaymentType.Equals(PaymentType.Cash))).ToList();
            var cashTotal = cashPayments.Sum(p => p.Sale.SaleTotal);
            var eftposPayments = sales.SelectMany(s => s.Payments.Where(p => p.PaymentType.Equals(PaymentType.Eftpos))).ToList();
            var eftposTotal = eftposPayments.Sum(p => p.Sale.SaleTotal);
            
            foreach (var s in sales)
            {                
                source.Add(new
                {
                    RegisterName = register.First().Name,
                    SaleNumber = sales.Count,
                    SaleTotal = salesTotal,
                    GstTotal = gst,
                    CashCount = cashPayments.Count,
                    CashTotal = cashTotal,
                    EftposCount = eftposPayments.Count,
                    EftposTotal = eftposTotal,
                    UserFirstName = s.UserAccount.ToString(),
                    UserSalesTotal = sales.Sum(sum => sales.Where(u => u.UserId.Equals(sum.UserAccount.Id)).FirstOrDefault().SaleTotal)
                });
            }
            var report = new XReadReport();
            report.SetDataSource(source);

            crystalReportViewer1.ReportSource = report;
            ConnectReporter();
            crystalReportViewer1.RefreshReport();
            
        }

        private void btnZRead_Click(object sender, EventArgs e)
        {
            btnXRead.PerformClick();
            crystalReportViewer1.PrintReport();
            (Controller as ReportViewController).DeleteSales();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            btnXRead.PerformClick();
            crystalReportViewer1.PrintReport();
        }
    }
}
