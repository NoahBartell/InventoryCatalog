using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryCatalog
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        private int ID { get; set; }
        private int toolId { get; set; }
        private int CheckOutID { get; set; }
        
        public Main(int id)
        {
            ID = id;
            InitializeComponent();
            UserIdShower.Text = $"Welcome {DataBuddy.GetName(id)}";
            if (DataBuddy.IsAdmin(id))
            {
                UserMgmBtn.Show();
                ToolMgr.Show();
            }
            else
            {
                UserMgmBtn.Hide();
                ToolMgr.Hide();
            }
            display();
            DisplayInUse();
            Submit_btn.Enabled = false;
            GetCheckedOut();
            //setComboBox();
        }

        private void ToolMgr_Click(object sender, EventArgs e)
        {
            ToolMgr newT = new ToolMgr();
            newT.ShowDialog();
        }

        public void display()
        {
            Tool_Grid.DataSource = DataBuddy.displayTool();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        //    // TODO: This line of code loads data into the 'toolCribDataSet4.toolTbl' table. You can move, or remove it, as needed.
        //    this.toolTblTableAdapter1.Fill(this.toolCribDataSet4.toolTbl);
        //    // TODO: This line of code loads data into the 'toolCribDataSet2.toolTbl' table. You can move, or remove it, as needed.
        //    this.toolTblTableAdapter.Fill(this.toolCribDataSet2.toolTbl);

        }

        private void Tool_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int myindex = e.RowIndex;
            DataGridViewRow row = Tool_Grid.Rows[myindex];
            toolId = (int)row.Cells[0].Value;
            setComboBox(toolId);
            Submit_btn.Enabled = true;
        }

        private void UserMgmBtn_Click(object sender, EventArgs e)
        {
            UserMgr newL = new UserMgr();
            newL.ShowDialog();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.ShowDialog();
            this.Close();
        }

        private void DisplayInUse()
        {
            CheckedOut.DataSource = DataBuddy.GetOwned(ID);
        }

        private void setComboBox(int id)
        { 
            if(DataBuddy.GetSizes(id) == null)
            {
                SizesBox.SelectedIndex = -1;
            }
            else
            {
                SizesBox.DataSource = DataBuddy.GetSizes(id);
            }
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            DataBuddy.PutInUse(ID, toolId, SizesBox.SelectedItem.ToString());
            GetCheckedOut();
            //DataBuddy.CheckOut(ID, ID, toolId, SizesBox.SelectedItem.ToString());
            Submit_btn.Enabled = false;
        }

        public void GetCheckedOut()
        {
            CheckedOut.DataSource = DataBuddy.GetOwned(ID);
        }

        private void CheckedOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int myindex = e.RowIndex;
            DataGridViewRow row = CheckedOut.Rows[myindex];
            CheckOutID = (int)row.Cells[0].Value;
            //MessageBox.Show(CheckOutID.ToString());
            UncheckSubBtn.Enabled = true;

        }

        private void UncheckSubBtn_Click(object sender, EventArgs e)
        {
            DataBuddy.TakeOutInUse(CheckOutID);
            DataBuddy.CheckIn(CheckOutID);
            DisplayInUse();
            UncheckSubBtn.Enabled = false;
        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            History newL = new History();
            newL.ShowDialog();
        }
    }
}
