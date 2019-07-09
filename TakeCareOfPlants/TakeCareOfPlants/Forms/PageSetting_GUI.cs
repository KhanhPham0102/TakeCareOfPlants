using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using TakeCareOfPlants_BUS;
using TakeCareOfPlants_DTO;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Data;

namespace TakeCareOfPlants
{
    public partial class PageSetting_GUI : Form
    {
        private static PageSetting_GUI pageSetting;
        private List<int> maxPlant;
        private List<ViTri_DTO> list_ViTri_DTO;

        public PageSetting_GUI()
        {
            InitializeComponent();
        }

        public static PageSetting_GUI Instance
        {
            get {
                if (pageSetting == null) {
                    pageSetting = new PageSetting_GUI();
                }
                return pageSetting;
            }
        }

        private void PageSetting_GUI_Load(object sender, EventArgs e)
        {
            pageSetting = this;
            NumberPlant_DropDown.Items.Clear();

            list_ViTri_DTO = GlobalVariable_DTO.ViTri_DTOs;

            foreach (ViTri_DTO viTriDTO in list_ViTri_DTO) {
                NumberPlant_DropDown.Items.Add(viTriDTO.TenViTri);
            }

            maxPlant = list_ViTri_DTO.Select(s => s.SoCayToiDa).ToList();
            NumberPlant_DropDown_Set(maxPlant, 1);
        }

        private void Default_Button_Click(object sender, EventArgs e)
        {
            maxPlant = list_ViTri_DTO.Select(s => s.SoCayCoSan).ToList();
            NumberPlant_DropDown_Set(maxPlant, 0);
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled)) {
                switch (MessageBox.Show(
                        "Are you sure you want to Save?",
                        "Confirmation",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Information)) {
                    case DialogResult.OK: {
                            try {
                                GlobalVariable_DTO.QuyDinh_DTOs[1] = new QuyDinh_DTO {
                                    SoLoaiVatTu = int.Parse(TypeMaterial_Text.Text),
                                    SoTienToiDa = (long)decimal.Parse(
                                        AmountMoney_Text.Text,
                                        NumberStyles.Currency)
                                };

                                QuyDinh_BUS.UpdateValueQuyDinh(list_ViTri_DTO);
                                DialogSuccess_GUI.Instance.ShowDialog();
                            } catch (Exception ex) {
                                Function_GUI.ShowErrorDialog(ex.Message);
                            }
                            break;
                        }
                    case DialogResult.Cancel: {
                            new CancelEventArgs().Cancel = true;
                            break;
                        }
                }
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            pageSetting = this;
            Function_GUI.HidePage(pageSetting);
        }

        private void AmountMoney_Text_TextChanged(object sender, EventArgs e)
        {
            if (AmountMoney_Text.Text != "") {
                AmountMoney_Text.Text = string.Format(
                    "{0:#,#}",
                    double.Parse(AmountMoney_Text.Text));
                AmountMoney_Text.SelectionStart = AmountMoney_Text.Text.Length;
            }
        }

        private void NumberPlant_Text_KeyPress(object sender,
                                               KeyPressEventArgs e)
        {
            Function_GUI.IsNumberic(e);
            NumberPlant_Text.MaxLength = 2;
        }

        private void TypeMaterial_Text_KeyPress(object sender,
                                                KeyPressEventArgs e)
        {
            Function_GUI.IsNumberic(e);
            TypeMaterial_Text.MaxLength = 2;
        }

        private void AmountMoney_Text_KeyPress(object sender,
                                               KeyPressEventArgs e)
        {
            Function_GUI.IsNumberic(e);
        }

