using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numero_par_impar_zero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChecar_Click(object sender, EventArgs e)
        {
            int ValorC;
            ValorC = Convert.ToInt32(txtInteiro.Text);
            if (ValorC == 0)
            {
                lblResp.Text = "Zero";
            }
            else
            {
                if (ValorC % 2 != 0)
                {
                    lblResp.Text = "Impar";
                }
                else
                {
                lblResp.Text = "Par";
                }
            }
        }
    }
}
