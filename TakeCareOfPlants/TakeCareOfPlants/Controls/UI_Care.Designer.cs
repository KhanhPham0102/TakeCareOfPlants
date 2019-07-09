namespace TakeCareOfPlants
{
    partial class UI_Care
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_Care));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.List_Calendar_DataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Create_Button_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Create_Button = new System.Windows.Forms.Button();
            this.Get_Button_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Get_All_Button = new System.Windows.Forms.Button();
            this.List_Calendar_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Calendar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.List_Calendar_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // List_Calendar_DataGrid
            // 
            this.List_Calendar_DataGrid.AllowUserToAddRows = false;
            this.List_Calendar_DataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.List_Calendar_DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.List_Calendar_DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.List_Calendar_DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.List_Calendar_DataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.List_Calendar_DataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.List_Calendar_DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.List_Calendar_DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.List_Calendar_DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.List_Calendar_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.List_Calendar_DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Date_Calendar,
            this.Time,
            this.Material,
            this.Unit,
            this.Amount,
            this.Note});
            this.List_Calendar_DataGrid.DoubleBuffered = true;
            this.List_Calendar_DataGrid.EnableHeadersVisualStyles = false;
            this.List_Calendar_DataGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.List_Calendar_DataGrid.HeaderBgColor = System.Drawing.Color.DeepSkyBlue;
            this.List_Calendar_DataGrid.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.List_Calendar_DataGrid.Location = new System.Drawing.Point(282, 19);
            this.List_Calendar_DataGrid.MultiSelect = false;
            this.List_Calendar_DataGrid.Name = "List_Calendar_DataGrid";
            this.List_Calendar_DataGrid.ReadOnly = true;
            this.List_Calendar_DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.List_Calendar_DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.List_Calendar_DataGrid.RowHeadersVisible = false;
            this.List_Calendar_DataGrid.RowHeadersWidth = 51;
            this.List_Calendar_DataGrid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.List_Calendar_DataGrid.RowTemplate.Height = 24;
            this.List_Calendar_DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.List_Calendar_DataGrid.Size = new System.Drawing.Size(953, 537);
            this.List_Calendar_DataGrid.TabIndex = 47;
            this.List_Calendar_DataGrid.TabStop = false;
            this.List_Calendar_DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.List_Calendar_DataGrid_CellClick);
            this.List_Calendar_DataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.List_Calendar_DataGrid_CellDoubleClick);
            this.List_Calendar_DataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.List_Calendar_DataGrid_CellFormatting);
            this.List_Calendar_DataGrid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.List_Calendar_DataGrid_CellPainting);
            // 
            // Create_Button_Elipse
            // 
            this.Create_Button_Elipse.ElipseRadius = 20;
            this.Create_Button_Elipse.TargetControl = this.Create_Button;
            // 
            // Create_Button
            // 
            this.Create_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Create_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.Create_Button.FlatAppearance.BorderSize = 0;
            this.Create_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Create_Button.ForeColor = System.Drawing.Color.White;
            this.Create_Button.Location = new System.Drawing.Point(55, 55);
            this.Create_Button.Name = "Create_Button";
            this.Create_Button.Size = new System.Drawing.Size(167, 45);
            this.Create_Button.TabIndex = 48;
            this.Create_Button.Text = "New Calendar";
            this.Create_Button.UseVisualStyleBackColor = false;
            this.Create_Button.Click += new System.EventHandler(this.Create_Button_Click);
            // 
            // Get_Button_Elipse
            // 
            this.Get_Button_Elipse.ElipseRadius = 20;
            this.Get_Button_Elipse.TargetControl = this.Get_All_Button;
            // 
            // Get_All_Button
            // 
            this.Get_All_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Get_All_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.Get_All_Button.FlatAppearance.BorderSize = 0;
            this.Get_All_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Get_All_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Get_All_Button.ForeColor = System.Drawing.Color.White;
            this.Get_All_Button.Location = new System.Drawing.Point(55, 222);
            this.Get_All_Button.Name = "Get_All_Button";
            this.Get_All_Button.Size = new System.Drawing.Size(167, 45);
            this.Get_All_Button.TabIndex = 49;
            this.Get_All_Button.TabStop = false;
            this.Get_All_Button.Text = "All Calendar";
            this.Get_All_Button.UseVisualStyleBackColor = false;
            this.Get_All_Button.Click += new System.EventHandler(this.Get_All_Button_Click);
            // 
            // List_Calendar_Elipse
            // 
            this.List_Calendar_Elipse.ElipseRadius = 10;
            this.List_Calendar_Elipse.TargetControl = this.List_Calendar_DataGrid;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 309);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle3;
            this.STT.FillWeight = 35.533F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.STT.Width = 48;
            // 
            // Date_Calendar
            // 
            this.Date_Calendar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.Date_Calendar.DefaultCellStyle = dataGridViewCellStyle4;
            this.Date_Calendar.FillWeight = 110.7445F;
            this.Date_Calendar.HeaderText = "Ngày Lập Lịch";
            this.Date_Calendar.MinimumWidth = 6;
            this.Date_Calendar.Name = "Date_Calendar";
            this.Date_Calendar.ReadOnly = true;
            this.Date_Calendar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Time.FillWeight = 110.7445F;
            this.Time.HeaderText = "Thời Gian";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Material
            // 
            this.Material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Material.FillWeight = 110.7445F;
            this.Material.HeaderText = "Vật Tư";
            this.Material.MinimumWidth = 6;
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            this.Material.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Unit
            // 
            this.Unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Format = "G";
            dataGridViewCellStyle5.NullValue = null;
            this.Unit.DefaultCellStyle = dataGridViewCellStyle5;
            this.Unit.FillWeight = 110.7445F;
            this.Unit.HeaderText = "Đơn Vị";
            this.Unit.MinimumWidth = 6;
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle6;
            this.Amount.FillWeight = 110.7445F;
            this.Amount.HeaderText = "Số Lượng";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Note
            // 
            this.Note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Format = "C0";
            dataGridViewCellStyle7.NullValue = null;
            this.Note.DefaultCellStyle = dataGridViewCellStyle7;
            this.Note.FillWeight = 110.7445F;
            this.Note.HeaderText = "Ghi Chú";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UI_Care
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Create_Button);
            this.Controls.Add(this.Get_All_Button);
            this.Controls.Add(this.List_Calendar_DataGrid);
            this.Name = "UI_Care";
            this.Size = new System.Drawing.Size(1254, 580);
            this.Load += new System.EventHandler(this.UI_Care_Load);
            ((System.ComponentModel.ISupportInitialize)(this.List_Calendar_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid List_Calendar_DataGrid;
        private Bunifu.Framework.UI.BunifuElipse Create_Button_Elipse;
        private Bunifu.Framework.UI.BunifuElipse Get_Button_Elipse;
        private Bunifu.Framework.UI.BunifuElipse List_Calendar_Elipse;
        private System.Windows.Forms.Button Create_Button;
        private System.Windows.Forms.Button Get_All_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Calendar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}
