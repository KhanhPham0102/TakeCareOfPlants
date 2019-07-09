using System;
using System.Drawing;
using System.Windows.Forms;
using TakeCareOfPlants_BUS;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants
{
    public partial class PageMain_GUI : Form
    {
        private static PageMain_GUI pageMain;

        public static PageMain_GUI Instance
        {
            get {
                if (pageMain == null) {
                    pageMain = new PageMain_GUI();
                }
                return pageMain;
            }
        }

        public PageMain_GUI()
        {
            try {
                GlobalVariable_DTO.QuyDinh_DTOs = QuyDinh_BUS.GetValueQuyDinh();
                GlobalVariable_DTO.ViTri_DTOs = QuyDinh_BUS.GetAvailableViTri();
            } catch (Exception ex) {
                Function_GUI.ShowErrorDialog(ex.Message);
            }
            InitializeComponent();
        }

        public PictureBox ImageNotification
        {
            get => Notification_Icon;

            set => Notification_Icon = value;
        }

        public Label TextNotification
        {
            get => Notification_Text;

            set => Notification_Text = value;
        }

        public Panel PanelController
        {
            get => Panel_Center_Controller;

            set => Panel_Center_Controller = value;
        }

        public Button BackButton
        {
            get => null;

            set {
            }
        }

        public Label TitlePage
        {
            get => Topic_Title;

            set => Topic_Title = value;
        }

        private void PageMain_GUI_Load(object sender, EventArgs e)
        {
            pageMain = this;

            ImageNotification.InitialImage = Properties.Resources._running;
            ImageNotification.Image = ImageNotification.InitialImage;
            ImageNotification.SizeMode = PictureBoxSizeMode.Zoom;
            TextNotification.Text = "Ready";

            Function_GUI.ShowControl(UI_Home.Instance);
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            if (Panel_Menu.Width == 150) {
                Panel_Menu.Visible = false;
                Icon_Main.Visible = false;
                Panel_Menu.Width = 50;
                Icon_Plant_Eat.Visible = true;
                Menu_Transition.ShowSync(Panel_Menu);
            } else {
                Panel_Menu.Visible = false;
                Icon_Plant_Eat.Visible = false;
                Panel_Menu.Width = 150;
                Icon_Main.Visible = true;
                Menu_Transition.ShowSync(Panel_Menu);
            }
        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            TitleClick("Take Care Of Plants", UI_Home.Instance);
        }

        private void Plant_Click(object sender, EventArgs e)
        {
            TitleClick("Plants", UI_Plant.Instance);
        }

        private void Plant_Care_Click(object sender, EventArgs e)
        {
            TitleClick("Plant Care", UI_Care.Instance);
        }

        private void Materials_Button_Click(object sender, EventArgs e)
        {
            TitleClick("Materials", UI_Materials.Instance);
        }

        private void Reports_Button_Click(object sender, EventArgs e)
        {
            TitleClick("Reports", UI_Reports.Instance);
        }

        private void Close_Windows_Click(object sender, EventArgs e)
        {
            Function_GUI.CloseApp();
        }

        private void Mini_Windows_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Restore_Windows_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized) {
                WindowState = FormWindowState.Normal;
            } else {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void TitleClick(string title, Control control)
        {
            pageMain = this;

            Topic_Title.Text = title;
            if (Panel_Menu.Width == 150) {
                Panel_Menu.Visible = false;
                Icon_Main.Visible = false;
                Panel_Menu.Width = 50;
                Icon_Plant_Eat.Visible = true;
                Menu_Transition.ShowSync(Panel_Menu);
            }
            Function_GUI.ShowControl(control);
        }

        private void Setting_Button_Click(object sender, EventArgs e)
        {
            PageSetting_GUI.Instance.ShowDialog();
        }

        private void TimeInc_Tick(object sender, EventArgs e)
        {
            DateTime_Title.Text = DateTime.Now.ToLongTimeString();
            DateTime_Title.ForeColor = Color.White;
            TimeInc.Start();
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
