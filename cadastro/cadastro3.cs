using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace senacBank
{
    public partial class cadastro3 : Form
    {
        public cadastro3()
        {
            InitializeComponent();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string validacaosenha = senhaTB.Text;
            bool SenhaContemNumero(string senhaStringBool)
            {
                return senhaStringBool.Any(char.IsDigit);
            }
            bool SenhaContemCaracterEspecial = Regex.IsMatch(validacaosenha, @"[!@#$%^&*()_+{}\[\]:;<>,.?~]");
            if (string.IsNullOrWhiteSpace(senhaTB.Text) || string.IsNullOrWhiteSpace(confirmarsenhaTB.Text))
            {
                MessageBox.Show("Preencha TODOS os campos antes de continuar.");
            }
            else if (senhaTB.Text != confirmarsenhaTB.Text)
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
            else
            {
                cadastro4 c4 = new cadastro4();
                c4.Show();
                this.Hide();
            }
        }

        private void cadastro3_Load(object sender, EventArgs e)
        {

        }
    }
}
