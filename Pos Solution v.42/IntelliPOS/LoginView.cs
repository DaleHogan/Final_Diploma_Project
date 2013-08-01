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
using MVCSharp.Winforms;
using MVCSharp.Winforms.Configuration;
using POSApplication;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace IntelliPOS
{
    [WinformsView(typeof(MainTask), MainTask.LoginView)]
    public partial class LoginView : WinFormView, IPOSView
    {
        byte[] tmpSource;
        byte[] tmpHash;

        public LoginView()
        {
            InitializeComponent();
            
        }

        public void UpdateView()
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblWrongPin.Visible = false;
            try
            {
                string pin = txtPin.Text;
                string pattern = @"^[0-9]{4}$";
                Regex regex = new Regex(pattern);

                MatchCollection collection = regex.Matches(pin);
                foreach (Match m in collection)
                {
                    (Controller as LoginViewController).Login(int.Parse(txtPin.Text));
                    hashPassword(txtPin.Text);
                }
                if (pin.Equals(string.Empty) || regex.IsMatch(pin) == false)
                {
                    throw new BusinessRuleException("Table number must not be empty");
                }
            }            
            catch 
            {
                lblWrongPin.Visible = true;
                lblWrongPin.Text = "Invalid password supplied";
            }
            txtPin.Text = string.Empty;
        }

        #region Encrpyt Password (HASH)

        private string hashPassword(string thisPassword)
        {
            MD5CryptoServiceProvider md5CSP = new MD5CryptoServiceProvider();


            tmpSource = ASCIIEncoding.ASCII.GetBytes(thisPassword);
            tmpHash = md5CSP.ComputeHash(tmpSource);

            StringBuilder output = new StringBuilder(tmpHash.Length);

            for (int i = 0; i < tmpHash.Length; i++)
            {
                output.Append(tmpHash[i].ToString("X2"));
            }

            return output.ToString();

        }

        private Boolean verifyPassword(string thisPassword, string thisHash)
        {
            Boolean isValid = false;
            string tmpHash = hashPassword(thisPassword);
            if (tmpHash == thisHash.ToString())
            {
                isValid = true;
            }
            return isValid;
        }

        #endregion

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                txtPin.Text = txtPin.Text.Substring(0, txtPin.Text.Length - 1);
            }
            catch { }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPin.Text = string.Empty;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPin.AppendText((sender as Button).Text);
        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
