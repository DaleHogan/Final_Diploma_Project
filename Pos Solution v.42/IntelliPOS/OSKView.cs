using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCSharp.Winforms;
using MVCSharp.Winforms.Configuration;
using POSApplication;


namespace IntelliPOS
{
    [WinformsView(typeof(MainTask), (MainTask.OSKView))]
    public partial class OSKView : WinFormView, IPOSView
    {
        public OSKView()
        {
            InitializeComponent();
        }

        public void UpdateView()
        {
            rtbMessage.Text = "";
        }

        public void btn_Clicked(object sender, EventArgs e)
        {
            rtbMessage.Text = rtbMessage.Text + (sender as Button).Text;
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            try
            {
                rtbMessage.Text = rtbMessage.Text.Substring(0, rtbMessage.Text.Length - 1);
            }
            catch { }
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            rtbMessage.Text = rtbMessage.Text + " ";
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            var message = rtbMessage.Text;
            (Controller as OSKViewController).CreateSLIMessage(message);
            ((Controller as OSKViewController).MainTask.Navigator.GetController(MainTask.SaleView) as SaleViewController).UpdateView();
            try
            {
                this.Close();
            }
            catch { }
        }
    }
}

