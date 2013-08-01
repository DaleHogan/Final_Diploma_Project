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
    [WinformsView(typeof(MainTask), MainTask.SettingView, IsMdiParent = false, MdiParent = MainTask.POSView)]
    public partial class SettingView : WinFormView, IPOSView
    {
        public SettingView()
        {
            InitializeComponent();
            MdiParent = MDIManager.MDIParent;
            ClientSize = MdiParent.ClientSize;
            Width -= 6;
            Height -= 145;
        }
        public void UpdateView()
        {
           
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            (Controller as SettingViewController).DisplayAreaManagementView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (Controller as SettingViewController).DisplayTableManagementView();
        }

        private void btnPricelevel_Click(object sender, EventArgs e)
        {
            (Controller as SettingViewController).DisplayPriceLevelView();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            (Controller as SettingViewController).DisplayManageItemView();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            (Controller as SettingViewController).DisplayManageStaffView();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            (Controller as SettingViewController).DisplayReportsMenu();
        }
    }
}
