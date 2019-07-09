using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using TakeCareOfPlants_BUS;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants
{
    public partial class UI_Materials : UserControl
    {
        private static UI_Materials uiMaterials;
        private VatTu_BUS vatTuBUS = new VatTu_BUS();
        private DateTimePicker dtp = new DateTimePicker();

        private Rectangle Rectangle { get; set; }
        private TextBox Tb { get; set; }
        private TextBox TbMaterial { get; set; }
        private TextBox TbUnit { get; set; }
        private DataGridViewCell DataGridViewCell { get; set; }

        public static UI_Materials Instance
        {
            get {
                if (uiMaterials == null) {
                    uiMaterials = new UI_Materials();
                }
                return uiMaterials;
            }
        }

        public UI_Materials()
        {
            InitializeComponent();
        }

        private void UI_Materials_Load(object sender, EventArgs e)
        {
            uiMaterials = this;
            Coupon_DataGrid.Controls.Add(dtp);
            dtp.Visible = false;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "dd-MM-yyyy";
            dtp.TextChanged += Time_Purchase_TextChanged;
            dtp.PreviewKeyDown += Time_Purchase_PreviewKeyDown;
        }

        private void Coupon_DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && Coupon_DataGrid.Columns[e.ColumnIndex].Name == "Time_Purchase") {
                Rectangle = Coupon_DataGrid.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                if (Coupon_DataGrid.CurrentCell.Value == null) {
                    dtp.Value = DateTime.Now;
                    Coupon_DataGrid.CurrentCell.Value = dtp.Value.ToString("dd-MM-yyyy");
                } else {
                    dtp.Value = DateTime.ParseExact(Coupon_DataGrid.CurrentCell.Value.ToString(), "dd-MM-yyyy", null);
                }
                dtp.Size = new Size(Rectangle.Width, Rectangle.Height);
                dtp.Location = new Point(Rectangle.X, Rectangle.Y);
                dtp.Visible = true;
                DataGridViewCell = Coupon_DataGrid.CurrentCell;
            } else {
                dtp.Visible = false;
            }
        }

        private void Coupon_DataGrid_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            dtp.Visible = false;
        }

        private void Coupon_DataGrid_Scroll(object sender, ScrollEventArgs e)
        {
            dtp.Visible = false;
        }

        private void Coupon_DataGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            switch (Coupon_DataGrid.CurrentCell.ColumnIndex) {
                case 0:
                    e.Control.KeyPress -= Amount_KeyPress;
                    e.Control.KeyPress -= Money_KeyPress;
                    e.Control.KeyPress += Material_KeyPress;

                    TbMaterial = (TextBox)e.Control;
                    AutoCompleteStringCollection autoCompleteMaterial = new AutoCompleteStringCollection();
                    Generic_GUI<VatTu_DTO, VatTu_BUS> generic_Material = new Generic_GUI<VatTu_DTO, VatTu_BUS>();
                    generic_Material.AutoCompleteCell(TbMaterial, autoCompleteMaterial);
                    break;
                case 1:
                    e.Control.KeyPress -= Amount_KeyPress;
                    e.Control.KeyPress -= Money_KeyPress;

                    TbUnit = (TextBox)e.Control;
                    AutoCompleteStringCollection autoCompleteUnit = new AutoCompleteStringCollection();
                    Generic_GUI<DonVi_DTO, VatTu_BUS> generic_Unit = new Generic_GUI<DonVi_DTO, VatTu_BUS>();
                    generic_Unit.AutoCompleteCell(TbUnit, autoCompleteUnit);
                    break;
                case 4:
                    e.Control.KeyPress -= Material_KeyPress;
                    e.Control.KeyPress -= Money_KeyPress;
                    e.Control.KeyPress += Amount_KeyPress;
                    break;
                case 5:
                    e.Control.KeyPress -= Material_KeyPress;
                    e.Control.KeyPress -= Amount_KeyPress;
                    e.Control.KeyPress += Money_KeyPress;

                    Tb = (TextBox)e.Control;
                    Tb.TextChanged += new EventHandler(Money_TextChanged);
                    break;
            }
        }

        private void Material_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function_GUI.IsLetter(e);
        }

        private void Money_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function_GUI.IsNumberic(e);
        }

        private void Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function_GUI.IsNumberic(e);
        }

        private void Money_TextChanged(object sender, EventArgs e)
        {
            if (Tb.Text != "" && Coupon_DataGrid.CurrentCell.ColumnIndex == 5) {
                Tb.Text = string.Format("{0:#,#}", double.Parse(Tb.Text));
                Tb.SelectionStart = Tb.Text.Length;
            }
        }

        private void Time_Purchase_TextChanged(object sender, EventArgs e)
        {
            if (Coupon_DataGrid.CurrentCell == DataGridViewCell) {
                Coupon_DataGrid.CurrentCell.Value = dtp.Text;
            }
        }

        private void Time_Purchase_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter) {
                Coupon_DataGrid.CurrentCell.Value = dtp.Text;
                dtp.Visible = false;
            }
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            //List<List<>>
            foreach (DataGridViewRow row in Coupon_DataGrid.Rows) {
                foreach (DataGridViewCell cell in row.Cells) {
                    string value = cell.Value.ToString();

                }
            }
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Coupon_DataGrid.Rows.Clear();
            Coupon_DataGrid.Refresh();
        }
    }
}
