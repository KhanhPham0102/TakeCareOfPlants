namespace TakeCareOfPlants.Reports
{
    partial class ReportCostVsStatus_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportCostVsStatus_GUI));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Export_Button = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Month_ComboBox = new Bunifu.Framework.UI.BunifuDropdown();
            this.Thang_Title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Report_Viewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Export_Button_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Export_Button);
            this.panel1.Controls.Add(this.Month_ComboBox);
            this.panel1.Controls.Add(this.Thang_Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 76);
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
            this.Export_Button.Location = new System.Drawing.Point(444, 17);
            this.Export_Button.Name = "Export_Button";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.Export_Button.onHoverState = stateProperties1;
            this.Export_Button.Size = new System.Drawing.Size(111, 45);
            this.Export_Button.TabIndex = 6;
            this.Export_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Export_Button.Click += new System.EventHandler(this.Export_Button_Click);
            // 
            // Month_ComboBox
            // 
            this.Month_ComboBox.AllowDrop = true;
            this.Month_ComboBox.BackColor = System.Drawing.Color.Transparent;
            this.Month_ComboBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Month_ComboBox.BorderRadius = 0;
            this.Month_ComboBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Month_ComboBox.DisabledColor = System.Drawing.Color.Gray;
            this.Month_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Month_ComboBox.ForeColor = System.Drawing.Color.Black;
            this.Month_ComboBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Month_ComboBox.items = new string[] {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "10",
        "11",
        "12"};
            this.Month_ComboBox.Location = new System.Drawing.Point(216, 20);
            this.Month_ComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.Month_ComboBox.Name = "Month_ComboBox";
            this.Month_ComboBox.NomalColor = System.Drawing.Color.Transparent;
            this.Month_ComboBox.onHoverColor = System.Drawing.Color.LightSkyBlue;
            this.Month_ComboBox.selectedIndex = 0;
            this.Month_ComboBox.Size = new System.Drawing.Size(135, 35);
            this.Month_ComboBox.TabIndex = 3;
            this.Month_ComboBox.TabStop = false;
            // 
            // Thang_Title
            // 
            this.Thang_Title.AutoSize = true;
            this.Thang_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Thang_Title.Location = new System.Drawing.Point(144, 27);
            this.Thang_Title.Name = "Thang_Title";
            this.Thang_Title.Size = new System.Drawing.Size(60, 20);
            this.Thang_Title.TabIndex = 0;
            this.Thang_Title.Text = "Tháng:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Report_Viewer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 374);
            this.panel2.TabIndex = 1;
            // 
            // Report_Viewer
            // 
            this.Report_Viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Report_Viewer.Location = new System.Drawing.Point(0, 0);
            this.Report_Viewer.Name = "ReportViewer";
            this.Report_Viewer.ServerReport.BearerToken = null;
            this.Report_Viewer.Size = new System.Drawing.Size(800, 374);
            this.Report_Viewer.TabIndex = 0;
            // 
            // Export_Button_Elipse
            // 
            this.Export_Button_Elipse.ElipseRadius = 10;
            this.Export_Button_Elipse.TargetControl = this.Export_Button;
            // 
            // ReportCostVsStatus_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReportCostVsStatus_GUI";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.ReportCostVsStatus_GUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer Report_Viewer;
        private System.Windows.Forms.Label Thang_Title;
        private Bunifu.Framework.UI.BunifuDropdown Month_ComboBox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Export_Button;
        private Bunifu.Framework.UI.BunifuElipse Export_Button_Elipse;
    }
}