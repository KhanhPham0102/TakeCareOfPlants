namespace TakeCareOfPlants.Forms
{
    partial class ListPlant_GUI
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
            this.ListPlant_ReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ListPlant_ReportViewer
            // 
            this.ListPlant_ReportViewer.AutoSize = true;
            this.ListPlant_ReportViewer.BackColor = System.Drawing.Color.DarkGray;
            this.ListPlant_ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPlant_ReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ListPlant_ReportViewer.Name = "ReportViewer";
            this.ListPlant_ReportViewer.ServerReport.BearerToken = null;
            this.ListPlant_ReportViewer.Size = new System.Drawing.Size(800, 450);
            this.ListPlant_ReportViewer.TabIndex = 0;
            // 
            // ListPlant_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListPlant_ReportViewer);
            this.Name = "ListPlant_GUI";
            this.Text = "List Plants";
            this.Load += new System.EventHandler(this.ListPlant_GUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ListPlant_ReportViewer;
    }
}