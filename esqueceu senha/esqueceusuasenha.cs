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
    public partial class esqueceusuasenha : Form
    {
        public esqueceusuasenha()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            esqueceusuasenha2 e2 = new esqueceusuasenha2();
            e2.Show();
            this.Hide();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            telaLogin t1 = new telaLogin();
            t1.Show();
            this.Hide();
        }
    }
}
