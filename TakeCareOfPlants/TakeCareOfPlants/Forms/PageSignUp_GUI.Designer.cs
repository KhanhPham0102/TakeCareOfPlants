namespace TakeCareOfPlants
{
    partial class PageSignUp_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageSignUp_GUI));
            this.Sign_Up_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BorderButton = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Password_Text = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Password_Title = new System.Windows.Forms.Label();
            this.User_Name_Title = new System.Windows.Forms.Label();
            this.Sign_Up_Title = new System.Windows.Forms.Label();
            this.Mini_Windows = new Bunifu.Framework.UI.BunifuImageButton();
            this.Close_Windows = new Bunifu.Framework.UI.BunifuImageButton();
            this.DragForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Panel_Top = new System.Windows.Forms.Panel();
            this.User_Name_Text = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Confirmation_Title = new System.Windows.Forms.Label();
            this.Confirm_Password_Text = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CheckCorrect_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.Error_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Mini_Windows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Windows)).BeginInit();
            this.Panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckCorrect_Button)).BeginInit();
            this.SuspendLayout();
            // 
            // Sign_Up_Button
            // 
            this.Sign_Up_Button.Active = false;
            this.Sign_Up_Button.Activecolor = System.Drawing.Color.DeepSkyBlue;
            this.Sign_Up_Button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Sign_Up_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Sign_Up_Button.BorderRadius = 0;
            this.Sign_Up_Button.ButtonText = "Sign Up";
            this.Sign_Up_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sign_Up_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Sign_Up_Button.ForeColor = System.Drawing.Color.White;
            this.Sign_Up_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Sign_Up_Button.Iconimage = null;
            this.Sign_Up_Button.Iconimage_right = null;
            this.Sign_Up_Button.Iconimage_right_Selected = null;
            this.Sign_Up_Button.Iconimage_Selected = null;
            this.Sign_Up_Button.IconMarginLeft = 0;
            this.Sign_Up_Button.IconMarginRight = 0;
            this.Sign_Up_Button.IconRightVisible = true;
            this.Sign_Up_Button.IconRightZoom = 0D;
            this.Sign_Up_Button.IconVisible = true;
            this.Sign_Up_Button.IconZoom = 90D;
            this.Sign_Up_Button.IsTab = false;
            this.Sign_Up_Button.Location = new System.Drawing.Point(36, 578);
            this.Sign_Up_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Sign_Up_Button.Name = "Sign_Up_Button";
            this.Sign_Up_Button.Normalcolor = System.Drawing.Color.DeepSkyBlue;
            this.Sign_Up_Button.OnHovercolor = System.Drawing.Color.SkyBlue;
            this.Sign_Up_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Sign_Up_Button.selected = false;
            this.Sign_Up_Button.Size = new System.Drawing.Size(321, 43);
            this.Sign_Up_Button.TabIndex = 31;
            this.Sign_Up_Button.TabStop = false;
            this.Sign_Up_Button.Text = "Sign Up";
            this.Sign_Up_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Sign_Up_Button.Textcolor = System.Drawing.Color.White;
            this.Sign_Up_Button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Sign_Up_Button.Click += new System.EventHandler(this.Sign_Up_Button_Click);
            // 
            // BorderButton
            // 
            this.BorderButton.ElipseRadius = 15;
            this.BorderButton.TargetControl = this.Sign_Up_Button;
            // 
            // Password_Text
            // 
            this.Password_Text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Password_Text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Password_Text.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Password_Text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_Text.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password_Text.HintForeColor = System.Drawing.Color.Empty;
            this.Password_Text.HintText = "Password";
            this.Password_Text.isPassword = false;
            this.Password_Text.LineFocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.Password_Text.LineIdleColor = System.Drawing.Color.DeepSkyBlue;
            this.Password_Text.LineMouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.Password_Text.LineThickness = 3;
            this.Password_Text.Location = new System.Drawing.Point(75, 305);
            this.Password_Text.Margin = new System.Windows.Forms.Padding(4);
            this.Password_Text.MaxLength = 32767;
            this.Password_Text.Name = "Password_Text";
            this.Password_Text.Size = new System.Drawing.Size(264, 52);
            this.Password_Text.TabIndex = 1;
            this.Password_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password_Text.OnValueChanged += new System.EventHandler(this.Password_Text_OnValueChanged);
            this.Password_Text.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Password_Text_KeyUp);
            // 
            // Password_Title
            // 
            this.Password_Title.AutoSize = true;
            this.Password_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Password_Title.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Password_Title.Location = new System.Drawing.Point(46, 272);
            this.Password_Title.Name = "Password_Title";
            this.Password_Title.Size = new System.Drawing.Size(104, 25);
            this.Password_Title.TabIndex = 22;
            this.Password_Title.Text = "Password:";
            // 
            // User_Name_Title
            // 
            this.User_Name_Title.AutoSize = true;
            this.User_Name_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.User_Name_Title.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.User_Name_Title.Location = new System.Drawing.Point(46, 160);
            this.User_Name_Title.Name = "User_Name_Title";
            this.User_Name_Title.Size = new System.Drawing.Size(116, 25);
            this.User_Name_Title.TabIndex = 21;
            this.User_Name_Title.Text = "User Name:";
            // 
            // Sign_Up_Title
            // 
            this.Sign_Up_Title.AutoSize = true;
            this.Sign_Up_Title.BackColor = System.Drawing.Color.Transparent;
            this.Sign_Up_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Sign_Up_Title.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Sign_Up_Title.Location = new System.Drawing.Point(30, 83);
            this.Sign_Up_Title.Name = "Sign_Up_Title";
            this.Sign_Up_Title.Size = new System.Drawing.Size(116, 32);
            this.Sign_Up_Title.TabIndex = 20;
            this.Sign_Up_Title.Text = "Sign Up";
            // 
            // Mini_Windows
            // 
            this.Mini_Windows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mini_Windows.BackColor = System.Drawing.Color.Transparent;
            this.Mini_Windows.Image = ((System.Drawing.Image)(resources.GetObject("Mini_Windows.Image")));
            this.Mini_Windows.ImageActive = null;
            this.Mini_Windows.Location = new System.Drawing.Point(322, 5);
            this.Mini_Windows.Name = "Mini_Windows";
            this.Mini_Windows.Size = new System.Drawing.Size(35, 35);
            this.Mini_Windows.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Mini_Windows.TabIndex = 16;
            this.Mini_Windows.TabStop = false;
            this.Mini_Windows.Zoom = 10;
            this.Mini_Windows.Click += new System.EventHandler(this.Mini_Windows_Click);
            // 
            // Close_Windows
            // 
            this.Close_Windows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_Windows.BackColor = System.Drawing.Color.Transparent;
            this.Close_Windows.Image = ((System.Drawing.Image)(resources.GetObject("Close_Windows.Image")));
            this.Close_Windows.ImageActive = null;
            this.Close_Windows.Location = new System.Drawing.Point(358, 5);
            this.Close_Windows.Name = "Close_Windows";
            this.Close_Windows.Size = new System.Drawing.Size(35, 35);
            this.Close_Windows.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close_Windows.TabIndex = 16;
            this.Close_Windows.TabStop = false;
            this.Close_Windows.Zoom = 10;
            this.Close_Windows.Click += new System.EventHandler(this.Close_Windows_Click);
            // 
            // DragForm
            // 
            this.DragForm.Fixed = true;
            this.DragForm.Horizontal = true;
            this.DragForm.TargetControl = this.Panel_Top;
            this.DragForm.Vertical = true;
            // 
            // Panel_Top
            // 
            this.Panel_Top.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Panel_Top.Controls.Add(this.Mini_Windows);
            this.Panel_Top.Controls.Add(this.Close_Windows);
            this.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Top.Location = new System.Drawing.Point(0, 0);
            this.Panel_Top.Name = "Panel_Top";
            this.Panel_Top.Size = new System.Drawing.Size(399, 44);
            this.Panel_Top.TabIndex = 19;
            // 
            // User_Name_Text
            // 
            this.User_Name_Text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.User_Name_Text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.User_Name_Text.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.User_Name_Text.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.User_Name_Text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.User_Name_Text.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Name_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.User_Name_Text.HintForeColor = System.Drawing.Color.Empty;
            this.User_Name_Text.HintText = "Username or email";
            this.User_Name_Text.isPassword = false;
            this.User_Name_Text.LineFocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.User_Name_Text.LineIdleColor = System.Drawing.Color.DeepSkyBlue;
            this.User_Name_Text.LineMouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.User_Name_Text.LineThickness = 3;
            this.User_Name_Text.Location = new System.Drawing.Point(75, 193);
            this.User_Name_Text.Margin = new System.Windows.Forms.Padding(4);
            this.User_Name_Text.MaxLength = 32767;
            this.User_Name_Text.Name = "User_Name_Text";
            this.User_Name_Text.Size = new System.Drawing.Size(264, 48);
            this.User_Name_Text.TabIndex = 0;
            this.User_Name_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.User_Name_Text.OnValueChanged += new System.EventHandler(this.User_Name_Text_OnValueChanged);
            // 
            // Confirmation_Title
            // 
            this.Confirmation_Title.AutoSize = true;
            this.Confirmation_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Confirmation_Title.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Confirmation_Title.Location = new System.Drawing.Point(46, 388);
            this.Confirmation_Title.Name = "Confirmation_Title";
            this.Confirmation_Title.Size = new System.Drawing.Size(128, 25);
            this.Confirmation_Title.TabIndex = 32;
            this.Confirmation_Title.Text = "Confirmation:";
            // 
            // Confirm_Password_Text
            // 
            this.Confirm_Password_Text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Confirm_Password_Text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Confirm_Password_Text.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Confirm_Password_Text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Confirm_Password_Text.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_Password_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Confirm_Password_Text.HintForeColor = System.Drawing.Color.Empty;
            this.Confirm_Password_Text.HintText = "Confirm Password";
            this.Confirm_Password_Text.isPassword = false;
            this.Confirm_Password_Text.LineFocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.Confirm_Password_Text.LineIdleColor = System.Drawing.Color.DeepSkyBlue;
            this.Confirm_Password_Text.LineMouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.Confirm_Password_Text.LineThickness = 3;
            this.Confirm_Password_Text.Location = new System.Drawing.Point(75, 421);
            this.Confirm_Password_Text.Margin = new System.Windows.Forms.Padding(4);
            this.Confirm_Password_Text.MaxLength = 32767;
            this.Confirm_Password_Text.Name = "Confirm_Password_Text";
            this.Confirm_Password_Text.Size = new System.Drawing.Size(264, 52);
            this.Confirm_Password_Text.TabIndex = 2;
            this.Confirm_Password_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Confirm_Password_Text.OnValueChanged += new System.EventHandler(this.Confirm_Password_Text_OnValueChanged);
            this.Confirm_Password_Text.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Confirm_Password_Text_KeyUp);
            // 
            // CheckCorrect_Button
            // 
            this.CheckCorrect_Button.BackColor = System.Drawing.Color.Transparent;
            this.CheckCorrect_Button.Image = ((System.Drawing.Image)(resources.GetObject("CheckCorrect_Button.Image")));
            this.CheckCorrect_Button.ImageActive = null;
            this.CheckCorrect_Button.Location = new System.Drawing.Point(36, 437);
            this.CheckCorrect_Button.Name = "CheckCorrect_Button";
            this.CheckCorrect_Button.Size = new System.Drawing.Size(30, 30);
            this.CheckCorrect_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CheckCorrect_Button.TabIndex = 34;
            this.CheckCorrect_Button.TabStop = false;
            this.CheckCorrect_Button.Zoom = 10;
            // 
            // Error_Title
            // 
            this.Error_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Error_Title.BackColor = System.Drawing.Color.Transparent;
            this.Error_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Error_Title.ForeColor = System.Drawing.Color.Red;
            this.Error_Title.Location = new System.Drawing.Point(0, 515);
            this.Error_Title.Name = "Error_Title";
            this.Error_Title.Size = new System.Drawing.Size(399, 34);
            this.Error_Title.TabIndex = 35;
            this.Error_Title.Text = "Error";
            this.Error_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PageSignUp_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(399, 671);
            this.Controls.Add(this.Error_Title);
            this.Controls.Add(this.CheckCorrect_Button);
            this.Controls.Add(this.Confirm_Password_Text);
            this.Controls.Add(this.Confirmation_Title);
            this.Controls.Add(this.Sign_Up_Button);
            this.Controls.Add(this.Password_Text);
            this.Controls.Add(this.Password_Title);
            this.Controls.Add(this.User_Name_Title);
            this.Controls.Add(this.Sign_Up_Title);
            this.Controls.Add(this.User_Name_Text);
            this.Controls.Add(this.Panel_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PageSignUp_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PageSignUp_GUI";
            this.Load += new System.EventHandler(this.PageSignUp_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mini_Windows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Windows)).EndInit();
            this.Panel_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CheckCorrect_Button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton Sign_Up_Button;
        private Bunifu.Framework.UI.BunifuElipse BorderButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Password_Text;
        private System.Windows.Forms.Label Password_Title;
        private System.Windows.Forms.Label User_Name_Title;
        private System.Windows.Forms.Label Sign_Up_Title;
        private Bunifu.Framework.UI.BunifuImageButton Mini_Windows;
        private Bunifu.Framework.UI.BunifuImageButton Close_Windows;
        private Bunifu.Framework.UI.BunifuDragControl DragForm;
        private System.Windows.Forms.Panel Panel_Top;
        private Bunifu.Framework.UI.BunifuMaterialTextbox User_Name_Text;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Confirm_Password_Text;
        private System.Windows.Forms.Label Confirmation_Title;
        private Bunifu.Framework.UI.BunifuImageButton CheckCorrect_Button;
        private System.Windows.Forms.Label Error_Title;
    }
}