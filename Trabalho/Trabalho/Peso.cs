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
    public partial class Peso : Form
    {
        public Peso()
        {
            InitializeComponent();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            double n, resultado;
            char s;
            s = Convert.ToChar(txtS.Text);
            n = Convert.ToDouble(txtA.Text);
            if ((s == 'M') || (s == 'm'))
            {
                resultado = ((72.7 * n) - 58);
                lblR.Text = resultado.ToString();
            }
            if ((s == 'F') || (s == 'f'))
            {
                resultado = ((62.1 * n) - 44.7);
                lblR.Text = resultado.ToString();
            }
        }
    }
}
