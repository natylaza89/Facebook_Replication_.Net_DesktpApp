using DP_Task1.forms;
using System;
using System.Windows.Forms;

namespace DP_Task1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppMainForm());
        }
    }
}
