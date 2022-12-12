
namespace InventoryCatalog
{
    partial class History
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
            this.ExitBtn = new System.Windows.Forms.Button();
            this.HistoryView = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.TextBox();
            this.SearchTb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryView)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(791, 26);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(125, 49);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // HistoryView
            // 
            this.HistoryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoryView.Location = new System.Drawing.Point(23, 168);
            this.HistoryView.Name = "HistoryView";
            this.HistoryView.RowHeadersWidth = 51;
            this.HistoryView.RowTemplate.Height = 24;
            this.HistoryView.Size = new System.Drawing.Size(893, 353);
            this.HistoryView.TabIndex = 1;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(41, 124);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(220, 33);
            this.Search.TabIndex = 2;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // SearchTb
            // 
            this.SearchTb.AutoSize = true;
            this.SearchTb.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTb.Location = new System.Drawing.Point(286, 124);
            this.SearchTb.Name = "SearchTb";
            this.SearchTb.Size = new System.Drawing.Size(74, 25);
            this.SearchTb.TabIndex = 3;
            this.SearchTb.Text = "Search";
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 544);
            this.ControlBox = false;
            this.Controls.Add(this.SearchTb);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.HistoryView);
            this.Controls.Add(this.ExitBtn);
            this.Name = "History";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "History";
            ((System.ComponentModel.ISupportInitialize)(this.HistoryView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.DataGridView HistoryView;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label SearchTb;
    }
}