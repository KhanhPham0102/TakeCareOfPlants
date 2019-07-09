namespace TakeCareOfPlants
{
    partial class UI_Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_Home));
            this.UIT_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UIT_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UIT_PictureBox
            // 
            this.UIT_PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UIT_PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UIT_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UIT_PictureBox.Image")));
            this.UIT_PictureBox.Location = new System.Drawing.Point(18, 44);
            this.UIT_PictureBox.Name = "UIT_PictureBox";
            this.UIT_PictureBox.Size = new System.Drawing.Size(1222, 449);
            this.UIT_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UIT_PictureBox.TabIndex = 0;
            this.UIT_PictureBox.TabStop = false;
            // 
            // UI_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UIT_PictureBox);
            this.Name = "UI_Home";
            this.Size = new System.Drawing.Size(1254, 580);
            ((System.ComponentModel.ISupportInitialize)(this.UIT_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox UIT_PictureBox;
    }
}
