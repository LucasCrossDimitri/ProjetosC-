using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numero_Inteiro
{
    public partial class txtValor1 : Form
    {
        public txtValor1()
        {
            InitializeComponent();
        }

        private void btnChecar_Click(object sender, EventArgs e)
        {
            int ValorC;
            ValorC = Convert.ToInt32(txtInteiro.Text);
            if (ValorC < 0)
            {
            lblResp.Text = "-";
            }
            else
            {
            lblResp.Text = "+";
            }

        }

        private void txtValor1_Load(object sender, EventArgs e)
        {

        }
    }
}
