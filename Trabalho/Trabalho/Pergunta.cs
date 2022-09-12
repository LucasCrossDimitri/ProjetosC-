using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class Pergunta : Form
    {
        public Pergunta()
        {
            InitializeComponent();
        }

        private void MSG_Click(object sender, EventArgs e)
        {
            string nome;
            string sexo;
            int idade;
            sexo = txbSexo.Text;
            idade = Convert.ToInt16(txbIdade.Text);
            nome = txbNome.Text;
            MessageBox.Show("Então " + nome + " voce é do sexo " + sexo + " e tem " + idade + " anos !!", "S2 clawer");
        }

        private void Sr_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