        private void NumberPlant_DropDown_KeyDown(object sender,
                                                  KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                foreach (ViTri_DTO viTriDTO in list_ViTri_DTO) {
                    if (viTriDTO.TenViTri == NumberPlant_DropDown.Text) {
                        NumberPlant_Text.Enabled = true;
                        return;
                    }
                };

                NumberPlant_Text.Text = "";
                NumberPlant_Text.Enabled = false;
            }
        }

        private void NumberPlant_DropDown_SelectedIndexChanged(object sender,
                                                               PositionChangedEventArgs e)
        {
            NumberPlant_Text.Enabled = true;

            try {
                if (NumberPlant_DropDown.Text != "") {
                    NumberPlant_Text.Text = maxPlant[e.Position].ToString();
                }
            } catch (Exception) {
                NumberPlant_Text.Text = "";
            }
        }

        private void NumberPlant_DropDown_VisualListItemFormatting(object sender,
                                                                   VisualItemFormattingEventArgs args)
        {
            if (sender == null) {
                throw new ArgumentNullException(nameof(sender));
            }

            args.VisualItem.Font = new Font(
                family: NumberPlant_DropDown.Font.FontFamily,
                emSize: 12);
        }

        private void NumberPlant_Text_TextChanged(object sender, EventArgs e)
        {
            if (NumberPlant_Text.Text != "") {
                list_ViTri_DTO[NumberPlant_DropDown.SelectedIndex].SoCayToiDa = int.Parse(NumberPlant_Text.Text);
            }
        }

        private void NumberPlant_Text_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NumberPlant_Text.Text)) {
                e.Cancel = true;
                NumberPlant_Text.Focus();
                Error_Provider.SetError(
                    NumberPlant_Text,
                    "Please select your plant location or enter your number plant !");
            } else {
                e.Cancel = false;
                Error_Provider.SetError(NumberPlant_Text, null);
            }
        }

        private void TypeMaterial_Text_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TypeMaterial_Text.Text)) {
                e.Cancel = true;
                TypeMaterial_Text.Focus();
                Error_Provider.SetError(
                    TypeMaterial_Text,
                    "Please enter your type material !");
            } else {
                e.Cancel = false;
                Error_Provider.SetError(TypeMaterial_Text, null);
            }
        }

        private void AmountMoney_Text_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(AmountMoney_Text.Text)) {
                e.Cancel = true;
                AmountMoney_Text.Focus();
                Error_Provider.SetError(
                    AmountMoney_Text,
                    "Please enter your amount money !");
            } else {
                e.Cancel = false;
                Error_Provider.SetError(AmountMoney_Text, null);
            }
        }

        private void NumberPlant_DropDown_Set(List<int> soCayToiDa, int index)
        {
            NumberPlant_Text.Text = soCayToiDa[NumberPlant_DropDown.SelectedIndex = 0].ToString();
            TypeMaterial_Text.Text = GlobalVariable_DTO.QuyDinh_DTOs[index].SoLoaiVatTu.ToString();
            AmountMoney_Text.Text = string.Format("{0:#,#}", GlobalVariable_DTO.QuyDinh_DTOs[index].SoTienToiDa);
        }

        protected override CreateParams CreateParams
        {
            get {
                CreateParams cp = base.CreateParams;
                if (!Function_GUI.CheckAeroEnabled()) {
                    cp.ClassStyle |= (int)Function_GUI.ShadowBorder.CS_DROPSHADOW;
                }
                return cp;
            }
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg) {
                case (int)Function_GUI.ShadowBorder.WM_NCPAINT:
                    if (Function_GUI.CheckAeroEnabled()) {
                        int v = 2;
                        Function_GUI.DwmSetWindowAttribute(Handle, 2, ref v, 4);
                        Function_GUI.MARGINS margins = new Function_GUI.MARGINS() {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        };
                        Function_GUI.DwmExtendFrameIntoClientArea(Handle, ref margins);
                    }
                    break;
                default:
                    break;
            }

            if (m.Msg == (int)Function_GUI.ShadowBorder.WM_NCLBUTTONDBLCLK) {
                m.Result = IntPtr.Zero;
                return;
            }

            base.WndProc(ref m);
            if (m.Msg == (int)Function_GUI.ShadowBorder.WM_NCHITTEST && (int)m.Result == (int)Function_GUI.ShadowBorder.HTCLIENT) {
                m.Result = (IntPtr)Function_GUI.ShadowBorder.HTCAPTION;
            }
        }
    }
}
