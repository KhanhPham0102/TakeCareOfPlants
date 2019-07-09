using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using TakeCareOfPlants_BUS;

namespace TakeCareOfPlants
{
    public partial class PageLogin_GUI : Form
    {
        private Login_BUS loginBUS = new Login_BUS();
        private bool showPass = false;

        private static PageLogin_GUI pageLogin;

        public PageLogin_GUI()
        {
            InitializeComponent();
        }

        public static PageLogin_GUI Instance
        {
            get {
                if (pageLogin == null) {
                    pageLogin = new PageLogin_GUI();
                }
                return pageLogin;
            }
        }

        private void PageLogin_Load(object sender, EventArgs e)
        {
            pageLogin = this;
            Show_Pass_Icon.Visible = false;
        }

        private void Remember_Password_Click(object sender, EventArgs e)
        {
            if (Remember_Password_Check.Checked == true) {
                Remember_Password_Check.Checked = false;
            } else {
                Remember_Password_Check.Checked = true;
            }
        }

        private void Close_Windows_Click(object sender, EventArgs e)
        {
            Function_GUI.CloseApp();
        }

        private void Mini_Windows_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Password_Text_OnValueChanged(object sender, EventArgs e)
        {
            Show_Pass_Icon.Visible = false;
            Password_Text.isPassword = false;
            Error_Text.Visible = false;
            if (Password_Text.Text != "") {
                Password_Text.LineIdleColor = Color.DeepSkyBlue;
                if (showPass == true) {
                    Password_Text.isPassword = false;
                } else {
                    Password_Text.isPassword = true;
                }
                Show_Pass_Icon.Visible = true;
            }
        }

        private void User_Name_Text_OnValueChanged(object sender, EventArgs e)
        {
            User_Name_Text.LineIdleColor = Color.DeepSkyBlue;
        }

        private void Sign_Up_Text_MouseHover(object sender, EventArgs e)
        {
            Sign_Up_Text.Font = new Font(Sign_Up_Text.Font, FontStyle.Underline);
        }

        private void Sign_Up_Text_MouseLeave(object sender, EventArgs e)
        {
            Sign_Up_Text.Font = new Font(Sign_Up_Text.Font, FontStyle.Regular);
        }

        private void Forgot_Password_Title_MouseHover(object sender, EventArgs e)
        {
            Forgot_Password_Title.Font = new Font(Forgot_Password_Title.Font, FontStyle.Underline);
        }

        private void Forgot_Password_Title_MouseLeave(object sender, EventArgs e)
        {
            Forgot_Password_Title.Font = new Font(Forgot_Password_Title.Font, FontStyle.Regular);
        }

        private void Sign_In_Button_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            pageLogin = this;
            if (string.IsNullOrEmpty(User_Name_Text.Text)) {
                User_Name_Text.LineIdleColor = Color.Red;
            }
            if (string.IsNullOrEmpty(Password_Text.Text)) {
                Password_Text.LineIdleColor = Color.Red;
            }
            try {
                if (User_Name_Text.Text != "" && Password_Text.Text != "") {
                    if (loginBUS.LogInSuccess(User_Name_Text.Text, Password_Text.Text)) {
                        DialogSuccess_GUI.Instance.ShowDialog();
                    } else {
                        Error_Text.Text = "The username or password is incorrect";
                        Error_Text.Visible = true;
                    }
                }
            } catch (Exception ex) {
                Function_GUI.ShowErrorDialog(ex.Message);
            }
        }

        private void Sign_Up_Text_Click(object sender, EventArgs e)
        {
            pageLogin = this;
            Function_GUI.HideShowPage(pageLogin, PageSignUp_GUI.Instance);
        }

        private void Show_Pass_Icon_Click(object sender, EventArgs e)
        {
            if (Password_Text.isPassword == true) {
                Password_Text.isPassword = false;
                showPass = true;
            } else {
                Password_Text.isPassword = true;
                showPass = false;
            }
        }

        private void Password_Text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                Sign_In_Button_Click(new object(), new EventArgs());
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
