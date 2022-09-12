using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho2ParcialLucasP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FatorialNumero um = new FatorialNumero();
            um.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fibonacci dois = new Fibonacci();
            dois.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NumeroPrimo tres = new NumeroPrimo();
            tres.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           NumeroDesejado quatro = new NumeroDesejado();
            quatro.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
