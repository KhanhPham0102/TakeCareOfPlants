using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TakeCareOfPlants_BUS;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants
{
    public partial class UI_Care : UserControl
    {
        private static UI_Care uiCare;
        private readonly Lich_BUS lichBUS = new Lich_BUS();
        private readonly List<int> listSTT = new List<int>();

        public UI_Care()
        {
            InitializeComponent();
        }

        public static UI_Care Instance
        {
            get {
                if (uiCare == null) {
                    uiCare = new UI_Care();
                }
                return uiCare;
            }
        }

        public BunifuCustomDataGrid TableCalendar
        {
            get => List_Calendar_DataGrid;

            set => List_Calendar_DataGrid = value;
        }

        private void UI_Care_Load(object sender, EventArgs e)
        {
            uiCare = this;
        }

        private void List_Calendar_DataGrid_CellPainting(object sender,
                                                         DataGridViewCellPaintingEventArgs e)
        {
            if (e == null) {
                throw new ArgumentNullException(nameof(e));
            }

            if (e.RowIndex != -1) {
                e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
                if (e.RowIndex < 1 || e.ColumnIndex < 0) {
                    return;
                }

                e.AdvancedBorderStyle.Top = Function_GUI.IsTheSameCellValue(List_Calendar_DataGrid, e.ColumnIndex, e.RowIndex)
                                            && new List<int> { 0, 1, 6 }.Contains(e.ColumnIndex)
                    ? DataGridViewAdvancedCellBorderStyle.None
                    : List_Calendar_DataGrid.AdvancedCellBorderStyle.Top;
            }
        }

        private void List_Calendar_DataGrid_CellFormatting(object sender,
                                                           DataGridViewCellFormattingEventArgs e)
        {
            if (sender == null) {
                throw new ArgumentNullException(nameof(sender));
            }

            if (e.RowIndex == 0) {
                return;
            }

            if (Function_GUI.IsTheSameCellValue(List_Calendar_DataGrid, e.ColumnIndex, e.RowIndex)) {
                if (new List<int> { 0, 1, 6 }.Contains(e.ColumnIndex)) {
                    e.Value = "";
                    e.FormattingApplied = true;
                }
            }
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            PageMain_GUI.Instance.TitlePage.Text = "Calendar";
            UI_Calendar.Instance.Update();

            Function_GUI.ShowControl(UI_Calendar.Instance);
        }

        private void Get_All_Button_Click(object sender, EventArgs e)
        {
            int index = 1;
            List<Tuple<Lich_DTO, TimeSpan, string, string, int, string>> listCalendar;

            try {
                listCalendar = lichBUS.GetValueLich();
                listCalendar = listCalendar.OrderBy(x => x.Item1.Id).ToList();

                foreach (Tuple<Lich_DTO, TimeSpan, string, string, int, string> tuple in listCalendar) {
                    List_Calendar_DataGrid.Rows.Add(
                        index,
                        tuple.Item1.NgayLapLich.Date,
                        tuple.Item2,
                        tuple.Item3,
                        tuple.Item4,
                        tuple.Item5,
                        tuple.Item6);

                    if (List_Calendar_DataGrid.Rows.Count > 1
                        && !List_Calendar_DataGrid.Rows[List_Calendar_DataGrid.Rows.Count - 1].Cells[1].Value.Equals(List_Calendar_DataGrid.Rows[List_Calendar_DataGrid.Rows.Count - 2].Cells[1].Value)) {
                        index++;
                        List_Calendar_DataGrid.Rows[List_Calendar_DataGrid.Rows.Count - 1].Cells[0].Value = index;
                    }

                    listSTT.Add(index);
                }

            } catch (Exception ex) {
                Function_GUI.ShowErrorDialog(ex.Message);
            }
        }

        private void List_Calendar_DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (sender == null) {
                throw new ArgumentNullException(nameof(sender));
            }

            List_Calendar_DataGrid.MultiSelect = true;

            if (e.RowIndex < 1 || e.ColumnIndex < 0) {
                return;
            }

            List<int> listIndex = new List<int>();

            for (int i=0; i < listSTT.Count; i++) {
                if (listSTT[i] == listSTT[e.RowIndex]) {
                    listIndex.Add(i);
                }
            }

            foreach (int index in listIndex) {
                List_Calendar_DataGrid[e.ColumnIndex, index].Selected = true;
            }
        }

        private void List_Calendar_DataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PageMain_GUI.Instance.TitlePage.Text = "Calendar";
            UI_Calendar.Instance.Update();

            Function_GUI.ShowControl(UI_Calendar.Instance);

        }
    }
}
