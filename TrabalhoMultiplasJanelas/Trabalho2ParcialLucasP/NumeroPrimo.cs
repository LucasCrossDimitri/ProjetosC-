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
    public partial class NumeroPrimo : Form
    {
        int nm, i, acumula = 1, i2;
        public NumeroPrimo()
        {
            InitializeComponent();
        }

        private void txbNumero_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txbNumero.Text != String.Empty)
                {
                    nm = Convert.ToInt16(txbNumero.Text);
                    for(i=1;i<=100;i++)
                    {
                        acumula = 0;
                        for(i2=1;i2<=nm;i2++)
                        {
                            if ((nm % i2) == 0)
                                acumula++;
                            if (acumula > 2)
                                lblNumero.Text = "Não é Primo";
                            else
                                lblNumero.Text = "É Primo";
                        }
                    }
                }
                else
                {
                    lblNumero.Text = "";
                }
            }
            catch
            {
                if (txbNumero.Text != String.Empty)
                {
                    txbNumero.Text = "";
                }
            }
        }
    }
}
