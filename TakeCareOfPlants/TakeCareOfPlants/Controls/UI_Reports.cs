using System;
using System.Windows.Forms;
using TakeCareOfPlants.Forms;
using TakeCareOfPlants.Reports;

namespace TakeCareOfPlants
{
    public partial class UI_Reports : UserControl
    {
        private static UI_Reports uiReports;

        public UI_Reports()
        {
            InitializeComponent();
        }

        public static UI_Reports Instance
        {
            get {
                if (uiReports == null) {
                    uiReports = new UI_Reports();
                }
                return uiReports;
            }
        }

        private void ListPlant_ImageButton_Click(object sender, EventArgs e)
        {
            ListPlant_GUI.Instance.ShowDialog();
        }

        private void ReportCost_ImageButton_Click(object sender, EventArgs e)
        {
            ReportCostVsStatus_GUI.Instance.ShowDialog();
            ReportCostVsStatus_GUI.Instance.IsCostOrStatus = true;
        }

        private void ListCalendar_ImageButton_Click(object sender, EventArgs e)
        {
            ListCalendar_GUI.Instance.ShowDialog();
        }

        private void ReportStatus_ImageButton_Click(object sender, EventArgs e)
        {
            ReportCostVsStatus_GUI.Instance.ShowDialog();
            ReportCostVsStatus_GUI.Instance.IsCostOrStatus = false;
        }
    }
}
