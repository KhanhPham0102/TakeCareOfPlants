namespace TakeCareOfPlants
{
    partial class PageLogin_GUI
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
            if (disposing && (components != null))
            {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageLogin_GUI));
            this.DragForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Panel_Top = new System.Windows.Forms.Panel();
            this.Mini_Windows = new Bunifu.Framework.UI.BunifuImageButton();
            this.Close_Windows = new Bunifu.Framework.UI.BunifuImageButton();
            this.Sign_In_Title = new System.Windows.Forms.Label();
            this.User_Name_Title = new System.Windows.Forms.Label();
            this.Password_Title = new System.Windows.Forms.Label();
            this.Password_Text = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Remember_Password_Check = new Bunifu.Framework.UI.BunifuCheckbox();
            this.Remember_Password_Text = new System.Windows.Forms.Label();
            this.Facebook_icon = new Bunifu.Framework.UI.BunifuImageButton();
            this.Google_icon = new Bunifu.Framework.UI.BunifuImageButton();
            this.Twitter_icon = new Bunifu.Framework.UI.BunifuImageButton();
            this.GitHub_icon = new Bunifu.Framework.UI.BunifuImageButton();
            this.BorderButton = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Sign_In_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.User_Name_Text = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Forgot_Password_Title = new System.Windows.Forms.Label();
            this.Sign_Up_Title = new System.Windows.Forms.Label();
            this.Sign_Up_Text = new System.Windows.Forms.Label();
            this.Show_Pass_Icon = new Bunifu.Framework.UI.BunifuImageButton();
            this.Error_Text = new System.Windows.Forms.Label();
            this.Panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mini_Windows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Windows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Facebook_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Google_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Twitter_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GitHub_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Show_Pass_Icon)).BeginInit();
            this.SuspendLayout();
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
            this.Panel_Top.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_Top.Name = "Panel_Top";
            this.Panel_Top.Size = new System.Drawing.Size(399, 44);
            this.Panel_Top.TabIndex = 0;
            // 
            // Mini_Windows
            // 
            this.Mini_Windows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mini_Windows.BackColor = System.Drawing.Color.Transparent;
            this.Mini_Windows.Image = ((System.Drawing.Image)(resources.GetObject("Mini_Windows.Image")));
            this.Mini_Windows.ImageActive = null;
            this.Mini_Windows.Location = new System.Drawing.Point(323, 5);
            this.Mini_Windows.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mini_Windows.Name = "Mini_Windows";
            this.Mini_Windows.Size = new System.Drawing.Size(35, 34);
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
            this.Close_Windows.Location = new System.Drawing.Point(357, 5);
            this.Close_Windows.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Close_Windows.Name = "Close_Windows";
            this.Close_Windows.Size = new System.Drawing.Size(35, 34);
            this.Close_Windows.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close_Windows.TabIndex = 16;
            this.Close_Windows.TabStop = false;
            this.Close_Windows.Zoom = 10;
            this.Close_Windows.Click += new System.EventHandler(this.Close_Windows_Click);
            // 
            // Sign_In_Title
            // 
            this.Sign_In_Title.AutoSize = true;
            this.Sign_In_Title.BackColor = System.Drawing.Color.Transparent;
            this.Sign_In_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Sign_In_Title.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Sign_In_Title.Location = new System.Drawing.Point(27, 84);
            this.Sign_In_Title.Name = "Sign_In_Title";
            this.Sign_In_Title.Size = new System.Drawing.Size(103, 32);
            this.Sign_In_Title.TabIndex = 4;
            this.Sign_In_Title.Text = "Sign In";
            // 
            // User_Name_Title
            // 
            this.User_Name_Title.AutoSize = true;
            this.User_Name_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.User_Name_Title.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.User_Name_Title.Location = new System.Drawing.Point(44, 153);
            this.User_Name_Title.Name = "User_Name_Title";
            this.User_Name_Title.Size = new System.Drawing.Size(116, 25);
            this.User_Name_Title.TabIndex = 5;
            this.User_Name_Title.Text = "User Name:";
            // 
            // Password_Title
            // 
            this.Password_Title.AutoSize = true;
            this.Password_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Password_Title.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Password_Title.Location = new System.Drawing.Point(44, 249);
            this.Password_Title.Name = "Password_Title";
            this.Password_Title.Size = new System.Drawing.Size(104, 25);
            this.Password_Title.TabIndex = 6;
            this.Password_Title.Text = "Password:";
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
            this.Password_Text.Location = new System.Drawing.Point(73, 282);
            this.Password_Text.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Password_Text.MaxLength = 32767;
            this.Password_Text.Name = "Password_Text";
            this.Password_Text.Size = new System.Drawing.Size(229, 52);
            this.Password_Text.TabIndex = 1;
            this.Password_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password_Text.OnValueChanged += new System.EventHandler(this.Password_Text_OnValueChanged);
            this.Password_Text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_Text_KeyDown);
            // 
            // Remember_Password_Check
            // 
            this.Remember_Password_Check.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Remember_Password_Check.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Remember_Password_Check.ChechedOffColor = System.Drawing.Color.DeepSkyBlue;
            this.Remember_Password_Check.Checked = false;
            this.Remember_Password_Check.CheckedOnColor = System.Drawing.Color.DeepSkyBlue;
            this.Remember_Password_Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Remember_Password_Check.ForeColor = System.Drawing.Color.White;
            this.Remember_Password_Check.Location = new System.Drawing.Point(72, 368);
            this.Remember_Password_Check.Margin = new System.Windows.Forms.Padding(5);
            this.Remember_Password_Check.Name = "Remember_Password_Check";
            this.Remember_Password_Check.Size = new System.Drawing.Size(20, 20);
            this.Remember_Password_Check.TabIndex = 9;
            this.Remember_Password_Check.TabStop = false;
            // 
            // Remember_Password_Text
            // 
            this.Remember_Password_Text.AutoSize = true;
            this.Remember_Password_Text.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Remember_Password_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Remember_Password_Text.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Remember_Password_Text.Location = new System.Drawing.Point(131, 368);
            this.Remember_Password_Text.Name = "Remember_Password_Text";
            this.Remember_Password_Text.Size = new System.Drawing.Size(192, 24);
            this.Remember_Password_Text.TabIndex = 10;
            this.Remember_Password_Text.Text = "Remember Password";
            this.Remember_Password_Text.Click += new System.EventHandler(this.Remember_Password_Click);
            // 
            // Facebook_icon
            // 
            this.Facebook_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Facebook_icon.Image = ((System.Drawing.Image)(resources.GetObject("Facebook_icon.Image")));
            this.Facebook_icon.ImageActive = null;
            this.Facebook_icon.Location = new System.Drawing.Point(89, 537);
            this.Facebook_icon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Facebook_icon.Name = "Facebook_icon";
            this.Facebook_icon.Size = new System.Drawing.Size(41, 38);
            this.Facebook_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Facebook_icon.TabIndex = 11;
            this.Facebook_icon.TabStop = false;
            this.Facebook_icon.Zoom = 10;
            // 
            // Google_icon
            // 
            this.Google_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Google_icon.Image = ((System.Drawing.Image)(resources.GetObject("Google_icon.Image")));
            this.Google_icon.ImageActive = null;
            this.Google_icon.Location = new System.Drawing.Point(149, 537);
            this.Google_icon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Google_icon.Name = "Google_icon";
            this.Google_icon.Size = new System.Drawing.Size(41, 38);
            this.Google_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Google_icon.TabIndex = 12;
            this.Google_icon.TabStop = false;
            this.Google_icon.Zoom = 10;
            // 
            // Twitter_icon
            // 
            this.Twitter_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Twitter_icon.Image = ((System.Drawing.Image)(resources.GetObject("Twitter_icon.Image")));
            this.Twitter_icon.ImageActive = null;
            this.Twitter_icon.Location = new System.Drawing.Point(205, 537);
            this.Twitter_icon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Twitter_icon.Name = "Twitter_icon";
            this.Twitter_icon.Size = new System.Drawing.Size(41, 38);
            this.Twitter_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Twitter_icon.TabIndex = 13;
            this.Twitter_icon.TabStop = false;
            this.Twitter_icon.Zoom = 10;
            // 
            // GitHub_icon
            // 
            this.GitHub_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GitHub_icon.Image = ((System.Drawing.Image)(resources.GetObject("GitHub_icon.Image")));
            this.GitHub_icon.ImageActive = null;
            this.GitHub_icon.Location = new System.Drawing.Point(261, 537);
            this.GitHub_icon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GitHub_icon.Name = "GitHub_icon";
            this.GitHub_icon.Size = new System.Drawing.Size(41, 38);
            this.GitHub_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GitHub_icon.TabIndex = 14;
            this.GitHub_icon.TabStop = false;
            this.GitHub_icon.Zoom = 10;
            // 
            // BorderButton
            // 
            this.BorderButton.ElipseRadius = 15;
            this.BorderButton.TargetControl = this.Sign_In_Button;
            // 
            // Sign_In_Button
            // 
            this.Sign_In_Button.Active = false;
            this.Sign_In_Button.Activecolor = System.Drawing.Color.DeepSkyBlue;
            this.Sign_In_Button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Sign_In_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Sign_In_Button.BorderRadius = 0;
            this.Sign_In_Button.ButtonText = "Sign In";
            this.Sign_In_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sign_In_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Sign_In_Button.ForeColor = System.Drawing.Color.White;
            this.Sign_In_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Sign_In_Button.Iconimage = null;
            this.Sign_In_Button.Iconimage_right = null;
            this.Sign_In_Button.Iconimage_right_Selected = null;
            this.Sign_In_Button.Iconimage_Selected = null;
            this.Sign_In_Button.IconMarginLeft = 0;
            this.Sign_In_Button.IconMarginRight = 0;
            this.Sign_In_Button.IconRightVisible = true;
            this.Sign_In_Button.IconRightZoom = 0D;
            this.Sign_In_Button.IconVisible = true;
            this.Sign_In_Button.IconZoom = 90D;
            this.Sign_In_Button.IsTab = false;
            this.Sign_In_Button.Location = new System.Drawing.Point(39, 473);
            this.Sign_In_Button.Margin = new System.Windows.Forms.Padding(5);
            this.Sign_In_Button.Name = "Sign_In_Button";
            this.Sign_In_Button.Normalcolor = System.Drawing.Color.DeepSkyBlue;
            this.Sign_In_Button.OnHovercolor = System.Drawing.Color.SkyBlue;
            this.Sign_In_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Sign_In_Button.selected = false;
            this.Sign_In_Button.Size = new System.Drawing.Size(321, 43);
            this.Sign_In_Button.TabIndex = 15;
            this.Sign_In_Button.TabStop = false;
            this.Sign_In_Button.Text = "Sign In";
            this.Sign_In_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Sign_In_Button.Textcolor = System.Drawing.Color.White;
            this.Sign_In_Button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Sign_In_Button.Click += new System.EventHandler(this.Sign_In_Button_Click);
            // 
            // User_Name_Text
            // 
            this.User_Name_Text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.User_Name_Text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.User_Name_Text.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
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
            this.User_Name_Text.Location = new System.Drawing.Point(73, 185);
            this.User_Name_Text.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.User_Name_Text.MaxLength = 32767;
            this.User_Name_Text.Name = "User_Name_Text";
            this.User_Name_Text.Size = new System.Drawing.Size(264, 48);
            this.User_Name_Text.TabIndex = 0;
            this.User_Name_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.User_Name_Text.OnValueChanged += new System.EventHandler(this.User_Name_Text_OnValueChanged);
            // 
            // Forgot_Password_Title
            // 
            this.Forgot_Password_Title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Forgot_Password_Title.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Forgot_Password_Title.Location = new System.Drawing.Point(119, 633);
            this.Forgot_Password_Title.Name = "Forgot_Password_Title";
            this.Forgot_Password_Title.Size = new System.Drawing.Size(153, 17);
            this.Forgot_Password_Title.TabIndex = 16;
            this.Forgot_Password_Title.Text = "Forgot your password?";
            this.Forgot_Password_Title.MouseLeave += new System.EventHandler(this.Forgot_Password_Title_MouseLeave);
            this.Forgot_Password_Title.MouseHover += new System.EventHandler(this.Forgot_Password_Title_MouseHover);
            // 
            // Sign_Up_Title
            // 
            this.Sign_Up_Title.AutoSize = true;
            this.Sign_Up_Title.Location = new System.Drawing.Point(84, 610);
            this.Sign_Up_Title.Name = "Sign_Up_Title";
            this.Sign_Up_Title.Size = new System.Drawing.Size(158, 17);
            this.Sign_Up_Title.TabIndex = 17;
            this.Sign_Up_Title.Text = "Don\'t have an account?";
            // 
            // Sign_Up_Text
            // 
            this.Sign_Up_Text.AutoSize = true;
            this.Sign_Up_Text.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sign_Up_Text.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Sign_Up_Text.Location = new System.Drawing.Point(241, 609);
            this.Sign_Up_Text.Name = "Sign_Up_Text";
            this.Sign_Up_Text.Size = new System.Drawing.Size(58, 17);
            this.Sign_Up_Text.TabIndex = 18;
            this.Sign_Up_Text.Text = "Sign Up";
            this.Sign_Up_Text.Click += new System.EventHandler(this.Sign_Up_Text_Click);
            this.Sign_Up_Text.MouseLeave += new System.EventHandler(this.Sign_Up_Text_MouseLeave);
            this.Sign_Up_Text.MouseHover += new System.EventHandler(this.Sign_Up_Text_MouseHover);
            // 
            // Show_Pass_Icon
            // 
            this.Show_Pass_Icon.BackColor = System.Drawing.Color.Transparent;
            this.Show_Pass_Icon.Image = ((System.Drawing.Image)(resources.GetObject("Show_Pass_Icon.Image")));
            this.Show_Pass_Icon.ImageActive = null;
            this.Show_Pass_Icon.Location = new System.Drawing.Point(307, 295);
            this.Show_Pass_Icon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Show_Pass_Icon.Name = "Show_Pass_Icon";
            this.Show_Pass_Icon.Size = new System.Drawing.Size(28, 32);
            this.Show_Pass_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Show_Pass_Icon.TabIndex = 19;
            this.Show_Pass_Icon.TabStop = false;
            this.Show_Pass_Icon.Zoom = 10;
            this.Show_Pass_Icon.Click += new System.EventHandler(this.Show_Pass_Icon_Click);
            // 
            // Error_Text
            // 
            this.Error_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Error_Text.BackColor = System.Drawing.Color.Transparent;
            this.Error_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Error_Text.ForeColor = System.Drawing.Color.Red;
            this.Error_Text.Location = new System.Drawing.Point(0, 416);
            this.Error_Text.Name = "Error_Text";
            this.Error_Text.Size = new System.Drawing.Size(399, 36);
            this.Error_Text.TabIndex = 20;
            this.Error_Text.Text = "Error";
            this.Error_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Error_Text.Visible = false;
            // 
            // PageLogin_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(399, 671);
            this.Controls.Add(this.Error_Text);
            this.Controls.Add(this.Show_Pass_Icon);
            this.Controls.Add(this.Sign_Up_Text);
            this.Controls.Add(this.Sign_Up_Title);
            this.Controls.Add(this.Forgot_Password_Title);
            this.Controls.Add(this.Sign_In_Button);
            this.Controls.Add(this.GitHub_icon);
            this.Controls.Add(this.Twitter_icon);
            this.Controls.Add(this.Google_icon);
            this.Controls.Add(this.Facebook_icon);
            this.Controls.Add(this.Remember_Password_Text);
            this.Controls.Add(this.Remember_Password_Check);
            this.Controls.Add(this.Password_Text);
            this.Controls.Add(this.User_Name_Text);
            this.Controls.Add(this.Password_Title);
            this.Controls.Add(this.User_Name_Title);
            this.Controls.Add(this.Sign_In_Title);
            this.Controls.Add(this.Panel_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PageLogin_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PageLogin";
            this.Load += new System.EventHandler(this.PageLogin_Load);
            this.Panel_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Mini_Windows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Windows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Facebook_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Google_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Twitter_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GitHub_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Show_Pass_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl DragForm;
        private System.Windows.Forms.Panel Panel_Top;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Password_Text;
        private System.Windows.Forms.Label Password_Title;
        private System.Windows.Forms.Label User_Name_Title;
        private System.Windows.Forms.Label Sign_In_Title;
        private Bunifu.Framework.UI.BunifuCheckbox Remember_Password_Check;
        private System.Windows.Forms.Label Remember_Password_Text;
        private Bunifu.Framework.UI.BunifuImageButton GitHub_icon;
        private Bunifu.Framework.UI.BunifuImageButton Twitter_icon;
        private Bunifu.Framework.UI.BunifuImageButton Google_icon;
        private Bunifu.Framework.UI.BunifuImageButton Facebook_icon;
        private Bunifu.Framework.UI.BunifuElipse BorderButton;
        private Bunifu.Framework.UI.BunifuFlatButton Sign_In_Button;
        private Bunifu.Framework.UI.BunifuMaterialTextbox User_Name_Text;
        private Bunifu.Framework.UI.BunifuImageButton Close_Windows;
        private Bunifu.Framework.UI.BunifuImageButton Mini_Windows;
        private System.Windows.Forms.Label Forgot_Password_Title;
        private System.Windows.Forms.Label Sign_Up_Text;
        private System.Windows.Forms.Label Sign_Up_Title;
        private Bunifu.Framework.UI.BunifuImageButton Show_Pass_Icon;
        private System.Windows.Forms.Label Error_Text;
    }
}