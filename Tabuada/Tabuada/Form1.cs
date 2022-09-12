using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ltbTabuada.Items.Clear(); 
        }

        private void Limites_Click(object sender, EventArgs e)
        {
            int inicio, fim, i;

            inicio = Convert.ToInt16(txbLI.Text);

            fim = Convert.ToInt16(txbLF.Text);

            if (inicio < fim)
            {
                for (i = inicio; i <= fim; i++)
                {
                ltbTabuada.Items.Add(i);
                }
            }
                else
                {
                MessageBox.Show("ERRO Digite Certo");
                    txbLI.Text = "";
                    txbLF.Text = "";
                }
        }

        private void txbLF_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
