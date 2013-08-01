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
    [WinformsView(typeof(MainTask), MainTask.PriceLevelView, IsMdiParent = false, MdiParent = MainTask.POSView)]
    public partial class PriceLevelView : WinFormView, IPOSView
    {
        public PriceLevelView()
        {
            InitializeComponent();
            MdiParent = MDIManager.MDIParent;
            ClientSize = MdiParent.ClientSize;
            Width -= 6;
            Height -= 145;
        }

        public void UpdateView()
        {
            string pl = (Controller as PriceLevelViewController).MainTask.PriceLevel;
            lblPLevel.Text = pl;

        }
        private void btnLv1_Click(object sender, EventArgs e)
        {
            (Controller as PriceLevelViewController).ChangePricelevel1();
        }
        private void btnLv2_Click(object sender, EventArgs e)
        {
            (Controller as PriceLevelViewController).ChangePricelevel2();
        }
    }
}
