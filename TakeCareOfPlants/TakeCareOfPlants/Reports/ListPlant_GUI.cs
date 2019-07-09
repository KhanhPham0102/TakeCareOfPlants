using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;
using TakeCareOfPlants_BUS;

namespace TakeCareOfPlants.Forms
{
    public partial class ListPlant_GUI : Form
    {
        private static ListPlant_GUI pageReportPlant;
        private readonly CayCanh_BUS cayCanhBUS = new CayCanh_BUS();

        public static ListPlant_GUI Instance
        {
            get {
                if (pageReportPlant == null) {
                    pageReportPlant = new ListPlant_GUI();
                }
                return pageReportPlant;
            }
        }

        public ListPlant_GUI()
        {
            InitializeComponent();
        }

        private void ListPlant_GUI_Load(object sender, EventArgs e)
        {
            pageReportPlant = this;
            try {
                ReportDataSource report = new ReportDataSource(
                    "ListPlant",
                    cayCanhBUS.GetAllValueCayCanh());

                ListPlant_ReportViewer.ProcessingMode = ProcessingMode.Local;

                ListPlant_ReportViewer.LocalReport.ReportPath = "Reports/ListPlant_Report.rdlc";
                ListPlant_ReportViewer.LocalReport.DataSources.Clear();
                ListPlant_ReportViewer.LocalReport.DataSources.Add(report);
                ListPlant_ReportViewer.LocalReport.Refresh();
                ListPlant_ReportViewer.RefreshReport();
            } catch (Exception ex) {
                Function_GUI.ShowErrorDialog(ex.Message);
            }
        }
    }
}
