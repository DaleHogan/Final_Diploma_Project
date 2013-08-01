using Domain;
using MVCSharp.Core;
using MVCSharp.Core.Views;
using POSApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace POSApplication
{
    public class LoginViewController : BaseController
    {
        public override IView View
        {
            get
            {
                return base.View;
            }
            set
            {
                base.View = value;

                (View as IPOSView).UpdateView();
            }
        }
   
        public void Login(int password)
        {
            try
            {
                var user = MainTask.Logon(password);
                MainTask.Navigator.NavigateDirectly(MainTask.POSView);
                if (user.UserAccount.StateId == 3)
                {
                    MainTask.Navigator.NavigateDirectly(MainTask.SettingView);
                }
                else
                {
                    MainTask.Navigator.NavigateDirectly(MainTask.TableView);
                    var tableController = MainTask.Navigator.GetController(MainTask.TableView) as TableViewController;
                    tableController.UpdateView();
                }
                

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}
