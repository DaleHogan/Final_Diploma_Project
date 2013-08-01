using MVCSharp.Core.Tasks;
using MVCSharp.Winforms;
using POSApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntelliPOS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            TasksManager tasksManager = new TasksManager(WinformsViewsManager.GetDefaultConfig());
            tasksManager.StartTask(typeof(MainTask));
            Application.Run(Application.OpenForms[0]);
            
        }
    }
}
