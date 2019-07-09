namespace TakeCareOfPlants.Reports
{
    partial class ListCalendar_GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListCalendar_GUI));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Export_Button = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.NgayLapLich_DropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.NgayLapLich_Title = new System.Windows.Forms.Label();
            this.CayCanh_ComboBox = new Bunifu.Framework.UI.BunifuDropdown();
            this.CayCanh_Title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Report_Calendar_Viewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Export_Button_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Export_Button);
            this.panel1.Controls.Add(this.NgayLapLich_DropDown);
            this.panel1.Controls.Add(this.NgayLapLich_Title);
            this.panel1.Controls.Add(this.CayCanh_ComboBox);
            this.panel1.Controls.Add(this.CayCanh_Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 78);
            this.panel1.TabIndex = 0;
            // 
            // Export_Button
            // 
            this.Export_Button.BackColor = System.Drawing.Color.Transparent;
            this.Export_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Export_Button.BackgroundImage")));
            this.Export_Button.ButtonText = "Export";
            this.Export_Button.ButtonTextMarginLeft = 0;
            this.Export_Button.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Export_Button.DisabledFillColor = System.Drawing.Color.Gray;
            this.Export_Button.DisabledForecolor = System.Drawing.Color.White;
            this.Export_Button.ForeColor = System.Drawing.Color.White;
            this.Export_Button.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Export_Button.IconPadding = 10;
            this.Export_Button.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Export_Button.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.Export_Button.IdleBorderRadius = 1;
            this.Export_Button.IdleBorderThickness = 0;
            this.Export_Button.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.Export_Button.IdleIconLeftImage = null;
            this.Export_Button.IdleIconRightImage = null;
            this.Export_Button.Location = new System.Drawing.Point(757, 12);
            this.Export_Button.Name = "Export_Button";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties5.BorderRadius = 1;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.Export_Button.onHoverState = stateProperties5;
            this.Export_Button.Size = new System.Drawing.Size(111, 45);
            this.Export_Button.TabIndex = 5;
            this.Export_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Export_Button.Click += new System.EventHandler(this.Export_Button_Click);
            // 
            // NgayLapLich_DropDown
            // 
            this.NgayLapLich_DropDown.AllowDrop = true;
            this.NgayLapLich_DropDown.BackColor = System.Drawing.Color.Transparent;
            this.NgayLapLich_DropDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NgayLapLich_DropDown.BorderRadius = 0;
            this.NgayLapLich_DropDown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NgayLapLich_DropDown.DisabledColor = System.Drawing.Color.Gray;
            this.NgayLapLich_DropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NgayLapLich_DropDown.ForeColor = System.Drawing.Color.Black;
            this.NgayLapLich_DropDown.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.NgayLapLich_DropDown.items = new string[] {
        "- Select -"};
            this.NgayLapLich_DropDown.Location = new System.Drawing.Point(515, 16);
            this.NgayLapLich_DropDown.Margin = new System.Windows.Forms.Padding(0);
            this.NgayLapLich_DropDown.Name = "NgayLapLich_DropDown";
            this.NgayLapLich_DropDown.NomalColor = System.Drawing.Color.Transparent;
            this.NgayLapLich_DropDown.onHoverColor = System.Drawing.Color.LightSkyBlue;
            this.NgayLapLich_DropDown.selectedIndex = 0;
            this.NgayLapLich_DropDown.Size = new System.Drawing.Size(226, 35);
            this.NgayLapLich_DropDown.TabIndex = 4;
            this.NgayLapLich_DropDown.TabStop = false;
            this.NgayLapLich_DropDown.onItemSelected += new System.EventHandler(this.NgayLapLich_DropDown_onItemSelected);
            // 
            // NgayLapLich_Title
            // 
            this.NgayLapLich_Title.AutoSize = true;
            this.NgayLapLich_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NgayLapLich_Title.Location = new System.Drawing.Point(377, 23);
            this.NgayLapLich_Title.Name = "NgayLapLich_Title";
            this.NgayLapLich_Title.Size = new System.Drawing.Size(135, 24);
            this.NgayLapLich_Title.TabIndex = 3;
            this.NgayLapLich_Title.Text = "Ngày Lập Lịch:";
            // 
            // CayCanh_ComboBox
            // 
            this.CayCanh_ComboBox.AllowDrop = true;
            this.CayCanh_ComboBox.BackColor = System.Drawing.Color.Transparent;
            this.CayCanh_ComboBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CayCanh_ComboBox.BorderRadius = 0;
            this.CayCanh_ComboBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CayCanh_ComboBox.DisabledColor = System.Drawing.Color.Gray;
            this.CayCanh_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CayCanh_ComboBox.ForeColor = System.Drawing.Color.Black;
            this.CayCanh_ComboBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.CayCanh_ComboBox.items = new string[] {
        "- Select -"};
            this.CayCanh_ComboBox.Location = new System.Drawing.Point(113, 16);
            this.CayCanh_ComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.CayCanh_ComboBox.Name = "CayCanh_ComboBox";
            this.CayCanh_ComboBox.NomalColor = System.Drawing.Color.Transparent;
            this.CayCanh_ComboBox.onHoverColor = System.Drawing.Color.LightSkyBlue;
            this.CayCanh_ComboBox.selectedIndex = 0;
            this.CayCanh_ComboBox.Size = new System.Drawing.Size(248, 35);
            this.CayCanh_ComboBox.TabIndex = 2;
            this.CayCanh_ComboBox.TabStop = false;
            this.CayCanh_ComboBox.onItemSelected += new System.EventHandler(this.CayCanh_ComboBox_onItemSelected);
            // 
            // CayCanh_Title
            // 
            this.CayCanh_Title.AutoSize = true;
            this.CayCanh_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CayCanh_Title.Location = new System.Drawing.Point(12, 23);
            this.CayCanh_Title.Name = "CayCanh_Title";
            this.CayCanh_Title.Size = new System.Drawing.Size(97, 24);
            this.CayCanh_Title.TabIndex = 1;
            this.CayCanh_Title.Text = "Cây Cảnh:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Report_Calendar_Viewer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 372);
            this.panel2.TabIndex = 1;
            // 
            // Report_Calendar_Viewer
            // 
            this.Report_Calendar_Viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Report_Calendar_Viewer.Location = new System.Drawing.Point(0, 0);
            this.Report_Calendar_Viewer.Name = "ReportViewer";
            this.Report_Calendar_Viewer.ServerReport.BearerToken = null;
            this.Report_Calendar_Viewer.Size = new System.Drawing.Size(880, 372);
            this.Report_Calendar_Viewer.TabIndex = 0;
            // 
            // Export_Button_Elipse
            // 
            this.Export_Button_Elipse.ElipseRadius = 10;
            this.Export_Button_Elipse.TargetControl = this.Export_Button;
            // 
            // ListCalendar_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ListCalendar_GUI";
            this.Text = "List Calendars";
            this.Load += new System.EventHandler(this.ListCalendar_GUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer Report_Calendar_Viewer;
        private System.Windows.Forms.Label CayCanh_Title;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Export_Button;
        private Bunifu.Framework.UI.BunifuDropdown NgayLapLich_DropDown;
        private System.Windows.Forms.Label NgayLapLich_Title;
        private Bunifu.Framework.UI.BunifuDropdown CayCanh_ComboBox;
        private Bunifu.Framework.UI.BunifuElipse Export_Button_Elipse;
    }
}