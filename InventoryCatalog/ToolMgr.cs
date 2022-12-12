using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MetroFramework;

namespace InventoryCatalog
{
    public partial class ToolMgr : MetroFramework.Forms.MetroForm
    {
        public int id;
        public ToolMgr()
        {
            InitializeComponent();
            SizeModeCB.Enabled = false;
            display();
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            ImpTb.Enabled = false;
            metricTb.Enabled = false;
            qtyTb.Enabled = false;
        }

        private void ToolMgr_Load(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            //cancelbtn.Enabled = false;
            //deletebtn.Enabled = false;
            //SubUptBtn.Text = "Submit";
            //display();
            //ToolTb.Text = "";
            //ImpTb.Text = "";
            //metricTb.Text = "";
            //qtyTb.Text = "";
            //catTb.Text = "";
            //progTb.Text = "";
            //id = 0;
            cancel();
        }

        public void display()
        {
            StudentView.DataSource = DataBuddy.displayTool();

        }
        //submit btn
        private void SetUptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SizeModeCB.Checked)
                {
                    DataBuddy.AddSize(id, ImpTb.Text, metricTb.Text, Int16.Parse(qtyTb.Text));
                    ImpTb.Text = "";
                    metricTb.Text = "";
                    qtyTb.Text = "";
                    getSizes();
                }
                else
                {
                    //float imp = float.Parse(ImpTb.Text);
                    //float met = float.Parse(metricTb.Text);
                    //int qty = Int16.Parse(qtyTb.Text);
                    int cat = Int16.Parse(catTb.Text);
                    int prog = Int16.Parse(progTb.Text);
                    if (DataBuddy.submitBtn(id, ToolTb.Text, cat, prog))
                    {
                        MessageBox.Show("Data inserted succesfully");
                        ToolTb.Text = "";
                        ImpTb.Text = "";
                        metricTb.Text = "";
                        qtyTb.Text = "";
                        catTb.Text = "";
                        progTb.Text = "";
                        display();
                        cancelbtn.Enabled = false;
                        deletebtn.Enabled = false;
                        SubUptBtn.Text = "Submit";
                    }
                    else
                    {
                        MessageBox.Show("Data Updated successfully");
                        ToolTb.Text = "";
                        ImpTb.Text = "";
                        metricTb.Text = "";
                        qtyTb.Text = "";
                        catTb.Text = "";
                        progTb.Text = "";
                        display();
                        cancelbtn.Enabled = false;
                        deletebtn.Enabled = false;
                        SubUptBtn.Text = "Submit";
                    }
                }
            }
            catch (Exception n)
            {
                MessageBox.Show(n.ToString());
            }
        
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            Confirm confirmResult = new Confirm();
            confirmResult.ShowDialog();
            if (confirmResult.answer)
            {
                if (id != 0)
                {
                    DataBuddy.deleteTool(id);
                    ToolTb.Text = "";
                    ImpTb.Text = "";
                    metricTb.Text = "";
                    qtyTb.Text = "";
                    catTb.Text = "";
                    progTb.Text = "";
                    display();
                    MessageBox.Show("Data Delete successfully");
                }
                else
                {
                    display();
                    cancel();
                }
            }
        }

        private void ExtBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cancelbtn.Enabled = true;
            deletebtn.Enabled = true;
            SubUptBtn.Text = "Update";
            SizeModeCB.Enabled = true;
            int myindex = e.RowIndex;
            DataGridViewRow row = StudentView.Rows[myindex];
            ToolTb.Text = row.Cells[1].Value.ToString();
            //ImpTb.Text = row.Cells[2].Value.ToString();
            //metricTb.Text = row.Cells[3].Value.ToString();
            //qtyTb.Text = row.Cells[4].Value.ToString();
            catTb.Text = row.Cells[2].Value.ToString();
            progTb.Text = row.Cells[3].Value.ToString();
            id = (int)row.Cells[0].Value;
            getSizes();
        }

        private void cancel()
        {
            cancelbtn.Enabled = false;
            deletebtn.Enabled = false;
            SubUptBtn.Text = "Submit";
            display();
            ToolTb.Text = "";
            ImpTb.Text = "";
            metricTb.Text = "";
            qtyTb.Text = "";
            catTb.Text = "";
            progTb.Text = "";
            id = 0;
            ToolTb.ReadOnly = false;
            label5.Visible = true;
            label6.Visible = true;
            catTb.Enabled = true;
            progTb.Enabled = true;
            SizeModeCB.Checked = false;
            SizeModeCB.Enabled = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            ImpTb.Enabled = false;
            metricTb.Enabled = false;
            qtyTb.Enabled = false;
            SizesTbl.DataSource = null;
        }


        private void SizeModeCB_CheckedChanged(object sender, EventArgs e)
        {
            if(SizeModeCB.Checked)
            {
                SubUptBtn.Text = "Insert";
                ToolTb.ReadOnly = true;
                label5.Visible = false;
                label6.Visible = false;
                catTb.Enabled = false;
                progTb.Enabled = false;
                deletebtn.Enabled = false;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                ImpTb.Enabled = true;
                metricTb.Enabled = true;
                qtyTb.Enabled = true;
            }
            else if (!SizeModeCB.Checked)
            {
                SubUptBtn.Text = "Update";
                ToolTb.ReadOnly = false;
                label5.Visible = true;
                label6.Visible = true;
                catTb.Enabled = true;
                progTb.Enabled = true;
                deletebtn.Enabled = true;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                ImpTb.Enabled = false;
                metricTb.Enabled = false;
                qtyTb.Enabled = false;
            }
        }

        private void getSizes()
        {
            SizesTbl.DataSource = DataBuddy.GetSizesDT(id);
        }

        private void SizesTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int myindex = e.RowIndex;
            DataGridViewRow row = SizesTbl.Rows[myindex];
            ImpTb.Text = row.Cells[0].Value.ToString();
            metricTb.Text = row.Cells[1].Value.ToString();
            qtyTb.Text = row.Cells[2].Value.ToString();
        }
    }
}
