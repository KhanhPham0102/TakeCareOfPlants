using System;
using System.Windows.Forms;
using TakeCareOfPlants.Forms;
using TakeCareOfPlants.Reports;

namespace TakeCareOfPlants
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ReportCostVsStatus_GUI());
        }
    }
}
