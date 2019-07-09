namespace TakeCareOfPlants
{
    partial class Amount_GUI
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
            this.Amount_Title = new System.Windows.Forms.Label();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Amount_Text = new Bunifu.Framework.BunifuCustomTextbox();
            this.SuspendLayout();
            // 
            // Amount_Title
            // 
            this.Amount_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Amount_Title.AutoSize = true;
            this.Amount_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Amount_Title.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Amount_Title.Location = new System.Drawing.Point(12, 9);
            this.Amount_Title.Name = "Amount_Title";
            this.Amount_Title.Size = new System.Drawing.Size(86, 25);
            this.Amount_Title.TabIndex = 23;
            this.Amount_Title.Text = "Amount:";
            // 
            // OK_Button
            // 
            this.OK_Button.BackColor = System.Drawing.Color.Transparent;
            this.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OK_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OK_Button.Location = new System.Drawing.Point(196, 84);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(90, 30);
            this.OK_Button.TabIndex = 24;
            this.OK_Button.TabStop = false;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = false;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cancel_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cancel_Button.Location = new System.Drawing.Point(308, 84);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(90, 30);
            this.Cancel_Button.TabIndex = 25;
            this.Cancel_Button.TabStop = false;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // Amount_Text
            // 
            this.Amount_Text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Amount_Text.BackColor = System.Drawing.Color.White;
            this.Amount_Text.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.Amount_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Amount_Text.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Amount_Text.Location = new System.Drawing.Point(42, 37);
            this.Amount_Text.Name = "Amount_Text";
            this.Amount_Text.Size = new System.Drawing.Size(356, 28);
            this.Amount_Text.TabIndex = 0;
            this.Amount_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberPlant_Text_KeyPress);
            this.Amount_Text.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Amount_Text_PreviewKeyDown);
            // 
            // Amount_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(413, 126);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.Amount_Title);
            this.Controls.Add(this.Amount_Text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Amount_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amount_GUI";
            this.Load += new System.EventHandler(this.Amount_GUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Amount_Title;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private Bunifu.Framework.BunifuCustomTextbox Amount_Text;
    }
}