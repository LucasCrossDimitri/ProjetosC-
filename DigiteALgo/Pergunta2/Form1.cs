using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pergunta2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Msg_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Verificando o valor do texto. 

            string nome;

            if (txbNome.Text.Length != 0)
            {
                MessageBox.Show("UFAA DIGITOU ALGO", "TESTANDO A SUA PACIÊNCIA");

                nome = Convert.ToString(txbNome.Text);

                if (nome == "Claudia")
                { MessageBox.Show(" Oi   " + nome, " NOME TESTADO"); }

            }

            if (txbNome.Text.Length == 0)
            {

                // Initialiando as variáveis para passar pro  M 


                string message = "Você não digitou Nada na caixa de Texto.                    Cancelar esta operação?";
                string caption = "Erro Detectado na Entrada de Dados";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    this.Close();

                }
            }
        }

        private void Verificar_Click(object sender, EventArgs e)
        {

        }
    }
}
