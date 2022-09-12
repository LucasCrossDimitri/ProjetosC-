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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void BtCalc_Click(object sender, EventArgs e)
        {
            calc calc= new calc();
            calc.Show();
        }

        private void BtPesoideal_Click(object sender, EventArgs e)
        {
            Peso peso = new Peso();
            peso.Show();
        }

        private void BtNumero_Click(object sender, EventArgs e)
        {
            Numero_Inteiro Nr = new Numero_Inteiro();
            Nr.Show();
        }

        private void BtEstuda_Click(object sender, EventArgs e)
        {
            Turno Tr = new Turno();
            Tr.Show();
        }

        private void BtPergunta_Click(object sender, EventArgs e)
        {
            Pergunta perg = new Pergunta();
            perg.Show();
        }

        private void BtDespedida_Click(object sender, EventArgs e)
        {
            Formu1 formu = new Formu1();
            formu.Show();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
