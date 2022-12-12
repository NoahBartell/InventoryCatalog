
namespace InventoryCatalog
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UserMgmBtn = new System.Windows.Forms.Button();
            this.ToolMgr = new System.Windows.Forms.Button();
            this.toolCribDataSet = new InventoryCatalog.ToolCribDataSet();
            this.toolCribDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tool_Grid = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolCribDataSet4 = new InventoryCatalog.ToolCribDataSet4();
            this.toolTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolCribDataSet2 = new InventoryCatalog.ToolCribDataSet2();
            this.toolTblTableAdapter = new InventoryCatalog.ToolCribDataSet2TableAdapters.toolTblTableAdapter();
            this.UserIdShower = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.CheckedOut = new MetroFramework.Controls.MetroGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.SizesBox = new System.Windows.Forms.ComboBox();
            this.toolTblTableAdapter1 = new InventoryCatalog.ToolCribDataSet4TableAdapters.toolTblTableAdapter();
            this.Submit_btn = new MetroFramework.Controls.MetroButton();
            this.UncheckSubBtn = new MetroFramework.Controls.MetroButton();
            this.HistoryBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.toolCribDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolCribDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tool_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolCribDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolCribDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckedOut)).BeginInit();
            this.SuspendLayout();
            // 
            // UserMgmBtn
            // 
            this.UserMgmBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserMgmBtn.Location = new System.Drawing.Point(935, 47);
            this.UserMgmBtn.Name = "UserMgmBtn";
            this.UserMgmBtn.Size = new System.Drawing.Size(191, 52);
            this.UserMgmBtn.TabIndex = 0;
            this.UserMgmBtn.Text = "User Managment";
            this.UserMgmBtn.UseVisualStyleBackColor = true;
            this.UserMgmBtn.Click += new System.EventHandler(this.UserMgmBtn_Click);
            // 
            // ToolMgr
            // 
            this.ToolMgr.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolMgr.Location = new System.Drawing.Point(706, 47);
            this.ToolMgr.Name = "ToolMgr";
            this.ToolMgr.Size = new System.Drawing.Size(202, 52);
            this.ToolMgr.TabIndex = 1;
            this.ToolMgr.Text = "Tool Management";
            this.ToolMgr.UseVisualStyleBackColor = true;
            this.ToolMgr.Click += new System.EventHandler(this.ToolMgr_Click);
            // 
            // toolCribDataSet
            // 
            this.toolCribDataSet.DataSetName = "ToolCribDataSet";
            this.toolCribDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolCribDataSetBindingSource
            // 
            this.toolCribDataSetBindingSource.DataSource = this.toolCribDataSet;
            this.toolCribDataSetBindingSource.Position = 0;
            // 
            // Tool_Grid
            // 
            this.Tool_Grid.AllowUserToAddRows = false;
            this.Tool_Grid.AllowUserToDeleteRows = false;
            this.Tool_Grid.AllowUserToResizeRows = false;
            this.Tool_Grid.AutoGenerateColumns = false;
            this.Tool_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Tool_Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tool_Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Tool_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tool_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Tool_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tool_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn});
            this.Tool_Grid.DataSource = this.toolTblBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Tool_Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Tool_Grid.EnableHeadersVisualStyles = false;
            this.Tool_Grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tool_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Tool_Grid.Location = new System.Drawing.Point(39, 187);
            this.Tool_Grid.Name = "Tool_Grid";
            this.Tool_Grid.ReadOnly = true;
            this.Tool_Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tool_Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Tool_Grid.RowHeadersWidth = 51;
            this.Tool_Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Tool_Grid.RowTemplate.Height = 24;
            this.Tool_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tool_Grid.Size = new System.Drawing.Size(676, 252);
            this.Tool_Grid.Style = MetroFramework.MetroColorStyle.Red;
            this.Tool_Grid.TabIndex = 2;
            this.Tool_Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tool_Grid_CellContentClick);
            this.Tool_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tool_Grid_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id #";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Tool Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.qtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtyDataGridViewTextBoxColumn.Width = 125;
            // 
            // toolTblBindingSource1
            // 
            this.toolTblBindingSource1.DataMember = "toolTbl";
            this.toolTblBindingSource1.DataSource = this.toolCribDataSet4;
            // 
            // toolCribDataSet4
            // 
            this.toolCribDataSet4.DataSetName = "ToolCribDataSet4";
            this.toolCribDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolTblBindingSource
            // 
            this.toolTblBindingSource.DataMember = "toolTbl";
            this.toolTblBindingSource.DataSource = this.toolCribDataSet2;
            // 
            // toolCribDataSet2
            // 
            this.toolCribDataSet2.DataSetName = "ToolCribDataSet2";
            this.toolCribDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolTblTableAdapter
            // 
            this.toolTblTableAdapter.ClearBeforeFill = true;
            // 
            // UserIdShower
            // 
            this.UserIdShower.AutoSize = true;
            this.UserIdShower.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIdShower.Location = new System.Drawing.Point(34, 74);
            this.UserIdShower.Name = "UserIdShower";
            this.UserIdShower.Size = new System.Drawing.Size(69, 25);
            this.UserIdShower.TabIndex = 3;
            this.UserIdShower.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Check Out Table";
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(240, 47);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(202, 52);
            this.Logout.TabIndex = 5;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // CheckedOut
            // 
            this.CheckedOut.AllowUserToAddRows = false;
            this.CheckedOut.AllowUserToDeleteRows = false;
            this.CheckedOut.AllowUserToResizeRows = false;
            this.CheckedOut.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CheckedOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CheckedOut.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CheckedOut.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckedOut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CheckedOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CheckedOut.DefaultCellStyle = dataGridViewCellStyle5;
            this.CheckedOut.EnableHeadersVisualStyles = false;
            this.CheckedOut.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CheckedOut.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CheckedOut.Location = new System.Drawing.Point(39, 524);
            this.CheckedOut.Name = "CheckedOut";
            this.CheckedOut.ReadOnly = true;
            this.CheckedOut.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckedOut.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.CheckedOut.RowHeadersWidth = 51;
            this.CheckedOut.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CheckedOut.RowTemplate.Height = 24;
            this.CheckedOut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CheckedOut.Size = new System.Drawing.Size(676, 252);
            this.CheckedOut.Style = MetroFramework.MetroColorStyle.Red;
            this.CheckedOut.TabIndex = 6;
            this.CheckedOut.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CheckedOut_CellContentClick);
            this.CheckedOut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CheckedOut_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Currently Checked Out";
            // 
            // SizesBox
            // 
            this.SizesBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizesBox.FormattingEnabled = true;
            this.SizesBox.Location = new System.Drawing.Point(806, 319);
            this.SizesBox.Name = "SizesBox";
            this.SizesBox.Size = new System.Drawing.Size(121, 33);
            this.SizesBox.TabIndex = 8;
            // 
            // toolTblTableAdapter1
            // 
            this.toolTblTableAdapter1.ClearBeforeFill = true;
            // 
            // Submit_btn
            // 
            this.Submit_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Submit_btn.Location = new System.Drawing.Point(976, 319);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(99, 32);
            this.Submit_btn.TabIndex = 9;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseSelectable = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // UncheckSubBtn
            // 
            this.UncheckSubBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.UncheckSubBtn.Location = new System.Drawing.Point(976, 595);
            this.UncheckSubBtn.Name = "UncheckSubBtn";
            this.UncheckSubBtn.Size = new System.Drawing.Size(99, 32);
            this.UncheckSubBtn.TabIndex = 10;
            this.UncheckSubBtn.Text = "Submit";
            this.UncheckSubBtn.UseSelectable = true;
            this.UncheckSubBtn.Click += new System.EventHandler(this.UncheckSubBtn_Click);
            // 
            // HistoryBtn
            // 
            this.HistoryBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryBtn.Location = new System.Drawing.Point(476, 47);
            this.HistoryBtn.Name = "HistoryBtn";
            this.HistoryBtn.Size = new System.Drawing.Size(202, 52);
            this.HistoryBtn.TabIndex = 11;
            this.HistoryBtn.Text = "History";
            this.HistoryBtn.UseVisualStyleBackColor = true;
            this.HistoryBtn.Click += new System.EventHandler(this.HistoryBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.HistoryBtn);
            this.Controls.Add(this.UncheckSubBtn);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.SizesBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckedOut);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserIdShower);
            this.Controls.Add(this.Tool_Grid);
            this.Controls.Add(this.ToolMgr);
            this.Controls.Add(this.UserMgmBtn);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(20, 64, 20, 21);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toolCribDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolCribDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tool_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolCribDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolCribDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckedOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UserMgmBtn;
        private System.Windows.Forms.Button ToolMgr;
        private ToolCribDataSet toolCribDataSet;
        private System.Windows.Forms.BindingSource toolCribDataSetBindingSource;
        private MetroFramework.Controls.MetroGrid Tool_Grid;
        private ToolCribDataSet2 toolCribDataSet2;
        private System.Windows.Forms.BindingSource toolTblBindingSource;
        private ToolCribDataSet2TableAdapters.toolTblTableAdapter toolTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label UserIdShower;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Logout;
        private MetroFramework.Controls.MetroGrid CheckedOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SizesBox;
        private ToolCribDataSet4 toolCribDataSet4;
        private System.Windows.Forms.BindingSource toolTblBindingSource1;
        private ToolCribDataSet4TableAdapters.toolTblTableAdapter toolTblTableAdapter1;
        private MetroFramework.Controls.MetroButton Submit_btn;
        private MetroFramework.Controls.MetroButton UncheckSubBtn;
        private System.Windows.Forms.Button HistoryBtn;
    }
}