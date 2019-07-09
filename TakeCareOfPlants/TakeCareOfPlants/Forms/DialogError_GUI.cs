using System;
using System.Drawing;
using System.Windows.Forms;

namespace TakeCareOfPlants
{
    public partial class DialogError_GUI : Form
    {
        private static DialogError_GUI dialogError;
        private string errorText;

        public DialogError_GUI()
        {
            InitializeComponent();
        }

        public static DialogError_GUI Instance
        {
            get {
                if (dialogError == null) {
                    dialogError = new DialogError_GUI();
                }
                return dialogError;
            }
        }

        public string ErrorText { get => errorText; set => errorText = value; }

        private void DialogError_GUI_Load(object sender, EventArgs e)
        {
            dialogError = this;
            Error_Text.Text = errorText;
            FormErrorFadeTransition.ShowAsyc(dialogError);
            dialogError.BringToFront();
        }

        private void FormErrorFadeTransition_TransitionEnd(object sender, EventArgs e)
        {
            Time_Show_Button.Start();
            Error_Box.Visible = true;
            Error_Box.Enabled = true;
            Error_Text.Visible = true;
        }

        private void Time_Show_Button_Tick(object sender, EventArgs e)
        {
            Time_Show_Button.Stop();
            OK_Button.Visible = true;
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            dialogError = this;
            Function_GUI.HidePage(dialogError);
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
