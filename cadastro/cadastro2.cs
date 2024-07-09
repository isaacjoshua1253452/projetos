using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace senacBank
{
    public partial class cadastro2 : Form
    {
        public cadastro2()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-4LGT3GE;Initial Catalog=senacbank1_db;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cadastro2_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cidadeTB.Text) ||
                string.IsNullOrWhiteSpace(bairroTB.Text) ||
                string.IsNullOrWhiteSpace(ruaTB.Text)    ||
                string.IsNullOrWhiteSpace(numeroTB.Text) ||
                string.IsNullOrWhiteSpace(estadoMTB.Text) ||
                string.IsNullOrWhiteSpace(complementoTB.Text))
            {
                MessageBox.Show("Preencha TODOS os campos antes de continuar.");
            }
            if (!cepMTB.MaskCompleted)
            {
                MessageBox.Show("Preencha TODOS os campos antes de continuar.");
            }
            else
            {
                try
                {
                    cn.Open();
                    string strSQL = "Select cep from senacbank1 where cep = " + cepMTB.Text;

                    cm.Connection = cn;
                    cm.CommandText = strSQL;
                    dt = cm.ExecuteReader();
                    if (dt.HasRows)
                    {
                        MessageBox.Show("CEP já Cadastrado");
                    }
                    else
                    {
                        if (!dt.IsClosed) { dt.Close(); }
                        strSQL = "insert into senacbank1(cidade,estado,bairro,cep,rua,numerocasa,complemento) values(@cidade,@estado,@bairro,@cep,@rua,@numerocasa,@complemento)";
                        cm.Parameters.Add("@cidade", SqlDbType.VarChar).Value = cidadeTB.Text;
                        cm.Parameters.Add("@bairro", SqlDbType.VarChar).Value = bairroTB.Text;
                        cm.Parameters.Add("@rua", SqlDbType.VarChar).Value = ruaTB.Text;
                        cm.Parameters.Add("@numero", SqlDbType.VarChar).Value = numeroTB.Text;
                        cm.Parameters.Add("@estado", SqlDbType.VarChar).Value = estadoMTB.Text;
                        cm.Parameters.Add("@complemento", SqlDbType.VarChar).Value = complementoTB.Text;
                        cm.Connection = cn;
                        cm.ExecuteNonQuery();
                        cn.Close();
                        cadastro3 c3 = new cadastro3();
                        c3.Show();
                        this.Hide();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    cn.Close();
                }
            }
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
