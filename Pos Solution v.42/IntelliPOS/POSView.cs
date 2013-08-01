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


namespace IntelliPOS
{
    [WinformsView(typeof(MainTask), MainTask.POSView,IsMdiParent= true)]
    public partial class POSView : WinFormView, IPOSView
    {
        #region Timer
        private Timer timer;
        public class MouseMessageFilter : IMessageFilter
        {
            private EventHandler _callback;

            public MouseMessageFilter(EventHandler callback)
            {
                _callback = callback;
            }

            private const int WM_MOUSEMOVE = 0x0200;

            public bool PreFilterMessage(ref Message m)
            {
                if (m.Msg == WM_MOUSEMOVE)
                {
                    _callback(null, null);
                }

                return false;
            }
        }
        private void UserIsActive(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Start();
        }
        private void AutoLogout(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Dispose();
            btnLogout.PerformClick();
        }
        #endregion

        public POSView()
        {
            InitializeComponent();
            MDIManager.MDIParent = this;

            timer = new Timer();
            timer.Tick += AutoLogout;
            timer.Interval = (1 * 30) * 1000; // (5 minutes * seconds) * milliseconds
            Application.AddMessageFilter(new MouseMessageFilter(UserIsActive));
        }

        
        public void UpdateView()
        {
            
            CheckAccount();
            lbluser.Text = ((Controller as POSViewController).MainTask.UserAccount.Employee as IPerson).FirstName;
            lblDateTime.Text = DateTime.Now.ToShortDateString() + "   " + DateTime.Now.ToShortTimeString();
     
        }

        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            (Controller as POSViewController).DisplayTableView(); 
        }

        private void POSView_Load(object sender, EventArgs e)
        {

        }
        private void CheckAccount()
        {
            btnTable.Enabled = false;
            btnOTC.Enabled = false;
            btnSetting.Enabled = false;
            var user = (Controller as POSViewController).MainTask.UserAccount as IUserAccount;
            if (user.StateId ==1)
            {
                btnTable.Enabled = true;
                btnOTC.Enabled = true;
                
            }
            else if (user.StateId == 2)
            {
                btnTable.Enabled = true;
                btnOTC.Enabled = true;
                btnSetting.Enabled = true;
                
            }
            else
            {
                btnSetting.Enabled = true;
            }

           
        }
      
       
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            (Controller as POSViewController).CreateOTCSale();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            (Controller as POSViewController).MainTask.Navigator.NavigateDirectly(MainTask.LoginView);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            (Controller as POSViewController).DisplaySettingView();
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
