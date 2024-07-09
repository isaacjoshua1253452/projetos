using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace senacBank
{
    public partial class cadastro4 : Form
    {
        public cadastro4()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            login l1 = new login();
            l1.Show();
            this.Hide();

        }
    }
}
