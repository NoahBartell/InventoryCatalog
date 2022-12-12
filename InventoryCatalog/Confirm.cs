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
    public partial class Confirm : MetroFramework.Forms.MetroForm
    {
        public Boolean answer;
        public Confirm()
        {
            InitializeComponent();
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            answer = true;
            this.Close();
        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            answer = false;
            this.Close();
        }
    }
}
