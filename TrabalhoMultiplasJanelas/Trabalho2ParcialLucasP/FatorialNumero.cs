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
    public partial class FatorialNumero : Form
    {
        int n, fato = 1;
        public FatorialNumero()
        {
            InitializeComponent();
        }

        private void txtFato_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if(txtFato.Text != String.Empty)
                {
                    n = Convert.ToInt32(txtFato.Text);
                    if (n > 0)
                    {
                        for (int i = 1; i <= n; i++)
                        {
                            fato *= i;
                            fato = fatorial2(n);
                            lblFato.Text = fato.ToString();
                        }
                    }
                }
                else
                {
                    lblFato.Text = "";
                }
            }
            catch
            {
                if (txtFato.Text != String.Empty)
                {
                    txtFato.Text = "";
                }
            }
        }
        private int fatorial2(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * fatorial2(n - 1);
        }
    }
}
