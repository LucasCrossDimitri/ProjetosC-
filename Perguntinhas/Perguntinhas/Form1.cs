using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perguntinhas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sr_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
