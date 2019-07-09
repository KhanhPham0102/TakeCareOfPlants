namespace TakeCareOfPlants
{
    partial class UI_Calendar
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Material_Title = new System.Windows.Forms.Label();
            this.Time_Title = new System.Windows.Forms.Label();
            this.Note_Title = new System.Windows.Forms.Label();
            this.List_Time_DataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlantName_Title = new System.Windows.Forms.Label();
            this.List_Time_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Create_Button = new System.Windows.Forms.Button();
            this.Create_Button_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PlantName_DropDown = new Telerik.WinControls.UI.RadCheckedDropDownList();
            this.object_6a402753_efe0_44cf_a82f_63d9c8b418a9 = new Telerik.WinControls.UI.RadDropDownListRootElement();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Update_Button_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Clear_Calendar_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Material_DropDown = new Telerik.WinControls.UI.RadCheckedDropDownList();
            this.Time_Pick = new Telerik.WinControls.UI.RadTimePicker();
            this.object_58c7e8de_d9c3_4e5f_8d4b_c920b045c9fb = new Telerik.WinControls.UI.RadDropDownListRootElement();
            this.object_e72eab59_cf89_4488_90ad_be547ab79041 = new Telerik.WinControls.RootRadElement();
            this.Note_Text = new Bunifu.Framework.BunifuCustomTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.List_Time_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlantName_DropDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Material_DropDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time_Pick)).BeginInit();
            this.SuspendLayout();
            // 
            // Material_Title
            // 
            this.Material_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Material_Title.AutoSize = true;
            this.Material_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Material_Title.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Material_Title.Location = new System.Drawing.Point(30, 120);
            this.Material_Title.Name = "Material_Title";
            this.Material_Title.Size = new System.Drawing.Size(87, 25);
            this.Material_Title.TabIndex = 16;
            this.Material_Title.Text = "Material:";
            // 
            // Time_Title
            // 
            this.Time_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Time_Title.AutoSize = true;
            this.Time_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Time_Title.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Time_Title.Location = new System.Drawing.Point(30, 28);
            this.Time_Title.Name = "Time_Title";
            this.Time_Title.Size = new System.Drawing.Size(62, 25);
            this.Time_Title.TabIndex = 22;
            this.Time_Title.Text = "Time:";
            // 
            // Note_Title
            // 
            this.Note_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Note_Title.AutoSize = true;
            this.Note_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Note_Title.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Note_Title.Location = new System.Drawing.Point(30, 212);
            this.Note_Title.Name = "Note_Title";
            this.Note_Title.Size = new System.Drawing.Size(59, 25);
            this.Note_Title.TabIndex = 28;
            this.Note_Title.Text = "Note:";
            // 
            // List_Time_DataGrid
            // 
            this.List_Time_DataGrid.AllowUserToAddRows = false;
            this.List_Time_DataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.List_Time_DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.List_Time_DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.List_Time_DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.List_Time_DataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.List_Time_DataGrid.BackgroundColor = System.Drawing.Color.LightBlue;
            this.List_Time_DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.List_Time_DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.List_Time_DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.List_Time_DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.List_Time_DataGrid.ColumnHeadersHeight = 30;
            this.List_Time_DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Time,
            this.Material,
            this.Unit,
            this.Amount,
            this.Note});
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.List_Time_DataGrid.DefaultCellStyle = dataGridViewCellStyle24;
            this.List_Time_DataGrid.DoubleBuffered = true;
            this.List_Time_DataGrid.EnableHeadersVisualStyles = false;
            this.List_Time_DataGrid.HeaderBgColor = System.Drawing.Color.DeepSkyBlue;
            this.List_Time_DataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.List_Time_DataGrid.ImeMode = System.Windows.Forms.ImeMode.On;
            this.List_Time_DataGrid.Location = new System.Drawing.Point(445, 90);
            this.List_Time_DataGrid.MultiSelect = false;
            this.List_Time_DataGrid.Name = "List_Time_DataGrid";
            this.List_Time_DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.List_Time_DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.List_Time_DataGrid.RowHeadersVisible = false;
            this.List_Time_DataGrid.RowHeadersWidth = 51;
            this.List_Time_DataGrid.RowTemplate.DividerHeight = 1;
            this.List_Time_DataGrid.RowTemplate.Height = 30;
            this.List_Time_DataGrid.RowTemplate.ReadOnly = true;
            this.List_Time_DataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.List_Time_DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.List_Time_DataGrid.Size = new System.Drawing.Size(769, 395);
            this.List_Time_DataGrid.TabIndex = 29;
            this.List_Time_DataGrid.TabStop = false;
            this.List_Time_DataGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.List_Time_DataGrid_EditingControlShowing);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.STT.DefaultCellStyle = dataGridViewCellStyle23;
            this.STT.FillWeight = 30F;
            this.STT.Frozen = true;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 55;
            // 
            // Time
            // 
            this.Time.FillWeight = 86.92893F;
            this.Time.HeaderText = "Thời Gian";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            // 
            // Material
            // 
            this.Material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Material.DisplayStyleForCurrentCellOnly = true;
            this.Material.FillWeight = 86.92893F;
            this.Material.HeaderText = "Vật Tư";
            this.Material.MinimumWidth = 6;
            this.Material.Name = "Material";
            this.Material.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Material.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Unit
            // 
            this.Unit.FillWeight = 86.92893F;
            this.Unit.HeaderText = "Đơn Vị Tính";
            this.Unit.MinimumWidth = 6;
            this.Unit.Name = "Unit";
            this.Unit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Số Lượng";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            // 
            // Note
            // 
            this.Note.HeaderText = "Ghi Chú";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            // 
            // PlantName_Title
            // 
            this.PlantName_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlantName_Title.AutoSize = true;
            this.PlantName_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PlantName_Title.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.PlantName_Title.Location = new System.Drawing.Point(527, 28);
            this.PlantName_Title.Name = "PlantName_Title";
            this.PlantName_Title.Size = new System.Drawing.Size(62, 25);
            this.PlantName_Title.TabIndex = 30;
            this.PlantName_Title.Text = "Plant:";
            // 
            // List_Time_Elipse
            // 
            this.List_Time_Elipse.ElipseRadius = 10;
            this.List_Time_Elipse.TargetControl = this.List_Time_DataGrid;
            // 
            // Create_Button
            // 
            this.Create_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Create_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.Create_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Create_Button.FlatAppearance.BorderSize = 0;
            this.Create_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Create_Button.ForeColor = System.Drawing.Color.White;
            this.Create_Button.Location = new System.Drawing.Point(65, 511);
            this.Create_Button.Name = "Create_Button";
            this.Create_Button.Size = new System.Drawing.Size(167, 45);
            this.Create_Button.TabIndex = 32;
            this.Create_Button.Text = "New Time";
            this.Create_Button.UseVisualStyleBackColor = false;
            this.Create_Button.Click += new System.EventHandler(this.Create_Button_Click);
            // 
            // Create_Button_Elipse
            // 
            this.Create_Button_Elipse.ElipseRadius = 20;
            this.Create_Button_Elipse.TargetControl = this.Create_Button;
            // 
            // PlantName_DropDown
            // 
            this.PlantName_DropDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlantName_DropDown.AutoSize = false;
            this.PlantName_DropDown.AutoSizeItems = true;
            this.PlantName_DropDown.BackColor = System.Drawing.Color.Transparent;
            this.PlantName_DropDown.DropDownMinSize = new System.Drawing.Size(343, 0);
            this.PlantName_DropDown.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.PlantName_DropDown.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.PlantName_DropDown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlantName_DropDown.Location = new System.Drawing.Point(604, 24);
            this.PlantName_DropDown.Multiline = true;
            this.PlantName_DropDown.Name = "PlantName_DropDown";
            // 
            // 
            // 
            this.PlantName_DropDown.RootElement.ApplyShapeToControl = false;
            this.PlantName_DropDown.Size = new System.Drawing.Size(343, 51);
            this.PlantName_DropDown.TabIndex = 3;
            this.PlantName_DropDown.TextBlockFormatting += new Telerik.WinControls.UI.TextBlockFormattingEventHandler(this.PlantName_DropDown_TextBlockFormatting);
            this.PlantName_DropDown.ItemCheckedChanged += new Telerik.WinControls.UI.RadCheckedListDataItemEventHandler(this.PlantName_DropDown_ItemCheckedChanged);
            this.PlantName_DropDown.VisualListItemFormatting += new Telerik.WinControls.UI.VisualListItemFormattingEventHandler(this.PlantName_DropDown_VisualListItemFormatting);
            ((Telerik.WinControls.UI.RadCheckedDropDownListElement)(this.PlantName_DropDown.GetChildAt(0))).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            ((Telerik.WinControls.UI.RadCheckedDropDownListElement)(this.PlantName_DropDown.GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 15F);
            ((Telerik.WinControls.UI.RadCheckedDropDownListElement)(this.PlantName_DropDown.GetChildAt(0))).CustomFont = "None";
            ((Telerik.WinControls.UI.RadCheckedDropDownListElement)(this.PlantName_DropDown.GetChildAt(0))).CustomFontSize = 15F;
            ((Telerik.WinControls.UI.RadCheckedDropDownListElement)(this.PlantName_DropDown.GetChildAt(0))).AutoSize = true;
            ((Telerik.WinControls.UI.RadCheckedDropDownListElement)(this.PlantName_DropDown.GetChildAt(0))).Alignment = System.Drawing.ContentAlignment.TopLeft;
            ((Telerik.WinControls.UI.RadCheckedDropDownListElement)(this.PlantName_DropDown.GetChildAt(0))).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.PlantName_DropDown.GetChildAt(0).GetChildAt(0))).AutoSize = true;
            ((Telerik.WinControls.UI.RadCheckedDropDownListEditableAreaElement)(this.PlantName_DropDown.GetChildAt(0).GetChildAt(2).GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 12F);
            ((Telerik.WinControls.UI.RadCheckedDropDownListEditableAreaElement)(this.PlantName_DropDown.GetChildAt(0).GetChildAt(2).GetChildAt(0))).CustomFontSize = 14F;
            ((Telerik.WinControls.UI.RadCheckedDropDownListEditableAreaElement)(this.PlantName_DropDown.GetChildAt(0).GetChildAt(2).GetChildAt(0))).AutoSize = true;
            ((Telerik.WinControls.UI.RadCheckedDropDownListEditableAreaElement)(this.PlantName_DropDown.GetChildAt(0).GetChildAt(2).GetChildAt(0))).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.Auto;
            // 
            // object_6a402753_efe0_44cf_a82f_63d9c8b418a9
            // 
            this.object_6a402753_efe0_44cf_a82f_63d9c8b418a9.ApplyShapeToControl = false;
            this.object_6a402753_efe0_44cf_a82f_63d9c8b418a9.Name = "object_6a402753_efe0_44cf_a82f_63d9c8b418a9";
            this.object_6a402753_efe0_44cf_a82f_63d9c8b418a9.StretchHorizontally = true;
            this.object_6a402753_efe0_44cf_a82f_63d9c8b418a9.StretchVertically = true;
            // 
            // Clear_Button
            // 
            this.Clear_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.Clear_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear_Button.FlatAppearance.BorderSize = 0;
            this.Clear_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Clear_Button.ForeColor = System.Drawing.Color.White;
            this.Clear_Button.Location = new System.Drawing.Point(499, 511);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(173, 45);
            this.Clear_Button.TabIndex = 35;
            this.Clear_Button.TabStop = false;
            this.Clear_Button.Text = "Clear Data";
            this.Clear_Button.UseVisualStyleBackColor = false;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Update_Button
            // 
            this.Update_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Update_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.Update_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Update_Button.FlatAppearance.BorderSize = 0;
            this.Update_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Update_Button.ForeColor = System.Drawing.Color.White;
            this.Update_Button.Location = new System.Drawing.Point(278, 511);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(177, 45);
            this.Update_Button.TabIndex = 34;
            this.Update_Button.TabStop = false;
            this.Update_Button.Text = "Update Time";
            this.Update_Button.UseVisualStyleBackColor = false;
            // 
            // Update_Button_Elipse
            // 
            this.Update_Button_Elipse.ElipseRadius = 20;
            this.Update_Button_Elipse.TargetControl = this.Update_Button;
            // 
            // Clear_Calendar_Elipse
            // 
            this.Clear_Calendar_Elipse.ElipseRadius = 20;
            this.Clear_Calendar_Elipse.TargetControl = this.Clear_Button;
            // 
            // Material_DropDown
            // 
            this.Material_DropDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Material_DropDown.AutoSize = false;
            this.Material_DropDown.AutoSizeItems = true;
            this.Material_DropDown.BackColor = System.Drawing.Color.Transparent;
            this.Material_DropDown.DropDownMinSize = new System.Drawing.Size(356, 0);
            this.Material_DropDown.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.UpDown;
            this.Material_DropDown.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Material_DropDown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Material_DropDown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Material_DropDown.Location = new System.Drawing.Point(60, 148);
            this.Material_DropDown.Multiline = true;
            this.Material_DropDown.Name = "Material_DropDown";
            // 
            // 
            // 
            this.Material_DropDown.RootElement.ApplyShapeToControl = false;
            this.Material_DropDown.RootElement.BorderHighlightColor = System.Drawing.Color.White;
            this.Material_DropDown.RootElement.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Material_DropDown.Size = new System.Drawing.Size(356, 62);
            this.Material_DropDown.TabIndex = 1;
            this.Material_DropDown.TextBlockFormatting += new Telerik.WinControls.UI.TextBlockFormattingEventHandler(this.Material_DropDown_TextBlockFormatting);
            this.Material_DropDown.ItemCheckedChanged += new Telerik.WinControls.UI.RadCheckedListDataItemEventHandler(this.Material_DropDown_ItemCheckedChanged);
            this.Material_DropDown.VisualListItemFormatting += new Telerik.WinControls.UI.VisualListItemFormattingEventHandler(this.Material_DropDown_VisualListItemFormatting);
            ((Telerik.WinControls.UI.RadCheckedDropDownListElement)(this.Material_DropDown.GetChildAt(0))).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            ((Telerik.WinControls.UI.RadCheckedDropDownListElement)(this.Material_DropDown.GetChildAt(0))).FocusBorderColor = System.Drawing.Color.Gray;
            ((Telerik.WinControls.UI.RadCheckedDropDownListElement)(this.Material_DropDown.GetChildAt(0))).BorderHighlightColor = System.Drawing.Color.White;
            ((Telerik.WinControls.UI.RadCheckedDropDownListElement)(this.Material_DropDown.GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 11F);
            ((Telerik.WinControls.UI.RadCheckedDropDownListElement)(this.Material_DropDown.GetChildAt(0))).CustomFont = "None";
            ((Telerik.WinControls.UI.RadCheckedDropDownListElement)(this.Material_DropDown.GetChildAt(0))).CustomFontSize = 12F;
            ((Telerik.WinControls.UI.RadCheckedDropDownListElement)(this.Material_DropDown.GetChildAt(0))).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.Material_DropDown.GetChildAt(0).GetChildAt(0))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(189)))), ((int)(((byte)(232)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.Material_DropDown.GetChildAt(0).GetChildAt(0))).AutoSize = true;
            ((Telerik.WinControls.UI.RadCheckedDropDownListEditableAreaElement)(this.Material_DropDown.GetChildAt(0).GetChildAt(2).GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 12F);
            ((Telerik.WinControls.UI.RadCheckedDropDownListEditableAreaElement)(this.Material_DropDown.GetChildAt(0).GetChildAt(2).GetChildAt(0))).CustomFontSize = 14F;
            ((Telerik.WinControls.UI.RadCheckedDropDownListEditableAreaElement)(this.Material_DropDown.GetChildAt(0).GetChildAt(2).GetChildAt(0))).AutoSize = true;
            ((Telerik.WinControls.UI.RadCheckedDropDownListEditableAreaElement)(this.Material_DropDown.GetChildAt(0).GetChildAt(2).GetChildAt(0))).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.Auto;
            ((Telerik.WinControls.UI.CheckedDropDownAutoCompleteBoxElement)(this.Material_DropDown.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0))).BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(189)))), ((int)(((byte)(232)))));
            ((Telerik.WinControls.UI.RadDropDownListArrowButtonElement)(this.Material_DropDown.GetChildAt(0).GetChildAt(2).GetChildAt(1))).BorderHighlightColor = System.Drawing.Color.White;
            ((Telerik.WinControls.UI.RadDropDownListArrowButtonElement)(this.Material_DropDown.GetChildAt(0).GetChildAt(2).GetChildAt(1))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.Material_DropDown.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.ArrowPrimitive)(this.Material_DropDown.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2))).ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // Time_Pick
            // 
            this.Time_Pick.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Time_Pick.AutoSize = false;
            this.Time_Pick.BackColor = System.Drawing.Color.Transparent;
            this.Time_Pick.ClockPosition = Telerik.WinControls.UI.ClockPosition.HideClock;
            this.Time_Pick.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Time_Pick.Location = new System.Drawing.Point(60, 55);
            this.Time_Pick.MaxValue = new System.DateTime(9999, 12, 31, 23, 59, 59, 0);
            this.Time_Pick.MinValue = new System.DateTime(((long)(0)));
            this.Time_Pick.Name = "Time_Pick";
            this.Time_Pick.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            // 
            // 
            // 
            this.Time_Pick.RootElement.AutoSize = true;
            this.Time_Pick.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize;
            this.Time_Pick.RootElement.FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent;
            this.Time_Pick.Size = new System.Drawing.Size(356, 62);
            this.Time_Pick.Step = 30;
            this.Time_Pick.TabIndex = 0;
            this.Time_Pick.TabStop = false;
            this.Time_Pick.TimeTables = Telerik.WinControls.UI.TimeTables.HoursAndMinutesInOneTable;
            this.Time_Pick.Value = new System.DateTime(2019, 7, 5, 4, 23, 0, 0);
            ((Telerik.WinControls.UI.RadTimePickerElement)(this.Time_Pick.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            ((Telerik.WinControls.UI.RadTimePickerElement)(this.Time_Pick.GetChildAt(0))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.Time_Pick.GetChildAt(0).GetChildAt(0))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.Time_Pick.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(189)))), ((int)(((byte)(232)))));
            ((Telerik.WinControls.UI.StackLayoutElement)(this.Time_Pick.GetChildAt(0).GetChildAt(2))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadTimeMaskedEditBoxElement)(this.Time_Pick.GetChildAt(0).GetChildAt(2).GetChildAt(0))).Text = "4:23 AM";
            ((Telerik.WinControls.UI.RadTimeMaskedEditBoxElement)(this.Time_Pick.GetChildAt(0).GetChildAt(2).GetChildAt(0))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.Time_Pick.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // object_58c7e8de_d9c3_4e5f_8d4b_c920b045c9fb
            // 
            this.object_58c7e8de_d9c3_4e5f_8d4b_c920b045c9fb.ApplyShapeToControl = false;
            this.object_58c7e8de_d9c3_4e5f_8d4b_c920b045c9fb.Name = "object_58c7e8de_d9c3_4e5f_8d4b_c920b045c9fb";
            this.object_58c7e8de_d9c3_4e5f_8d4b_c920b045c9fb.StretchHorizontally = true;
            this.object_58c7e8de_d9c3_4e5f_8d4b_c920b045c9fb.StretchVertically = true;
            // 
            // object_e72eab59_cf89_4488_90ad_be547ab79041
            // 
            this.object_e72eab59_cf89_4488_90ad_be547ab79041.Name = "object_e72eab59_cf89_4488_90ad_be547ab79041";
            this.object_e72eab59_cf89_4488_90ad_be547ab79041.StretchHorizontally = true;
            this.object_e72eab59_cf89_4488_90ad_be547ab79041.StretchVertically = true;
            // 
            // Note_Text
            // 
            this.Note_Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Note_Text.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Note_Text.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(189)))), ((int)(((byte)(232)))));
            this.Note_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Note_Text.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Note_Text.Location = new System.Drawing.Point(60, 240);
            this.Note_Text.Multiline = true;
            this.Note_Text.Name = "Note_Text";
            this.Note_Text.Size = new System.Drawing.Size(356, 212);
            this.Note_Text.TabIndex = 2;
            // 
            // UI_Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Time_Pick);
            this.Controls.Add(this.Material_DropDown);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.PlantName_DropDown);
            this.Controls.Add(this.Create_Button);
            this.Controls.Add(this.PlantName_Title);
            this.Controls.Add(this.List_Time_DataGrid);
            this.Controls.Add(this.Note_Title);
            this.Controls.Add(this.Note_Text);
            this.Controls.Add(this.Time_Title);
            this.Controls.Add(this.Material_Title);
            this.Name = "UI_Calendar";
            this.Size = new System.Drawing.Size(1254, 580);
            this.Load += new System.EventHandler(this.UI_Calendar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.List_Time_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlantName_DropDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Material_DropDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time_Pick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Material_Title;
        private System.Windows.Forms.Label Time_Title;
        private System.Windows.Forms.Label Note_Title;
        private Bunifu.Framework.UI.BunifuCustomDataGrid List_Time_DataGrid;
        private System.Windows.Forms.Label PlantName_Title;
        private Bunifu.Framework.UI.BunifuElipse List_Time_Elipse;
        private System.Windows.Forms.Button Create_Button;
        private Bunifu.Framework.UI.BunifuElipse Create_Button_Elipse;
        private Telerik.WinControls.UI.RadCheckedDropDownList PlantName_DropDown;
        private Telerik.WinControls.UI.RadDropDownListRootElement object_6a402753_efe0_44cf_a82f_63d9c8b418a9;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Button Update_Button;
        private Bunifu.Framework.UI.BunifuElipse Update_Button_Elipse;
        private Bunifu.Framework.UI.BunifuElipse Clear_Calendar_Elipse;
        private Telerik.WinControls.UI.RadCheckedDropDownList Material_DropDown;
        private Telerik.WinControls.UI.RadTimePicker Time_Pick;
        private Telerik.WinControls.UI.RadDropDownListRootElement object_58c7e8de_d9c3_4e5f_8d4b_c920b045c9fb;
        private Telerik.WinControls.RootRadElement object_e72eab59_cf89_4488_90ad_be547ab79041;
        private Bunifu.Framework.BunifuCustomTextbox Note_Text;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewComboBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}
