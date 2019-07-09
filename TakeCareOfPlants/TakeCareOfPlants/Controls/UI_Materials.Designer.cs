namespace TakeCareOfPlants
{
    partial class UI_Materials
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Coupon_DataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Create_Button = new System.Windows.Forms.Button();
            this.Create_Button_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Clear_Button_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Coupon_DataGridView_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchase_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time_Purchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Coupon_DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Coupon_DataGrid
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Coupon_DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.Coupon_DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Coupon_DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Coupon_DataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Coupon_DataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Coupon_DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Coupon_DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Coupon_DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Coupon_DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Coupon_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Coupon_DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Material,
            this.Unit,
            this.Purchase_Address,
            this.Time_Purchase,
            this.Amount,
            this.Money});
            this.Coupon_DataGrid.DoubleBuffered = true;
            this.Coupon_DataGrid.EnableHeadersVisualStyles = false;
            this.Coupon_DataGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Coupon_DataGrid.HeaderBgColor = System.Drawing.Color.DeepSkyBlue;
            this.Coupon_DataGrid.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.Coupon_DataGrid.Location = new System.Drawing.Point(19, 19);
            this.Coupon_DataGrid.Name = "Coupon_DataGrid";
            this.Coupon_DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Coupon_DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.Coupon_DataGrid.RowHeadersWidth = 51;
            this.Coupon_DataGrid.RowTemplate.Height = 24;
            this.Coupon_DataGrid.Size = new System.Drawing.Size(1216, 479);
            this.Coupon_DataGrid.TabIndex = 43;
            this.Coupon_DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Coupon_DataGrid_CellClick);
            this.Coupon_DataGrid.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.Coupon_DataGrid_ColumnWidthChanged);
            this.Coupon_DataGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Coupon_DataGrid_EditingControlShowing);
            this.Coupon_DataGrid.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Coupon_DataGrid_Scroll);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.Clear_Button.FlatAppearance.BorderSize = 0;
            this.Clear_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Clear_Button.ForeColor = System.Drawing.Color.White;
            this.Clear_Button.Location = new System.Drawing.Point(730, 516);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(173, 45);
            this.Clear_Button.TabIndex = 46;
            this.Clear_Button.TabStop = false;
            this.Clear_Button.Text = "Clear Data";
            this.Clear_Button.UseVisualStyleBackColor = false;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
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
            this.Create_Button.Location = new System.Drawing.Point(282, 516);
            this.Create_Button.Name = "Create_Button";
            this.Create_Button.Size = new System.Drawing.Size(167, 45);
            this.Create_Button.TabIndex = 44;
            this.Create_Button.Text = "New Coupon";
            this.Create_Button.UseVisualStyleBackColor = false;
            this.Create_Button.Click += new System.EventHandler(this.Create_Button_Click);
            // 
            // Create_Button_Elipse
            // 
            this.Create_Button_Elipse.ElipseRadius = 20;
            this.Create_Button_Elipse.TargetControl = this.Create_Button;
            // 
            // Clear_Button_Elipse
            // 
            this.Clear_Button_Elipse.ElipseRadius = 20;
            this.Clear_Button_Elipse.TargetControl = this.Clear_Button;
            // 
            // Coupon_DataGridView_Elipse
            // 
            this.Coupon_DataGridView_Elipse.ElipseRadius = 10;
            this.Coupon_DataGridView_Elipse.TargetControl = this.Coupon_DataGrid;
            // 
            // Material
            // 
            this.Material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Material.HeaderText = "Vật Tư";
            this.Material.MinimumWidth = 6;
            this.Material.Name = "Material";
            this.Material.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Unit
            // 
            this.Unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Unit.HeaderText = "Đơn Vị";
            this.Unit.MinimumWidth = 6;
            this.Unit.Name = "Unit";
            this.Unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Purchase_Address
            // 
            this.Purchase_Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Purchase_Address.HeaderText = "Địa Chỉ Mua";
            this.Purchase_Address.MinimumWidth = 6;
            this.Purchase_Address.Name = "Purchase_Address";
            this.Purchase_Address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Time_Purchase
            // 
            this.Time_Purchase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Format = "G";
            dataGridViewCellStyle9.NullValue = null;
            this.Time_Purchase.DefaultCellStyle = dataGridViewCellStyle9;
            this.Time_Purchase.HeaderText = "Thời Gian Mua";
            this.Time_Purchase.MinimumWidth = 6;
            this.Time_Purchase.Name = "Time_Purchase";
            this.Time_Purchase.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = null;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle10;
            this.Amount.HeaderText = "Số Lượng";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Money
            // 
            this.Money.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Format = "C0";
            dataGridViewCellStyle11.NullValue = null;
            this.Money.DefaultCellStyle = dataGridViewCellStyle11;
            this.Money.HeaderText = "Số Tiền";
            this.Money.MinimumWidth = 6;
            this.Money.Name = "Money";
            this.Money.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UI_Materials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Create_Button);
            this.Controls.Add(this.Coupon_DataGrid);
            this.Name = "UI_Materials";
            this.Size = new System.Drawing.Size(1254, 580);
            this.Load += new System.EventHandler(this.UI_Materials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Coupon_DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid Coupon_DataGrid;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Button Create_Button;
        private Bunifu.Framework.UI.BunifuElipse Create_Button_Elipse;
        private Bunifu.Framework.UI.BunifuElipse Clear_Button_Elipse;
        private Bunifu.Framework.UI.BunifuElipse Coupon_DataGridView_Elipse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchase_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time_Purchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money;
    }
}
