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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-4LGT3GE;Initial Catalog=senacbank1_db;Integrated Security=True");
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from senacbank1 where cpf='" + cpfMTB.Text + "' and senha = '" + senhaTB.Text + "'", cn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
                cn.Close();
            }
            else
            {
                MessageBox.Show("CPF inválido ou senha incorreta!");
            }
            cn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            esqueceusuasenha e1 = new esqueceusuasenha();
            e1.Show();
            this.Hide();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            telaLogin tl1 = new telaLogin();
            tl1.Show();
            this.Hide();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
