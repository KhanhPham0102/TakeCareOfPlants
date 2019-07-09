using Bunifu.Framework.UI;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace TakeCareOfPlants
{
    public static class Function_GUI
    {
        [DllImport("user32")]
        private static extern bool AnimateWindow(IntPtr hwnd, int time, AnimateWindowFlags flags);

        [Flags]
        public enum AnimateWindowFlags
        {
            AW_HOR_POSITIVE = 0x00000001,
            AW_HOR_NEGATIVE = 0x00000002,
            AW_VER_POSITIVE = 0x00000004,
            AW_VER_NEGATIVE = 0x00000008,
            AW_CENTER = 0x00000010,
            AW_HIDE = 0x00010000,
            AW_ACTIVATE = 0x00020000,
            AW_SLIDE = 0x00040000,
            AW_BLEND = 0x00080000
        }

        public enum ShadowBorder
        {
            WM_NCHITTEST = 0x84,
            HTCLIENT = 0x1,
            HTCAPTION = 0x2,
            CS_DROPSHADOW = 0x00020000,
            WM_NCPAINT = 0x0085,
            WM_ACTIVATEAPP = 0x001C,
            WM_NCLBUTTONDBLCLK = 0x00A3
        }

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        public static void ShowControl(Control control)
        {
            if (!PageMain_GUI.Instance.PanelController.Controls.Contains(control)) {
                control.Dock = DockStyle.Fill;
                PageMain_GUI.Instance.PanelController.Controls.Add(control);
            }
            control.BringToFront();
        }

        public static void HideShowPage(Form form1, Form form2)
        {
            AnimateWindow(form1.Handle, 1000, AnimateWindowFlags.AW_BLEND | AnimateWindowFlags.AW_HIDE);
            AnimateWindow(form2.Handle, 300, AnimateWindowFlags.AW_BLEND);
            form2.Show();
        }

        public static void HidePage(Form form)
        {
            AnimateWindow(form.Handle, 1000, AnimateWindowFlags.AW_BLEND | AnimateWindowFlags.AW_HIDE);
            form.Visible = false;
        }

        public static void ShowPage(Form form)
        {
            AnimateWindow(form.Handle, 300, AnimateWindowFlags.AW_BLEND);
            form.Show();
        }

        public static void CloseApp()
        {
            switch (MessageBox.Show("Do you want to close this app?", "Close App", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) {
                case DialogResult.Yes: {
                        Application.Exit();
                        break;
                    }
                case DialogResult.No: {
                        new CancelEventArgs().Cancel = true;
                        break;
                    }
            }
        }

        public static bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6) {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        public static void HideFormActive(Type formType)
        {
            foreach (Form form in Application.OpenForms) {
                if (form.GetType() != formType) {
                    form.Hide();
                }
            }
        }

        public static void IsNumberic(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar)) {
                e.Handled = true;
            }
        }

        public static void IsLetter(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Space)) {
                e.Handled = true;
            }
        }

        public static void VisualListItem(RadCheckedDropDownList data, VisualItemFormattingEventArgs args)
        {
            args.VisualItem.Font = new Font(family: data.Font.FontFamily, emSize: 12);
            bool itemChecked = ((RadCheckedListDataItem)args.VisualItem.Data).Checked;
            if (itemChecked) {
                args.VisualItem.ForeColor = Color.Green;
            } else {
                args.VisualItem.ForeColor = Color.Red;
            }
        }

        public static void TextBlock(TextBlockFormattingEventArgs e)
        {
            if (e.TextBlock is TokenizedTextBlockElement token) {
                token.ForeColor = Color.DarkBlue;
                token.DrawFill = false;
                token.BorderColor = Color.Red;
                token.BorderWidth = 1.3f;
                token.DrawBorder = false;
                token.BorderGradientStyle = GradientStyles.Solid;
            }
        }

        public static void ShowErrorDialog(string ex)
        {
            DialogError_GUI.Instance.ErrorText = ex;
            DialogError_GUI.Instance.ShowDialog();
        }

        public static void ChangeColorButton(Button button1, Button button2)
        {
            button1.Enabled = true;
            button1.BackColor = Color.RoyalBlue;
            button2.Enabled = false;
            button2.BackColor = Color.LightSlateGray;
        }

        public static bool IsTheSameCellValue(BunifuCustomDataGrid dataGridView, int column, int row)
        {
            DataGridViewCell cell1 = dataGridView[column, row];
            DataGridViewCell cell2 = dataGridView[column, row - 1];

            if (cell1.Value == null || cell2.Value == null) {
                return false;
            }

            return cell1.Value.ToString() == cell2.Value.ToString();
        }

        public static void KeyEnterIsButton(Button button, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter) {
                button.PerformClick();
            }
        }

        public static async void SetImageNotifiAsync(bool isSuccess, string name)
        {
            PageMain_GUI.Instance.ImageNotification.Image = null;
            PageMain_GUI.Instance.TextNotification.Text = "";

            if (isSuccess) {
                PageMain_GUI.Instance.ImageNotification.Image = Properties.Resources._checked;
                PageMain_GUI.Instance.TextNotification.Text = name + " Success";
            } else {
                PageMain_GUI.Instance.ImageNotification.Image = Properties.Resources._cancel;
                PageMain_GUI.Instance.TextNotification.Text = name;
            }

            PageMain_GUI.Instance.ImageNotification.SizeMode = PictureBoxSizeMode.Zoom;

            await Task.Delay(3000);

            PageMain_GUI.Instance.ImageNotification.Image = PageMain_GUI.Instance.ImageNotification.InitialImage;
            PageMain_GUI.Instance.TextNotification.Text = "Ready";
        }
    }
}
