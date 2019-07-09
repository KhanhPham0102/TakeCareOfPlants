namespace TakeCareOfPlants
{
    partial class DialogSuccess_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogSuccess_GUI));
            this.FormSuccessFadeTransition = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.Success_Box = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Time_Show_Button = new System.Windows.Forms.Timer(this.components);
            this.OK_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.Success_Box)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormSuccessFadeTransition
            // 
            this.FormSuccessFadeTransition.Delay = 1;
            this.FormSuccessFadeTransition.TransitionEnd += new System.EventHandler(this.FormFadeTransition_TransitionEnd);
            // 
            // Success_Box
            // 
            this.Success_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Success_Box.Enabled = false;
            this.Success_Box.Image = ((System.Drawing.Image)(resources.GetObject("Success_Box.Image")));
            this.Success_Box.Location = new System.Drawing.Point(0, 0);
            this.Success_Box.Name = "Success_Box";
            this.Success_Box.Size = new System.Drawing.Size(241, 132);
            this.Success_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Success_Box.TabIndex = 0;
            this.Success_Box.TabStop = false;
            this.Success_Box.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Success_Box);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 132);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(0, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "Success";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Time_Show_Button
            // 
            this.Time_Show_Button.Interval = 3000;
            this.Time_Show_Button.Tick += new System.EventHandler(this.Time_Show_Button_Tick);
            // 
            // OK_Button
            // 
            this.OK_Button.Active = false;
            this.OK_Button.Activecolor = System.Drawing.Color.LightBlue;
            this.OK_Button.BackColor = System.Drawing.Color.DodgerBlue;
            this.OK_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OK_Button.BorderRadius = 5;
            this.OK_Button.ButtonText = "OK";
            this.OK_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OK_Button.DisabledColor = System.Drawing.Color.Gray;
            this.OK_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.OK_Button.Iconimage = null;
            this.OK_Button.Iconimage_right = null;
            this.OK_Button.Iconimage_right_Selected = null;
            this.OK_Button.Iconimage_Selected = null;
            this.OK_Button.IconMarginLeft = 0;
            this.OK_Button.IconMarginRight = 0;
            this.OK_Button.IconRightVisible = true;
            this.OK_Button.IconRightZoom = 0D;
            this.OK_Button.IconVisible = true;
            this.OK_Button.IconZoom = 90D;
            this.OK_Button.IsTab = false;
            this.OK_Button.Location = new System.Drawing.Point(56, 194);
            this.OK_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.OK_Button.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.OK_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.OK_Button.selected = false;
            this.OK_Button.Size = new System.Drawing.Size(123, 38);
            this.OK_Button.TabIndex = 3;
            this.OK_Button.Text = "OK";
            this.OK_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OK_Button.Textcolor = System.Drawing.Color.White;
            this.OK_Button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK_Button.Visible = false;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // DialogSuccess_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(241, 245);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DialogSuccess_GUI";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogSuccess";
            this.Load += new System.EventHandler(this.DialogSuccess_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Success_Box)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFormFadeTransition FormSuccessFadeTransition;
        private System.Windows.Forms.PictureBox Success_Box;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Time_Show_Button;
        private Bunifu.Framework.UI.BunifuFlatButton OK_Button;
    }
}