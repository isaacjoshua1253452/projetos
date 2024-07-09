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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace senacBank
{
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-4LGT3GE;Initial Catalog=senacbank1_db;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;
        private void cadastro_Load(object sender, EventArgs e)
        {

        }
        private void guna2TextBox2_TextChanged(object sender, KeyPressEventArgs e)
        {

        }
        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            var keycode = (int)e.KeyChar;
            if (keycode >= 48 && keycode <= 57)
            {
                e.Handled = true;
            }
        }
        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
        private void guna2TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            telaLogin tl1 = new telaLogin();
            tl1.Show();
            this.Hide();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int saldo = 0;
            string validacaosenha = senhaTB.Text;
            bool SenhaContemNumero(string senhaStringBool)
            {
                return senhaStringBool.Any(char.IsDigit);
            }
            bool SenhaContemCaracterEspecial = Regex.IsMatch(validacaosenha, @"[!@#$%^&*()_+{}\[\]:;<>,.?~]");

            if (string.IsNullOrWhiteSpace(nomeTB.Text) ||
                string.IsNullOrWhiteSpace(emailTB.Text) ||
                string.IsNullOrWhiteSpace(sexoCB.Text) ||
                string.IsNullOrWhiteSpace(cidadeTB.Text) ||
                string.IsNullOrWhiteSpace(bairroTB.Text) ||
                string.IsNullOrWhiteSpace(ruaTB.Text) ||
                string.IsNullOrWhiteSpace(numeroTB.Text) ||
                string.IsNullOrWhiteSpace(estadoMTB.Text) ||
                string.IsNullOrWhiteSpace(complementoTB.Text) ||
                string.IsNullOrWhiteSpace(senhaTB.Text) ||
                string.IsNullOrWhiteSpace(confirmarsenhaTB.Text) ||
                string.IsNullOrWhiteSpace(estadocivilCB.Text))
            {
                MessageBox.Show("Preencha TODOS os campos antes de continuar.");
            }
            if (senhaTB.Text != confirmarsenhaTB.Text)
            {
                MessageBox.Show("A senha não confere com a confirmação");
            }
            else if (validacaosenha.Length < 8)
            {
                MessageBox.Show("A senha deve conter no mínimo 8 caracteres");
            }
            else if (!SenhaContemNumero(validacaosenha))
            {
                MessageBox.Show("A senha deve conter no mínimo um número");
            }
            else if (!SenhaContemCaracterEspecial)
            {
                MessageBox.Show("A senha deve conter no mínimo um caracter especial,por exemplo: !@#$%^&*()_+{}\\[\\]:;<>,.?~");
            }
            else if (!termosCB.Checked)
            {
                MessageBox.Show("Você deve aceitar nossos termos e condições para abrir sua conta");
            }
            string validaemail = emailTB.Text;
            if (!validaemail.Contains(".") || !validaemail.Contains("@"))
            {
                MessageBox.Show("Você não colocou um e-mail valido :,( ");
            }
            else if (!cpfMTB.MaskCompleted || !datanascimentoMTB.MaskCompleted || !telefoneMTB.MaskCompleted || !cepMTB.MaskCompleted)
            {
                MessageBox.Show("Preencha TODOS os campos antes de continuar.");
            }
            else
            {
                try
                {
                    cn.Open();
                    string strSQL = "Select cpf from senacbank1 where cpf = " + cpfMTB.Text;

                    cm.Connection = cn;
                    cm.CommandText = strSQL;
                    dt = cm.ExecuteReader();
                    if (dt.HasRows)
                    {
                        MessageBox.Show("CPF já Cadastrado");
                    }
                    else
                    {
                        if (!dt.IsClosed) { dt.Close(); }
                        strSQL = "insert into senacbank1(nomecompleto,cpf,sexo,datanascimento,estadocivil,email,telefone,cidade,estado,bairro,cep,rua,numerocasa,complemento,senha,saldo) values(@nome,@cpf,@sexo,@datanascimento,@estadocivil,@email,@telefone,@cidade,@estado,@bairro,@cep,@rua,@numero,@complemento,@senha,@saldo)";
                        cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = nomeTB.Text;
                        cm.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpfMTB.Text;
                        cm.Parameters.Add("@sexo", SqlDbType.VarChar).Value = sexoCB.Text;
                        cm.Parameters.Add("@datanascimento", SqlDbType.VarChar).Value = datanascimentoMTB.Text;
                        cm.Parameters.Add("@estadocivil", SqlDbType.VarChar).Value = estadocivilCB.Text;
                        cm.Parameters.Add("@email", SqlDbType.VarChar).Value = emailTB.Text;
                        cm.Parameters.Add("@telefone", SqlDbType.VarChar).Value = telefoneMTB.Text;
                        cm.Parameters.Add("@cidade", SqlDbType.VarChar).Value = cidadeTB.Text;
                        cm.Parameters.Add("@bairro", SqlDbType.VarChar).Value = bairroTB.Text;
                        cm.Parameters.Add("@rua", SqlDbType.VarChar).Value = ruaTB.Text;
                        cm.Parameters.Add("@numero", SqlDbType.VarChar).Value = numeroTB.Text;
                        cm.Parameters.Add("@estado", SqlDbType.VarChar).Value = estadoMTB.Text;
                        cm.Parameters.Add("@complemento", SqlDbType.VarChar).Value = complementoTB.Text;
                        cm.Parameters.Add("@cep", SqlDbType.VarChar).Value = cepMTB.Text;
                        cm.Parameters.Add("@senha", SqlDbType.VarChar).Value = senhaTB.Text;
                        cm.Parameters.Add("@saldo", SqlDbType.Int).Value = saldo;

                        cm.Connection = cn;
                        cm.CommandText = strSQL;
                        cm.ExecuteNonQuery();
                        cn.Close();
                        cadastro4 c4 = new cadastro4();
                        c4.Show();
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
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void emailTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
        }

        private void emailTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void numeroTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
