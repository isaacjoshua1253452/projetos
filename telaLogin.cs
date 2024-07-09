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
namespace senacBank
{
    public partial class telaLogin : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-4LGT3GE;Initial Catalog=senacbank1_db;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;
        public telaLogin()
        {
            InitializeComponent();
        }
        private void botaoLogin_Click(object sender, EventArgs e)
        {
            login l1 = new login();
            l1.Show();
            this.Hide();
        }

        private void botaoRegistro_Click(object sender, EventArgs e)
        {
            cadastro c1 = new cadastro();
            c1.Show();
            this.Hide();
        }

        private void telaLogin_Load(object sender, EventArgs e)
        {
            cn.Open();
        }
    }
}
