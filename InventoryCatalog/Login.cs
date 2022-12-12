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

namespace InventoryCatalog
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public int Id;
        public Login()
        {
            InitializeComponent();
            this.Select();
            //this.Focus();
            user_tb.Select();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            //DataTable dt = DataBuddy.logincheck(user_tb.Text, pass_tb.Text);
            Id = DataBuddy.logincheck(user_tb.Text, pass_tb.Text);
            //MessageBox.Show(Id.ToString());
            if (Id != 0)
            {
                this.Hide();
                Main main = new Main(Id);
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please check your username and password");
            }
            
        }

        private void login_btn_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void login_btn_MouseHover(object sender, EventArgs e)
        {
            //login_btn.BackColor = Color.Green;
        }

        private void login_btn_MouseLeave(object sender, EventArgs e)
        {
            login_btn.BackColor = Color.White;
        }

        private void login_btn_MouseEnter(object sender, EventArgs e)
        {
            login_btn.BackColor = Color.Green;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //this.Focus();
        }
    }
}
