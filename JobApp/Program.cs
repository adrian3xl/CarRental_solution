using System;
using System.Windows.Forms;

namespace JobApp
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
            Application.Run(new JobApp_Main_window());
            // Application.Run(new Manage_resumeview());
            // Application.Run(new BrowseJobs());
            // Application.Run(new Employer_accountview());
        }
    }
} 
