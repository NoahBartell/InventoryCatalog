
namespace InventoryCatalog
{
    partial class Confirm
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
            this.NoBtn = new MetroFramework.Controls.MetroButton();
            this.YesBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // NoBtn
            // 
            this.NoBtn.BackColor = System.Drawing.Color.Red;
            this.NoBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.NoBtn.Location = new System.Drawing.Point(42, 86);
            this.NoBtn.Name = "NoBtn";
            this.NoBtn.Size = new System.Drawing.Size(93, 47);
            this.NoBtn.TabIndex = 0;
            this.NoBtn.Text = "No";
            this.NoBtn.UseSelectable = true;
            this.NoBtn.Click += new System.EventHandler(this.NoBtn_Click);
            // 
            // YesBtn
            // 
            this.YesBtn.BackColor = System.Drawing.Color.Lime;
            this.YesBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.YesBtn.Location = new System.Drawing.Point(170, 86);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(93, 47);
            this.YesBtn.TabIndex = 1;
            this.YesBtn.Text = "Yes";
            this.YesBtn.UseSelectable = true;
            this.YesBtn.Click += new System.EventHandler(this.YesBtn_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(89, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(129, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Are you Sure?";
            // 
            // Confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 173);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.YesBtn);
            this.Controls.Add(this.NoBtn);
            this.DisplayHeader = false;
            this.Name = "Confirm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Confirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton NoBtn;
        private MetroFramework.Controls.MetroButton YesBtn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}