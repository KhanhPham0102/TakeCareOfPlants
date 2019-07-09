namespace TakeCareOfPlants
{
    partial class PageSetting_GUI
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
            this.Menu_Button = new System.Windows.Forms.Panel();
            this.Save_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Cancel_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Default_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.NumberPlant_Text = new Bunifu.Framework.BunifuCustomTextbox();
            this.AmountMoney_Text = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.MaxPlant_Title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MaxMoney_Title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TypeMaterial_Text = new Bunifu.Framework.BunifuCustomTextbox();
            this.MaxType_Title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.NumberPlant_DropDown = new Telerik.WinControls.UI.RadDropDownList();
            this.Error_Provider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Menu_Button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberPlant_DropDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error_Provider)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu_Button
            // 
            this.Menu_Button.BackColor = System.Drawing.Color.Transparent;
            this.Menu_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Menu_Button.CausesValidation = false;
            this.Menu_Button.Controls.Add(this.Save_Button);
            this.Menu_Button.Controls.Add(this.Cancel_Button);
            this.Menu_Button.Controls.Add(this.Default_Button);
            this.Menu_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Menu_Button.Location = new System.Drawing.Point(0, 280);
            this.Menu_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Menu_Button.Name = "Menu_Button";
            this.Menu_Button.Size = new System.Drawing.Size(600, 60);
            this.Menu_Button.TabIndex = 0;
            // 
            // Save_Button
            // 
            this.Save_Button.Active = false;
            this.Save_Button.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.Save_Button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Save_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Save_Button.BorderRadius = 0;
            this.Save_Button.ButtonText = "Save";
            this.Save_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Save_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Save_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Save_Button.Iconimage = null;
            this.Save_Button.Iconimage_right = null;
            this.Save_Button.Iconimage_right_Selected = null;
            this.Save_Button.Iconimage_Selected = null;
            this.Save_Button.IconMarginLeft = 0;
            this.Save_Button.IconMarginRight = 0;
            this.Save_Button.IconRightVisible = true;
            this.Save_Button.IconRightZoom = 0D;
            this.Save_Button.IconVisible = true;
            this.Save_Button.IconZoom = 90D;
            this.Save_Button.IsTab = false;
            this.Save_Button.Location = new System.Drawing.Point(200, 0);
            this.Save_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Normalcolor = System.Drawing.Color.DeepSkyBlue;
            this.Save_Button.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.Save_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Save_Button.selected = false;
            this.Save_Button.Size = new System.Drawing.Size(200, 60);
            this.Save_Button.TabIndex = 2;
            this.Save_Button.TabStop = false;
            this.Save_Button.Text = "Save";
            this.Save_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Save_Button.Textcolor = System.Drawing.Color.White;
            this.Save_Button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Active = false;
            this.Cancel_Button.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.Cancel_Button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Cancel_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Cancel_Button.BorderRadius = 0;
            this.Cancel_Button.ButtonText = "Cancel";
            this.Cancel_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.Cancel_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Cancel_Button.Iconimage = null;
            this.Cancel_Button.Iconimage_right = null;
            this.Cancel_Button.Iconimage_right_Selected = null;
            this.Cancel_Button.Iconimage_Selected = null;
            this.Cancel_Button.IconMarginLeft = 0;
            this.Cancel_Button.IconMarginRight = 0;
            this.Cancel_Button.IconRightVisible = true;
            this.Cancel_Button.IconRightZoom = 0D;
            this.Cancel_Button.IconVisible = true;
            this.Cancel_Button.IconZoom = 90D;
            this.Cancel_Button.IsTab = false;
            this.Cancel_Button.Location = new System.Drawing.Point(400, 0);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Normalcolor = System.Drawing.Color.DeepSkyBlue;
            this.Cancel_Button.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.Cancel_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Cancel_Button.selected = false;
            this.Cancel_Button.Size = new System.Drawing.Size(200, 60);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.TabStop = false;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cancel_Button.Textcolor = System.Drawing.Color.White;
            this.Cancel_Button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Default_Button
            // 
            this.Default_Button.Active = false;
            this.Default_Button.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.Default_Button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Default_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Default_Button.BorderRadius = 0;
            this.Default_Button.ButtonText = "Default";
            this.Default_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Default_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Default_Button.Dock = System.Windows.Forms.DockStyle.Left;
            this.Default_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Default_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Default_Button.Iconimage = null;
            this.Default_Button.Iconimage_right = null;
            this.Default_Button.Iconimage_right_Selected = null;
            this.Default_Button.Iconimage_Selected = null;
            this.Default_Button.IconMarginLeft = 0;
            this.Default_Button.IconMarginRight = 0;
            this.Default_Button.IconRightVisible = true;
            this.Default_Button.IconRightZoom = 0D;
            this.Default_Button.IconVisible = true;
            this.Default_Button.IconZoom = 90D;
            this.Default_Button.IsTab = false;
            this.Default_Button.Location = new System.Drawing.Point(0, 0);
            this.Default_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Default_Button.Name = "Default_Button";
            this.Default_Button.Normalcolor = System.Drawing.Color.DeepSkyBlue;
            this.Default_Button.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.Default_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Default_Button.selected = false;
            this.Default_Button.Size = new System.Drawing.Size(200, 60);
            this.Default_Button.TabIndex = 0;
            this.Default_Button.TabStop = false;
            this.Default_Button.Text = "Default";
            this.Default_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Default_Button.Textcolor = System.Drawing.Color.White;
            this.Default_Button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Default_Button.Click += new System.EventHandler(this.Default_Button_Click);
            // 
            // NumberPlant_Text
            // 
            this.NumberPlant_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberPlant_Text.BackColor = System.Drawing.Color.White;
            this.NumberPlant_Text.BorderColor = System.Drawing.Color.Black;
            this.NumberPlant_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NumberPlant_Text.Location = new System.Drawing.Point(506, 33);
            this.NumberPlant_Text.Name = "NumberPlant_Text";
            this.NumberPlant_Text.Size = new System.Drawing.Size(47, 28);
            this.NumberPlant_Text.TabIndex = 1;
            this.NumberPlant_Text.TextChanged += new System.EventHandler(this.NumberPlant_Text_TextChanged);
            this.NumberPlant_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberPlant_Text_KeyPress);
            this.NumberPlant_Text.Validating += new System.ComponentModel.CancelEventHandler(this.NumberPlant_Text_Validating);
            // 
            // AmountMoney_Text
            // 
            this.AmountMoney_Text.BackColor = System.Drawing.Color.White;
            this.AmountMoney_Text.BorderColor = System.Drawing.Color.Black;
            this.AmountMoney_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.AmountMoney_Text.Location = new System.Drawing.Point(345, 205);
            this.AmountMoney_Text.Name = "AmountMoney_Text";
            this.AmountMoney_Text.Size = new System.Drawing.Size(208, 28);
            this.AmountMoney_Text.TabIndex = 3;
            this.AmountMoney_Text.TextChanged += new System.EventHandler(this.AmountMoney_Text_TextChanged);
            this.AmountMoney_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountMoney_Text_KeyPress);
            this.AmountMoney_Text.Validating += new System.ComponentModel.CancelEventHandler(this.AmountMoney_Text_Validating);
            // 
            // MaxPlant_Title
            // 
            this.MaxPlant_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxPlant_Title.AutoSize = true;
            this.MaxPlant_Title.BackColor = System.Drawing.Color.Transparent;
            this.MaxPlant_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MaxPlant_Title.Location = new System.Drawing.Point(57, 41);
            this.MaxPlant_Title.Name = "MaxPlant_Title";
            this.MaxPlant_Title.Size = new System.Drawing.Size(249, 20);
            this.MaxPlant_Title.TabIndex = 3;
            this.MaxPlant_Title.Text = "The maximum number of plants:";
            this.MaxPlant_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaxMoney_Title
            // 
            this.MaxMoney_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxMoney_Title.AutoSize = true;
            this.MaxMoney_Title.BackColor = System.Drawing.Color.Transparent;
            this.MaxMoney_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MaxMoney_Title.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaxMoney_Title.Location = new System.Drawing.Point(54, 210);
            this.MaxMoney_Title.Margin = new System.Windows.Forms.Padding(0);
            this.MaxMoney_Title.Name = "MaxMoney_Title";
            this.MaxMoney_Title.Size = new System.Drawing.Size(252, 20);
            this.MaxMoney_Title.TabIndex = 5;
            this.MaxMoney_Title.Text = "The maximum amount of money:";
            this.MaxMoney_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TypeMaterial_Text
            // 
            this.TypeMaterial_Text.BackColor = System.Drawing.Color.White;
            this.TypeMaterial_Text.BorderColor = System.Drawing.Color.Black;
            this.TypeMaterial_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TypeMaterial_Text.Location = new System.Drawing.Point(345, 120);
            this.TypeMaterial_Text.Name = "TypeMaterial_Text";
            this.TypeMaterial_Text.Size = new System.Drawing.Size(208, 28);
            this.TypeMaterial_Text.TabIndex = 2;
            this.TypeMaterial_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TypeMaterial_Text_KeyPress);
            this.TypeMaterial_Text.Validating += new System.ComponentModel.CancelEventHandler(this.TypeMaterial_Text_Validating);
            // 
            // MaxType_Title
            // 
            this.MaxType_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxType_Title.AutoSize = true;
            this.MaxType_Title.BackColor = System.Drawing.Color.Transparent;
            this.MaxType_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MaxType_Title.Location = new System.Drawing.Point(49, 125);
            this.MaxType_Title.Margin = new System.Windows.Forms.Padding(0);
            this.MaxType_Title.Name = "MaxType_Title";
            this.MaxType_Title.Size = new System.Drawing.Size(257, 20);
            this.MaxType_Title.TabIndex = 4;
            this.MaxType_Title.Text = "The maximum types of materials:";
            this.MaxType_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumberPlant_DropDown
            // 
            this.NumberPlant_DropDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberPlant_DropDown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NumberPlant_DropDown.AutoSize = false;
            this.NumberPlant_DropDown.AutoSizeItems = true;
            this.NumberPlant_DropDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumberPlant_DropDown.DropDownMinSize = new System.Drawing.Size(155, 0);
            this.NumberPlant_DropDown.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.NumberPlant_DropDown.Location = new System.Drawing.Point(345, 33);
            this.NumberPlant_DropDown.Name = "NumberPlant_DropDown";
            this.NumberPlant_DropDown.Size = new System.Drawing.Size(155, 28);
            this.NumberPlant_DropDown.TabIndex = 6;
            this.NumberPlant_DropDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumberPlant_DropDown_KeyDown);
            this.NumberPlant_DropDown.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.NumberPlant_DropDown_SelectedIndexChanged);
            this.NumberPlant_DropDown.VisualListItemFormatting += new Telerik.WinControls.UI.VisualListItemFormattingEventHandler(this.NumberPlant_DropDown_VisualListItemFormatting);
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.NumberPlant_DropDown.GetChildAt(0).GetChildAt(0))).ForeColor = System.Drawing.Color.Black;
            ((Telerik.WinControls.UI.RadDropDownTextBoxElement)(this.NumberPlant_DropDown.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 11F);
            // 
            // Error_Provider
            // 
            this.Error_Provider.ContainerControl = this;
            // 
            // PageSetting_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(600, 340);
            this.Controls.Add(this.NumberPlant_DropDown);
            this.Controls.Add(this.TypeMaterial_Text);
            this.Controls.Add(this.MaxMoney_Title);
            this.Controls.Add(this.MaxType_Title);
            this.Controls.Add(this.MaxPlant_Title);
            this.Controls.Add(this.AmountMoney_Text);
            this.Controls.Add(this.NumberPlant_Text);
            this.Controls.Add(this.Menu_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PageSetting_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PageSetting_GUI";
            this.Load += new System.EventHandler(this.PageSetting_GUI_Load);
            this.Menu_Button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumberPlant_DropDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error_Provider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Menu_Button;
        private Bunifu.Framework.UI.BunifuFlatButton Save_Button;
        private Bunifu.Framework.UI.BunifuFlatButton Cancel_Button;
        private Bunifu.Framework.UI.BunifuFlatButton Default_Button;
        private Bunifu.Framework.BunifuCustomTextbox NumberPlant_Text;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox AmountMoney_Text;
        private Bunifu.Framework.UI.BunifuCustomLabel MaxPlant_Title;
        private Bunifu.Framework.UI.BunifuCustomLabel MaxMoney_Title;
        private Bunifu.Framework.BunifuCustomTextbox TypeMaterial_Text;
        private Bunifu.Framework.UI.BunifuCustomLabel MaxType_Title;
        private Telerik.WinControls.UI.RadDropDownList NumberPlant_DropDown;
        private System.Windows.Forms.ErrorProvider Error_Provider;
    }
}