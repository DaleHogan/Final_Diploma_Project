using CrystalDecisions.Shared;
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
using Domain;

namespace Reports
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            var facade = new Facade();

            var register = from reg in facade.Restaurant.Areas.SelectMany(a => a.Registers)
                           select new { Name = reg.Name };

            var people = from ppl in facade.People select new { FirstName = ppl.FirstName, LastName = ppl.LastName };

            var payment = from pay in facade.Restaurant.Areas.SelectMany(a => a.Registers.SelectMany(r => r.Sales.SelectMany(p => p.Payments)))
                          select new { SaleId = pay.SaleId, Amount = pay.Amount };

            var report = new CrystalReport1();
            ArrayList records = new ArrayList();
            records.Add(register);
            records.Add(people);
            records.Add(payment);
            report.SetDataSource(records);

            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.RefreshReport();


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
    }
}
