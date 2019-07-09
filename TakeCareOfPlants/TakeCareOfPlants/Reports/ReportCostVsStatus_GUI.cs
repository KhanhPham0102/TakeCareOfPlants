using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;
using TakeCareOfPlants_BUS;

namespace TakeCareOfPlants.Reports
{
    public partial class ReportCostVsStatus_GUI : Form
    {
        private static ReportCostVsStatus_GUI pageReport;
        private readonly CayCanh_BUS cayCanhBUS = new CayCanh_BUS();
        private readonly Lich_BUS lichBUS = new Lich_BUS();

        public static ReportCostVsStatus_GUI Instance
        {
            get {
                if (pageReport == null) {
                    pageReport = new ReportCostVsStatus_GUI();
                }
                return pageReport;
            }
        }

        public bool IsCostOrStatus { get; set; }

        public ReportCostVsStatus_GUI()
        {
            InitializeComponent();
        }

        private void ReportCostVsStatus_GUI_Load(object sender, EventArgs e)
        {
            pageReport = this;
        }

        private void Export_Button_Click(object sender, EventArgs e)
        {
            if (IsCostOrStatus) {
                try {
                    ReportParameter[] reportParameters = new ReportParameter[] {
                        new ReportParameter("monthCost", Month_ComboBox.selectedValue),
                    };

                    ReportDataSource report = new ReportDataSource(
                        "ReportCareCost",
                        lichBUS.GetCostCare(month: int.Parse(Month_ComboBox.selectedValue)));

                    Report_Viewer.ProcessingMode = ProcessingMode.Local;

                    Report_Viewer.LocalReport.ReportPath = "Reports/ReportCareCost_Report.rdlc";
                    Report_Viewer.LocalReport.DataSources.Clear();
                    Report_Viewer.LocalReport.DataSources.Add(report);
                    Report_Viewer.LocalReport.SetParameters(reportParameters);
                    Report_Viewer.LocalReport.Refresh();
                    Report_Viewer.RefreshReport();
                } catch (Exception ex) {
                    Function_GUI.ShowErrorDialog(ex.Message);
                }
            } else {
                try {
                    ReportParameter[] reportParameters = new ReportParameter[] {
                        new ReportParameter("monthStatus", Month_ComboBox.selectedValue),
                    };

                    ReportDataSource report = new ReportDataSource(
                        "ReportPlantStatus",
                        cayCanhBUS.GetPlantStatus(month: int.Parse(Month_ComboBox.selectedValue)));

                    Report_Viewer.ProcessingMode = ProcessingMode.Local;

                    Report_Viewer.LocalReport.ReportPath = "Reports/ReportPlantStatus_Report.rdlc";
                    Report_Viewer.LocalReport.DataSources.Clear();
                    Report_Viewer.LocalReport.DataSources.Add(report);
                    Report_Viewer.LocalReport.SetParameters(reportParameters);
                    Report_Viewer.LocalReport.Refresh();
                    Report_Viewer.RefreshReport();
                } catch (Exception ex) {
                    Function_GUI.ShowErrorDialog(ex.Message);
                }
            }
        }
    }
}
