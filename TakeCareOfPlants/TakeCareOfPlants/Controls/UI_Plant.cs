using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TakeCareOfPlants_BUS;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants
{
    public partial class UI_Plant : UserControl
    {
        private static UI_Plant uiPlant;
        private readonly CayCanh_BUS cayCanhBUS = new CayCanh_BUS();
        private readonly Dictionary<int, string> listIDCayCanh = new Dictionary<int, string>();
        private readonly List<string> listIDLoai = new List<string>();
        private readonly List<string> listIDTinhTrang = new List<string>();

        public static UI_Plant Instance
        {
            get {
                if (uiPlant == null) {
                    uiPlant = new UI_Plant();
                }
                return uiPlant;
            }
        }

        public int Index { get; set; }

        public UI_Plant()
        {
            InitializeComponent();
        }

        private void UI_Plant_Load(object sender, EventArgs e)
        {
            uiPlant = this;
            Name_Plant_Text.Focus();
            Function_GUI.ChangeColorButton(Create_Button, Update_Button);

            try {
                foreach (ViTri_DTO viTriDTO in GlobalVariable_DTO.ViTri_DTOs) {
                    Planting_Location_ComboBox.AddItem(viTriDTO.TenViTri);
                }

                foreach (Loai_DTO loaiDTO in cayCanhBUS.GetValueLoai()) {
                    listIDLoai.Add(loaiDTO.Id);
                    Type_Of_Plant_ComboBox.AddItem(loaiDTO.Loai);
                }

                foreach (TinhTrang_DTO tinhTrangDTO in cayCanhBUS.GetValueTinhTrang()) {
                    listIDTinhTrang.Add(tinhTrangDTO.Id);
                    Status_ComboBox.AddItem(tinhTrangDTO.TinhTrang);
                }
            } catch (Exception ex) {
                Function_GUI.ShowErrorDialog(ex.Message);
            }

            Planing_Data_DateTime.Value = DateTime.Now;
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            bool createSuccess = true;

            if (string.IsNullOrEmpty(Name_Plant_Text.Text)) {
                Name_Plant_Text.HintForeColor = Color.Red;
                createSuccess = false;
            }

            if (Type_Of_Plant_ComboBox.selectedIndex == 0) {
                Type_Of_Plant_ComboBox.ForeColor = Color.Red;
                createSuccess = false;
            }

            if (Planting_Location_ComboBox.selectedIndex == 0) {
                Planting_Location_ComboBox.ForeColor = Color.Red;
                createSuccess = false;
            }

            if (Status_ComboBox.selectedIndex == 0) {
                Status_ComboBox.ForeColor = Color.Red;
                createSuccess = false;
            }
            if (createSuccess) {
                try {
                    ViTri_DTO viTri = GlobalVariable_DTO.ViTri_DTOs[index: Planting_Location_ComboBox.selectedIndex - 1];
                    Loai_DTO loaiDTO = cayCanhBUS.GetValueLoaiWithId(id: listIDLoai[index: Type_Of_Plant_ComboBox.selectedIndex - 1]);
                    TinhTrang_DTO tinhTrangDTO = cayCanhBUS.GetValueTinhTrangWithId(id: listIDTinhTrang[Status_ComboBox.selectedIndex - 1]);

                    CayCanh_DTO cayCanhDTO = new CayCanh_DTO(tenCay: Name_Plant_Text.Text,
                                                             loai_DTO: loaiDTO,
                                                             tinhTrang_DTO: tinhTrangDTO,
                                                             ngayTrong: Planing_Data_DateTime.Value);

                    cayCanhBUS.InsertValueCayCanh(cayCanhDTO,
                                                  viTri.Id);

                    List_Plant_DataGrid.Rows.Add(List_Plant_DataGrid.Rows.Count + 1,
                                                 cayCanhDTO.TenCay,
                                                 loaiDTO.Loai,
                                                 viTri.TenViTri,
                                                 tinhTrangDTO.TinhTrang,
                                                 cayCanhDTO.NgayTrong.ToString("dd/MM/yyyy"));

                    listIDCayCanh.Add(key: List_Plant_DataGrid.Rows.Count,
                                      value: cayCanhBUS.LastIDCayCanh());

                    Function_GUI.SetImageNotifiAsync(true, "Create");
                } catch (Exception ex) {
                    Function_GUI.ShowErrorDialog(ex: ex.Message);
                }
            } else {
                Function_GUI.SetImageNotifiAsync(false, "Data Is Not NULL");
            }
        }

        private void List_Plant_DataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (List_Plant_DataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) {
                List_Plant_DataGrid.CurrentRow.Selected = true;

                Name_Plant_Text.Text = List_Plant_DataGrid
                    .Rows[e.RowIndex]
                    .Cells["Column2"]
                    .FormattedValue.ToString();

                Type_Of_Plant_ComboBox.selectedIndex =
                    Type_Of_Plant_ComboBox.Items.IndexOf(
                        value: List_Plant_DataGrid
                        .Rows[e.RowIndex]
                        .Cells["Column3"]
                        .FormattedValue.ToString());

                Planting_Location_ComboBox.selectedIndex =
                    Planting_Location_ComboBox.Items.IndexOf(
                        value: List_Plant_DataGrid
                        .Rows[e.RowIndex]
                        .Cells["Column4"]
                        .FormattedValue.ToString());

                Status_ComboBox.selectedIndex =
                    Status_ComboBox.Items.IndexOf(
                        value: List_Plant_DataGrid
                        .Rows[e.RowIndex]
                        .Cells["Column5"]
                        .FormattedValue.ToString());

                string time = List_Plant_DataGrid
                    .Rows[e.RowIndex]
                    .Cells["Column6"]
                    .FormattedValue.ToString();

                Planing_Data_DateTime.Value = DateTime.ParseExact(time,
                                                                  "dd/MM/yyyy",
                                                                  null);
            }

            Function_GUI.ChangeColorButton(Update_Button, Create_Button);
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Function_GUI.ChangeColorButton(Create_Button, Update_Button);

            Name_Plant_Text.Text = "";
            Name_Plant_Text.Focus();
            Type_Of_Plant_ComboBox.selectedIndex = 0;
            Planting_Location_ComboBox.selectedIndex = 0;
            Status_ComboBox.selectedIndex = 0;
            Planing_Data_DateTime.Value = DateTime.Now;
        }

        private void Name_Plant_Text_OnValueChanged(object sender, EventArgs e)
        {
            Name_Plant_Text.HintForeColor = Color.Black;
            if (string.IsNullOrEmpty(Name_Plant_Text.Text)) {
                Name_Plant_Text.Focus();
            }
        }

        private void Type_Of_Plant_ComboBox_onItemSelected(object sender, EventArgs e)
        {
            Type_Of_Plant_ComboBox.ForeColor = Color.Black;
        }

        private void Planting_Location_ComboBox_onItemSelected(object sender, EventArgs e)
        {
            Planting_Location_ComboBox.ForeColor = Color.Black;
        }

        private void Status_ComboBox_onItemSelected(object sender, EventArgs e)
        {
            Status_ComboBox.ForeColor = Color.Black;
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            try {
                cayCanhBUS.UpdateValueCayCanhWithId(
                    listIDCayCanh[List_Plant_DataGrid.CurrentRow.Index + 1],
                    Name_Plant_Text.Text,
                    GlobalVariable_DTO.ViTri_DTOs[Planting_Location_ComboBox.selectedIndex - 1].Id,
                    listIDLoai[Type_Of_Plant_ComboBox.selectedIndex - 1],
                    listIDTinhTrang[Status_ComboBox.selectedIndex - 1],
                    Planing_Data_DateTime.Value);

                List_Plant_DataGrid.CurrentRow.Cells[1].Value = Name_Plant_Text.Text;
                List_Plant_DataGrid.CurrentRow.Cells[2].Value = Type_Of_Plant_ComboBox.selectedValue;
                List_Plant_DataGrid.CurrentRow.Cells[3].Value =
                    GlobalVariable_DTO.ViTri_DTOs[Planting_Location_ComboBox.selectedIndex - 1].TenViTri;
                List_Plant_DataGrid.CurrentRow.Cells[4].Value = Status_ComboBox.selectedValue;
                List_Plant_DataGrid.CurrentRow.Cells[5].Value = Planing_Data_DateTime.Value.ToString("dd-MM-yyyy");

                Function_GUI.SetImageNotifiAsync(true, "Create");
            } catch (Exception ex) {
                Function_GUI.ShowErrorDialog(ex.Message);
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            try {
                cayCanhBUS.DeleteValueCayCanh(listIDCayCanh[List_Plant_DataGrid.CurrentRow.Index + 1]);

                foreach (DataGridViewRow item in List_Plant_DataGrid.SelectedRows) {
                    listIDCayCanh.Remove(item.Index + 1);
                    List_Plant_DataGrid.Rows.RemoveAt(item.Index);
                }

                Function_GUI.SetImageNotifiAsync(true, "Create");
            } catch (Exception ex) {
                Function_GUI.ShowErrorDialog(ex.Message);
            }
        }
    }
}
