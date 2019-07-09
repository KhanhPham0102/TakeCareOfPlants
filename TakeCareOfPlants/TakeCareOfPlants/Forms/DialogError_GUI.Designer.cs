namespace TakeCareOfPlants
{
    partial class DialogError_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogError_GUI));
            this.Error_Box = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Error_Text = new System.Windows.Forms.Label();
            this.OK_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.FormErrorFadeTransition = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.Time_Show_Button = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Error_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // Error_Box
            // 
            this.Error_Box.Dock = System.Windows.Forms.DockStyle.Top;
            this.Error_Box.Image = ((System.Drawing.Image)(resources.GetObject("Error_Box.Image")));
            this.Error_Box.Location = new System.Drawing.Point(0, 0);
            this.Error_Box.Name = "Error_Box";
            this.Error_Box.Size = new System.Drawing.Size(411, 247);
            this.Error_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Error_Box.TabIndex = 0;
            this.Error_Box.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(0, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Something went wrong!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Error_Text
            // 
            this.Error_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Error_Text.Location = new System.Drawing.Point(12, 288);
            this.Error_Text.Name = "Error_Text";
            this.Error_Text.Size = new System.Drawing.Size(387, 100);
            this.Error_Text.TabIndex = 5;
            this.Error_Text.Text = "Error";
            this.Error_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Error_Text.Visible = false;
            // 
            // OK_Button
            // 
            this.OK_Button.Active = false;
            this.OK_Button.Activecolor = System.Drawing.Color.LightBlue;
            this.OK_Button.BackColor = System.Drawing.Color.OrangeRed;
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
            this.OK_Button.Location = new System.Drawing.Point(114, 392);
            this.OK_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Normalcolor = System.Drawing.Color.OrangeRed;
            this.OK_Button.OnHovercolor = System.Drawing.Color.Red;
            this.OK_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.OK_Button.selected = false;
            this.OK_Button.Size = new System.Drawing.Size(182, 45);
            this.OK_Button.TabIndex = 4;
            this.OK_Button.Text = "OK";
            this.OK_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OK_Button.Textcolor = System.Drawing.Color.White;
            this.OK_Button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK_Button.Visible = false;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // FormErrorFadeTransition
            // 
            this.FormErrorFadeTransition.Delay = 1;
            this.FormErrorFadeTransition.TransitionEnd += new System.EventHandler(this.FormErrorFadeTransition_TransitionEnd);
            // 
            // Time_Show_Button
            // 
            this.Time_Show_Button.Interval = 1000;
            this.Time_Show_Button.Tick += new System.EventHandler(this.Time_Show_Button_Tick);
            // 
            // DialogError_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.Error_Text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Error_Box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DialogError_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogError_GUI";
            this.Load += new System.EventHandler(this.DialogError_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Error_Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Error_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Error_Text;
        private Bunifu.Framework.UI.BunifuFlatButton OK_Button;
        private Bunifu.Framework.UI.BunifuFormFadeTransition FormErrorFadeTransition;
        private System.Windows.Forms.Timer Time_Show_Button;
    }
}