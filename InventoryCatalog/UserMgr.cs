using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace InventoryCatalog
{
    public partial class UserMgr : MetroFramework.Forms.MetroForm
    {
        //public int for methods to assign selected records
        public int id;
        public UserMgr()
        {
            InitializeComponent();
            cancelbtn.Enabled = false;
            deletebtn.Enabled = false;
            SubUptBtn.Text = "Submit";
        }

        private void UserMgr_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toolCribDataSet3.accountTbl' table. You can move, or remove it, as needed.
            this.accountTblTableAdapter1.Fill(this.toolCribDataSet3.accountTbl);
            // TODO: This line of code loads data into the 'toolCribDataSet.accountTbl' table. You can move, or remove it, as needed.
            this.accountTblTableAdapter.Fill(this.toolCribDataSet.accountTbl);

        }
        //updates display
        public void display()
        {
            StudentView.DataSource = DataBuddy.displayUser();
        }

        private void StudentView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int myindex = e.RowIndex;

            DataGridViewRow row = StudentView.Rows[myindex];
            if (!string.IsNullOrEmpty(row.Cells[1].Value.ToString()))
            {
                cancelbtn.Enabled = true;
                deletebtn.Enabled = true;
                SubUptBtn.Text = "Update";
                fntb.Text = row.Cells[1].Value.ToString();
                lntb.Text = row.Cells[2].Value.ToString();
                emailtb.Text = row.Cells[4].Value.ToString();
                passtb.Text = row.Cells[3].Value.ToString();
                id = (int)row.Cells[0].Value;
            }
            else
            {
                cancel();
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
                    DataBuddy.deleteUser(id);
                    fntb.Text = "";
                    lntb.Text = "";
                    emailtb.Text = "";
                    passtb.Text = "";
                    display();
                    MessageBox.Show("Data Delete successfully");
                }
            }

            else
            {
                cancel();
            }
           
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            cancelbtn.Enabled = false;
            deletebtn.Enabled = false;
            SubUptBtn.Text = "Submit";
            display();
            fntb.Text = "";
            lntb.Text = "";
            emailtb.Text = "";
            passtb.Text = "";
            id = 0;
        }

        private void cancel()
        {
            cancelbtn.Enabled = false;
            deletebtn.Enabled = false;
            SubUptBtn.Text = "Submit";
            display();
            fntb.Text = "";
            lntb.Text = "";
            emailtb.Text = "";
            passtb.Text = "";
            id = 0;
        }

        private void StudentView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int myindex = e.RowIndex;
            
            DataGridViewRow row = StudentView.Rows[myindex];
            if (!string.IsNullOrEmpty(row.Cells[1].Value.ToString()))
            {
                cancelbtn.Enabled = true;
                deletebtn.Enabled = true;
                SubUptBtn.Text = "Update";
                fntb.Text = row.Cells[1].Value.ToString();
                lntb.Text = row.Cells[2].Value.ToString();
                emailtb.Text = row.Cells[3].Value.ToString();
                passtb.Text = row.Cells[4].Value.ToString();
                id = (int)row.Cells[0].Value;
                AdminCB.Checked = Convert.ToBoolean((int)row.Cells[5].Value);
                
                
            }
            else
            {
                cancel();
            }
        }

        private void SubUptBtn_Click(object sender, EventArgs e)
        {
            //validation
            bool hasErr = false;
            string Err = "";
            //First Name Validation
            if (fntb.Text == "")
            {
                hasErr = true;
                Err += "First Name is Empty\n";
            }
            else
            {
                var match = Regex.Match(fntb.Text, "^[a-zA-Z']*$");
                if (!match.Success)
                {
                    hasErr = true;
                    Err += "First Name contains invalid Characters\n";
                }
            }

            //Last Name Validation
            if (lntb.Text == "")
            {
                hasErr = true;
                Err += "Last Name is Empty\n";
            }
            else
            {
                var match = Regex.Match(lntb.Text, "^[a-zA-Z']*$");
                if (!match.Success)
                {
                    hasErr = true;
                    Err += "Last Name contains invalid Characters\n";
                }
            }

            //email validation
            if (emailtb.Text == "")
            {
                hasErr = true;
                Err += "Email is Empty\n";
            }
            /*else
            {
                var match = Regex.Match(fntb.Text, "/^[a-zA-Z']*$/");
                if (!match.Success)
                {
                    hasErr = true;
                    Err += "Last Name contains invalid Characters\n";
                }
            }*/

            //Password Validation
            if (passtb.Text == "")
            {
                hasErr = true;
                Err += "Password is Empty\n";
            }
            /*else
            {
                var match = Regex.Match(fntb.Text, "/^[a-zA-Z']*$/");
                if (!match.Success)
                {
                    hasErr = true;
                    Err += "Last Name contains invalid Characters\n";
                }
            }*/

            //execution
            int IsAdmin;
            if (AdminCB.Checked)
            {
                IsAdmin = 1;
            }
            else
            {
                IsAdmin = 0;
            }

            if (!hasErr)
            {
                if (DataBuddy.submitBtn(id, fntb.Text, lntb.Text, passtb.Text, emailtb.Text, IsAdmin))
                {
                    MessageBox.Show("Data inserted succesfully");
                    fntb.Text = "";
                    lntb.Text = "";
                    emailtb.Text = "";
                    passtb.Text = "";
                    display();
                    cancelbtn.Enabled = false;
                    deletebtn.Enabled = false;
                    SubUptBtn.Text = "Submit";
                }
                else
                {
                    MessageBox.Show("Data Updated successfully");
                    fntb.Text = "";
                    lntb.Text = "";
                    emailtb.Text = "";
                    passtb.Text = "";
                    display();
                    cancelbtn.Enabled = false;
                    deletebtn.Enabled = false;
                    SubUptBtn.Text = "Submit";
                }
            }
            else
            {
                MessageBox.Show(Err);
                cancel();
            }
        }

        private void ExtBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
