using System;
using System.Windows.Forms;

namespace TakeCareOfPlants
{
    public partial class Amount_GUI : Form
    {
        private static Amount_GUI amountGUI;
        private string title;
        private int amount;

        public Amount_GUI()
        {
            InitializeComponent();
        }

        public static Amount_GUI Instance
        {
            get {
                if (amountGUI == null) {
                    amountGUI = new Amount_GUI();
                }
                return amountGUI;
            }
        }

        public string Title { get => title; set => title = value; }

        public int Amount { get => amount; set => amount = value; }

        private void Amount_GUI_Load(object sender, EventArgs e)
        {
            Amount_Title.Text = "Amount " + title + ":";
            Amount_Text.Text = amount.ToString();
        }

        private void NumberPlant_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function_GUI.IsNumberic(e);
        }

        private void Amount_Text_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Function_GUI.KeyEnterIsButton(OK_Button, e);
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            amount = int.Parse(Amount_Text.Text);
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
