
namespace InventoryCatalog
{
    partial class ToolMgr
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
            this.cancelbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.StudentView = new System.Windows.Forms.DataGridView();
            this.toolTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolCribDataSet1 = new InventoryCatalog.ToolCribDataSet1();
            this.qtyTb = new System.Windows.Forms.TextBox();
            this.metricTb = new System.Windows.Forms.TextBox();
            this.ImpTb = new System.Windows.Forms.TextBox();
            this.ToolTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SubUptBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.toolTblTableAdapter = new InventoryCatalog.ToolCribDataSet1TableAdapters.toolTblTableAdapter();
            this.catTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.progTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolCribDataSet5 = new InventoryCatalog.ToolCribDataSet5();
            this.toolTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolTblTableAdapter1 = new InventoryCatalog.ToolCribDataSet5TableAdapters.toolTblTableAdapter();
            this.SizeModeCB = new System.Windows.Forms.CheckBox();
            this.SizesTbl = new System.Windows.Forms.DataGridView();
            this.toolCribDataSet6 = new InventoryCatalog.ToolCribDataSet6();
            this.sizeTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sizeTblTableAdapter = new InventoryCatalog.ToolCribDataSet6TableAdapters.sizeTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StudentView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolCribDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolCribDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizesTbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolCribDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelbtn
            // 
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.Location = new System.Drawing.Point(854, 149);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(109, 35);
            this.cancelbtn.TabIndex = 25;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(854, 234);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(109, 35);
            this.deletebtn.TabIndex = 24;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // StudentView
            // 
            this.StudentView.AllowUserToAddRows = false;
            this.StudentView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StudentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentView.DefaultCellStyle = dataGridViewCellStyle2;
            this.StudentView.Location = new System.Drawing.Point(50, 435);
            this.StudentView.Name = "StudentView";
            this.StudentView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.StudentView.RowHeadersWidth = 51;
            this.StudentView.RowTemplate.Height = 24;
            this.StudentView.Size = new System.Drawing.Size(470, 354);
            this.StudentView.TabIndex = 23;
            this.StudentView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentView_CellContentClick);
            this.StudentView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentView_CellContentClick);
            // 
            // toolTblBindingSource
            // 
            this.toolTblBindingSource.DataMember = "toolTbl";
            this.toolTblBindingSource.DataSource = this.toolCribDataSet1;
            // 
            // toolCribDataSet1
            // 
            this.toolCribDataSet1.DataSetName = "ToolCribDataSet1";
            this.toolCribDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qtyTb
            // 
            this.qtyTb.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyTb.Location = new System.Drawing.Point(535, 346);
            this.qtyTb.Name = "qtyTb";
            this.qtyTb.Size = new System.Drawing.Size(256, 33);
            this.qtyTb.TabIndex = 22;
            // 
            // metricTb
            // 
            this.metricTb.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metricTb.Location = new System.Drawing.Point(535, 293);
            this.metricTb.Name = "metricTb";
            this.metricTb.Size = new System.Drawing.Size(256, 33);
            this.metricTb.TabIndex = 21;
            // 
            // ImpTb
            // 
            this.ImpTb.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImpTb.Location = new System.Drawing.Point(535, 236);
            this.ImpTb.Name = "ImpTb";
            this.ImpTb.Size = new System.Drawing.Size(256, 33);
            this.ImpTb.TabIndex = 20;
            // 
            // ToolTb
            // 
            this.ToolTb.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolTb.Location = new System.Drawing.Point(535, 63);
            this.ToolTb.Name = "ToolTb";
            this.ToolTb.Size = new System.Drawing.Size(256, 33);
            this.ToolTb.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(335, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(335, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Metric";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Imperial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tool Name";
            // 
            // SubUptBtn
            // 
            this.SubUptBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubUptBtn.Location = new System.Drawing.Point(854, 79);
            this.SubUptBtn.Name = "SubUptBtn";
            this.SubUptBtn.Size = new System.Drawing.Size(109, 35);
            this.SubUptBtn.TabIndex = 14;
            this.SubUptBtn.Text = "Submit";
            this.SubUptBtn.UseVisualStyleBackColor = true;
            this.SubUptBtn.Click += new System.EventHandler(this.SetUptBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(854, 316);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(109, 35);
            this.ExitBtn.TabIndex = 13;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExtBtn_Click);
            // 
            // toolTblTableAdapter
            // 
            this.toolTblTableAdapter.ClearBeforeFill = true;
            // 
            // catTb
            // 
            this.catTb.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catTb.Location = new System.Drawing.Point(535, 116);
            this.catTb.Name = "catTb";
            this.catTb.Size = new System.Drawing.Size(256, 33);
            this.catTb.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(335, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Category Id";
            // 
            // progTb
            // 
            this.progTb.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progTb.Location = new System.Drawing.Point(535, 174);
            this.progTb.Name = "progTb";
            this.progTb.Size = new System.Drawing.Size(256, 33);
            this.progTb.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(335, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Program Id";
            // 
            // toolCribDataSet5
            // 
            this.toolCribDataSet5.DataSetName = "ToolCribDataSet5";
            this.toolCribDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolTblBindingSource1
            // 
            this.toolTblBindingSource1.DataMember = "toolTbl";
            this.toolTblBindingSource1.DataSource = this.toolCribDataSet5;
            // 
            // toolTblTableAdapter1
            // 
            this.toolTblTableAdapter1.ClearBeforeFill = true;
            // 
            // SizeModeCB
            // 
            this.SizeModeCB.AutoSize = true;
            this.SizeModeCB.Location = new System.Drawing.Point(196, 245);
            this.SizeModeCB.Name = "SizeModeCB";
            this.SizeModeCB.Size = new System.Drawing.Size(93, 21);
            this.SizeModeCB.TabIndex = 30;
            this.SizeModeCB.Text = "Add Sizes";
            this.SizeModeCB.UseVisualStyleBackColor = true;
            this.SizeModeCB.CheckedChanged += new System.EventHandler(this.SizeModeCB_CheckedChanged);
            // 
            // SizesTbl
            // 
            this.SizesTbl.AllowUserToAddRows = false;
            this.SizesTbl.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SizesTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.SizesTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SizesTbl.DefaultCellStyle = dataGridViewCellStyle5;
            this.SizesTbl.Location = new System.Drawing.Point(535, 435);
            this.SizesTbl.Name = "SizesTbl";
            this.SizesTbl.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SizesTbl.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.SizesTbl.RowHeadersWidth = 51;
            this.SizesTbl.RowTemplate.Height = 24;
            this.SizesTbl.Size = new System.Drawing.Size(470, 354);
            this.SizesTbl.TabIndex = 31;
            this.SizesTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SizesTbl_CellContentClick);
            this.SizesTbl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SizesTbl_CellContentClick);
            // 
            // toolCribDataSet6
            // 
            this.toolCribDataSet6.DataSetName = "ToolCribDataSet6";
            this.toolCribDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sizeTblBindingSource
            // 
            this.sizeTblBindingSource.DataMember = "sizeTbl";
            this.sizeTblBindingSource.DataSource = this.toolCribDataSet6;
            // 
            // sizeTblTableAdapter
            // 
            this.sizeTblTableAdapter.ClearBeforeFill = true;
            // 
            // ToolMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 814);
            this.ControlBox = false;
            this.Controls.Add(this.SizesTbl);
            this.Controls.Add(this.SizeModeCB);
            this.Controls.Add(this.progTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.catTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.StudentView);
            this.Controls.Add(this.qtyTb);
            this.Controls.Add(this.metricTb);
            this.Controls.Add(this.ImpTb);
            this.Controls.Add(this.ToolTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubUptBtn);
            this.Controls.Add(this.ExitBtn);
            this.Name = "ToolMgr";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Tool Managment";
            this.Load += new System.EventHandler(this.ToolMgr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolCribDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolCribDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizesTbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolCribDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.DataGridView StudentView;
        private System.Windows.Forms.TextBox qtyTb;
        private System.Windows.Forms.TextBox metricTb;
        private System.Windows.Forms.TextBox ImpTb;
        private System.Windows.Forms.TextBox ToolTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubUptBtn;
        private System.Windows.Forms.Button ExitBtn;
        private ToolCribDataSet1 toolCribDataSet1;
        private System.Windows.Forms.BindingSource toolTblBindingSource;
        private ToolCribDataSet1TableAdapters.toolTblTableAdapter toolTblTableAdapter;
        private System.Windows.Forms.TextBox catTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox progTb;
        private System.Windows.Forms.Label label6;
        private ToolCribDataSet5 toolCribDataSet5;
        private System.Windows.Forms.BindingSource toolTblBindingSource1;
        private ToolCribDataSet5TableAdapters.toolTblTableAdapter toolTblTableAdapter1;
        private System.Windows.Forms.CheckBox SizeModeCB;
        private System.Windows.Forms.DataGridView SizesTbl;
        private ToolCribDataSet6 toolCribDataSet6;
        private System.Windows.Forms.BindingSource sizeTblBindingSource;
        private ToolCribDataSet6TableAdapters.sizeTblTableAdapter sizeTblTableAdapter;
    }
}