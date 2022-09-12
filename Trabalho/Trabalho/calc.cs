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
    public partial class calc : Form
    {
        public calc()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;
            valor1 = Convert.ToInt32(txtValor1.Text);
            valor2 = Convert.ToInt32(txtValor2.Text);
            resultado = valor1 + valor2;
            lblResultado.Text = resultado.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;
            valor1 = Convert.ToInt32(txtValor1.Text);
            valor2 = Convert.ToInt32(txtValor2.Text);
            resultado = valor1 - valor2;
            lblResultado.Text = resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;
            valor1 = Convert.ToInt32(txtValor1.Text);
            valor2 = Convert.ToInt32(txtValor2.Text);
            resultado = valor1 * valor2;
            lblResultado.Text = resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;
            valor1 = Convert.ToInt32(txtValor1.Text);
            valor2 = Convert.ToInt32(txtValor2.Text);
            resultado = valor1 / valor2;
            lblResultado.Text = resultado.ToString();
        }

        private void txtValor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor2_TextChanged(object sender, EventArgs e)
        {

        }

        private void calc_Load(object sender, EventArgs e)
        {

        }
    }
}
