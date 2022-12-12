
namespace InventoryCatalog
{
    partial class UserMgr
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
            this.ExtBtn = new System.Windows.Forms.Button();
            this.SubUptBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fntb = new System.Windows.Forms.TextBox();
            this.lntb = new System.Windows.Forms.TextBox();
            this.emailtb = new System.Windows.Forms.TextBox();
            this.passtb = new System.Windows.Forms.TextBox();
            this.StudentView = new System.Windows.Forms.DataGridView();
            this.accountTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolCribDataSet = new InventoryCatalog.ToolCribDataSet();
            this.accountTblTableAdapter = new InventoryCatalog.ToolCribDataSetTableAdapters.accountTblTableAdapter();
            this.deletebtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.AdminCB = new System.Windows.Forms.CheckBox();
            this.toolCribDataSet3 = new InventoryCatalog.ToolCribDataSet3();
            this.accountTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accountTblTableAdapter1 = new InventoryCatalog.ToolCribDataSet3TableAdapters.accountTblTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StudentView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolCribDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolCribDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTblBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExtBtn
            // 
            this.ExtBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtBtn.Location = new System.Drawing.Point(478, 257);
            this.ExtBtn.Name = "ExtBtn";
            this.ExtBtn.Size = new System.Drawing.Size(113, 36);
            this.ExtBtn.TabIndex = 7;
            this.ExtBtn.Text = "Exit";
            this.ExtBtn.UseVisualStyleBackColor = true;
            this.ExtBtn.Click += new System.EventHandler(this.ExtBtn_Click);
            // 
            // SubUptBtn
            // 
            this.SubUptBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubUptBtn.Location = new System.Drawing.Point(478, 82);
            this.SubUptBtn.Name = "SubUptBtn";
            this.SubUptBtn.Size = new System.Drawing.Size(113, 36);
            this.SubUptBtn.TabIndex = 4;
            this.SubUptBtn.Text = "Submit";
            this.SubUptBtn.UseVisualStyleBackColor = true;
            this.SubUptBtn.Click += new System.EventHandler(this.SubUptBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // fntb
            // 
            this.fntb.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fntb.Location = new System.Drawing.Point(184, 90);
            this.fntb.Name = "fntb";
            this.fntb.Size = new System.Drawing.Size(256, 33);
            this.fntb.TabIndex = 0;
            // 
            // lntb
            // 
            this.lntb.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lntb.Location = new System.Drawing.Point(184, 144);
            this.lntb.Name = "lntb";
            this.lntb.Size = new System.Drawing.Size(256, 33);
            this.lntb.TabIndex = 1;
            // 
            // emailtb
            // 
            this.emailtb.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtb.Location = new System.Drawing.Point(184, 201);
            this.emailtb.Name = "emailtb";
            this.emailtb.Size = new System.Drawing.Size(256, 33);
            this.emailtb.TabIndex = 2;
            // 
            // passtb
            // 
            this.passtb.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtb.Location = new System.Drawing.Point(184, 257);
            this.passtb.Name = "passtb";
            this.passtb.Size = new System.Drawing.Size(256, 33);
            this.passtb.TabIndex = 3;
            // 
            // StudentView
            // 
            this.StudentView.AllowUserToAddRows = false;
            this.StudentView.AllowUserToDeleteRows = false;
            this.StudentView.AutoGenerateColumns = false;
            this.StudentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.adminDataGridViewTextBoxColumn});
            this.StudentView.DataSource = this.accountTblBindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentView.DefaultCellStyle = dataGridViewCellStyle1;
            this.StudentView.Location = new System.Drawing.Point(48, 363);
            this.StudentView.Name = "StudentView";
            this.StudentView.ReadOnly = true;
            this.StudentView.RowHeadersWidth = 51;
            this.StudentView.RowTemplate.Height = 24;
            this.StudentView.Size = new System.Drawing.Size(697, 320);
            this.StudentView.TabIndex = 10;
            this.StudentView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentView_CellClick);
            this.StudentView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentView_CellContentClick);
            // 
            // accountTblBindingSource
            // 
            this.accountTblBindingSource.DataMember = "accountTbl";
            this.accountTblBindingSource.DataSource = this.toolCribDataSet;
            // 
            // toolCribDataSet
            // 
            this.toolCribDataSet.DataSetName = "ToolCribDataSet";
            this.toolCribDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountTblTableAdapter
            // 
            this.accountTblTableAdapter.ClearBeforeFill = true;
            // 
            // deletebtn
            // 
            this.deletebtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(478, 198);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(113, 36);
            this.deletebtn.TabIndex = 6;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.Location = new System.Drawing.Point(478, 141);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(113, 36);
            this.cancelbtn.TabIndex = 5;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // AdminCB
            // 
            this.AdminCB.AutoSize = true;
            this.AdminCB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AdminCB.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminCB.Location = new System.Drawing.Point(244, 312);
            this.AdminCB.Name = "AdminCB";
            this.AdminCB.Size = new System.Drawing.Size(97, 29);
            this.AdminCB.TabIndex = 11;
            this.AdminCB.Text = "Admin";
            this.AdminCB.UseVisualStyleBackColor = true;
            // 
            // toolCribDataSet3
            // 
            this.toolCribDataSet3.DataSetName = "ToolCribDataSet3";
            this.toolCribDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountTblBindingSource1
            // 
            this.accountTblBindingSource1.DataMember = "accountTbl";
            this.accountTblBindingSource1.DataSource = this.toolCribDataSet3;
            // 
            // accountTblTableAdapter1
            // 
            this.accountTblTableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "fName";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.fNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            this.fNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "lName";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            this.lNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // adminDataGridViewTextBoxColumn
            // 
            this.adminDataGridViewTextBoxColumn.DataPropertyName = "admin";
            this.adminDataGridViewTextBoxColumn.HeaderText = "Admin";
            this.adminDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminDataGridViewTextBoxColumn.Name = "adminDataGridViewTextBoxColumn";
            this.adminDataGridViewTextBoxColumn.ReadOnly = true;
            this.adminDataGridViewTextBoxColumn.Width = 125;
            // 
            // UserMgr
            // 
            this.AcceptButton = this.SubUptBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 706);
            this.ControlBox = false;
            this.Controls.Add(this.AdminCB);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.StudentView);
            this.Controls.Add(this.passtb);
            this.Controls.Add(this.emailtb);
            this.Controls.Add(this.lntb);
            this.Controls.Add(this.fntb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubUptBtn);
            this.Controls.Add(this.ExtBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserMgr";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "User Managament";
            this.Load += new System.EventHandler(this.UserMgr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolCribDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolCribDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTblBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExtBtn;
        private System.Windows.Forms.Button SubUptBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fntb;
        private System.Windows.Forms.TextBox lntb;
        private System.Windows.Forms.TextBox emailtb;
        private System.Windows.Forms.TextBox passtb;
        private System.Windows.Forms.DataGridView StudentView;
        private ToolCribDataSet toolCribDataSet;
        private System.Windows.Forms.BindingSource accountTblBindingSource;
        private ToolCribDataSetTableAdapters.accountTblTableAdapter accountTblTableAdapter;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.CheckBox AdminCB;
        private ToolCribDataSet3 toolCribDataSet3;
        private System.Windows.Forms.BindingSource accountTblBindingSource1;
        private ToolCribDataSet3TableAdapters.accountTblTableAdapter accountTblTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminDataGridViewTextBoxColumn;
    }
}