using System;
using System.Drawing;
using System.Windows.Forms;
using TakeCareOfPlants_BUS;

namespace TakeCareOfPlants
{
    public partial class PageSignUp_GUI : Form
    {
        private static PageSignUp_GUI pageSignUp;
        private SignUp_BUS signUpBUS = new SignUp_BUS();

        public PageSignUp_GUI()
        {
            InitializeComponent();
        }

        public static PageSignUp_GUI Instance
        {
            get {
                if (pageSignUp == null) {
                    pageSignUp = new PageSignUp_GUI();
                }
                return pageSignUp;
            }
        }

        private void PageSignUp_GUI_Load(object sender, EventArgs e)
        {
            pageSignUp = this;
            CheckCorrect_Button.Visible = false;
            Error_Title.Visible = false;
        }

        private void Close_Windows_Click(object sender, EventArgs e)
        {
            pageSignUp = this;
            Function_GUI.HideShowPage(pageSignUp, PageLogin_GUI.Instance);
        }

        private void Mini_Windows_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Sign_Up_Button_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            pageSignUp = this;

            if (string.IsNullOrEmpty(User_Name_Text.Text)) {
                User_Name_Text.LineIdleColor = Color.Red;
            }
            if (string.IsNullOrEmpty(Password_Text.Text)) {
                Password_Text.LineIdleColor = Color.Red;
            }
            if (string.IsNullOrEmpty(Confirm_Password_Text.Text)) {
                Confirm_Password_Text.LineIdleColor = Color.Red;
            }
            try {
                if (User_Name_Text.Text != "" && Password_Text.Text != "" && Confirm_Password_Text.Text != "") {
                    if (Function_BUS.CheckPassword(Password_Text.Text)) {
                        if (Password_Text.Text == Confirm_Password_Text.Text) {
                            if (signUpBUS.InsertValueSignUp(User_Name_Text.Text, Password_Text.Text)) {
                                DialogSuccess_GUI.Instance.ShowDialog();
                            } else {
                                Error_Title.Text = "Username is available";
                                Error_Title.Visible = true;
                            }
                        } else {
                            Confirm_Password_Text.LineIdleColor = Color.Red;
                        }
                    } else {
                        Password_Text.LineIdleColor = Color.Red;
                        Error_Title.Text = "Password is invalid";
                        Error_Title.Visible = true;
                    }
                }
            } catch (Exception ex) {
                Function_GUI.ShowErrorDialog(ex.Message);
            }
        }

        private void Confirm_Password_Text_KeyUp(object sender, KeyEventArgs e)
        {
            if (Confirm_Password_Text.Text == Password_Text.Text && Confirm_Password_Text.Text != "") {
                CheckCorrect_Button.Visible = true;
            } else {
                CheckCorrect_Button.Visible = false;
            }
        }

        private void User_Name_Text_OnValueChanged(object sender, EventArgs e)
        {
            Error_Title.Visible = false;
            if (User_Name_Text.Text != "") {
                User_Name_Text.LineIdleColor = Color.DeepSkyBlue;
            }
        }

        private void Password_Text_OnValueChanged(object sender, EventArgs e)
        {
            Password_Text.isPassword = true;
            Error_Title.Visible = false;
            Error_Title.Visible = false;
            if (string.IsNullOrEmpty(Password_Text.Text)) {
                Password_Text.isPassword = false;
            } else {
                Password_Text.LineIdleColor = Color.DeepSkyBlue;
            }
        }

        private void Confirm_Password_Text_OnValueChanged(object sender, EventArgs e)
        {
            Confirm_Password_Text.isPassword = true;
            Error_Title.Visible = false;
            if (string.IsNullOrEmpty(Confirm_Password_Text.Text)) {
                Confirm_Password_Text.isPassword = false;
            } else {
                Confirm_Password_Text.LineIdleColor = Color.DeepSkyBlue;
            }
        }

        private void Password_Text_KeyUp(object sender, KeyEventArgs e)
        {
            if (Confirm_Password_Text.Text == Password_Text.Text && Confirm_Password_Text.Text != "" && Password_Text.Text != "") {
                CheckCorrect_Button.Visible = true;
            } else {
                CheckCorrect_Button.Visible = false;
            }
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
            base.WndProc(ref m);
            if (m.Msg == (int)Function_GUI.ShadowBorder.WM_NCHITTEST && (int)m.Result == (int)Function_GUI.ShadowBorder.HTCLIENT) {
                m.Result = (IntPtr)Function_GUI.ShadowBorder.HTCAPTION;
            }
        }
    }
}
