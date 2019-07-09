using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TakeCareOfPlants_BUS;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants.Reports
{
    public partial class ListCalendar_GUI : Form
    {
        private static ListCalendar_GUI pageReportCalendar;
        private readonly Lich_BUS lichBUS = new Lich_BUS();
        private readonly CayCanh_BUS cayCanhBUS = new CayCanh_BUS();
        private List<CayCanh_DTO> cayCanh_DTOs = new List<CayCanh_DTO>();
        private List<Lich_DTO> lich_DTOs = new List<Lich_DTO>();

        public static ListCalendar_GUI Instance
        {
            get {
                if (pageReportCalendar == null) {
                    pageReportCalendar = new ListCalendar_GUI();
                }
                return pageReportCalendar;
            }
        }

        public ListCalendar_GUI()
        {
            InitializeComponent();
        }

        private void ListCalendar_GUI_Load(object sender, EventArgs e)
        {
            pageReportCalendar = this;

            CayCanh_ComboBox.Items.Clear();
            NgayLapLich_DropDown.Items.Clear();

            CayCanh_ComboBox.Items.Add("- Select -");
            NgayLapLich_DropDown.Items.Add("- Select -");

            try {
                cayCanh_DTOs = cayCanhBUS.GetValueCayCanhViTri().Select(x => x.Item1).ToList();
                lich_DTOs = lichBUS.GetListLich();

                foreach (CayCanh_DTO cayCanh in cayCanh_DTOs) {
                    CayCanh_ComboBox.Items.Add(cayCanh.TenCay);
                }

                foreach (Lich_DTO lich in lich_DTOs) {
                    NgayLapLich_DropDown.Items.Add(lich.NgayLapLich.ToString("yyyy-MM-dd"));
                }
            } catch (Exception ex) {
                Function_GUI.ShowErrorDialog(ex.Message);
            }
        }

        private void Export_Button_Click(object sender, EventArgs e)
        {
            bool isSuccess = true;

            if (NgayLapLich_DropDown.selectedIndex == 0) {
                isSuccess = false;
                CayCanh_ComboBox.ForeColor = Color.Red;
            }
            if (NgayLapLich_DropDown.selectedIndex == 0) {
                isSuccess = false;
                NgayLapLich_DropDown.ForeColor = Color.Red;
            }

            try {
                if (isSuccess) {
                    ReportParameter[] reportParameters = new ReportParameter[] {
                        new ReportParameter("tenCay", CayCanh_ComboBox.selectedValue),
                        new ReportParameter("ngayLapLich", NgayLapLich_DropDown.selectedValue)
                    };

                    ReportDataSource report = new ReportDataSource(
                        "ListCareCalendar",
                        lichBUS.GetAllValuaLich(idCay: cayCanh_DTOs[index: CayCanh_ComboBox.selectedIndex - 1].Id,
                                                idLich: lich_DTOs[index: NgayLapLich_DropDown.selectedIndex - 1].Id));

                    Report_Calendar_Viewer.ProcessingMode = ProcessingMode.Local;

                    Report_Calendar_Viewer.LocalReport.ReportPath = "Reports/ListCareCalendar_Report.rdlc";
                    Report_Calendar_Viewer.LocalReport.DataSources.Clear();
                    Report_Calendar_Viewer.LocalReport.DataSources.Add(report);
                    Report_Calendar_Viewer.LocalReport.SetParameters(reportParameters);
                    Report_Calendar_Viewer.LocalReport.Refresh();
                    Report_Calendar_Viewer.RefreshReport();
                }
            } catch (Exception ex) {
                Function_GUI.ShowErrorDialog(ex.Message);
            }
        }

        private void CayCanh_ComboBox_onItemSelected(object sender, EventArgs e)
        {
            CayCanh_ComboBox.ForeColor = Color.Black;
        }

        private void NgayLapLich_DropDown_onItemSelected(object sender, EventArgs e)
        {
            NgayLapLich_DropDown.ForeColor = Color.Black;
        }
    }
}
