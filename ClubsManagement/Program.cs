using System;
using System.Windows.Forms;

namespace ClubsManagement
{
    static class Program
    { 
        /// <summary>
        /// Entry point of the app
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomePage());
        }
    }
}
