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
    public partial class NumeroDesejado : Form
    {
        int final, cont1, cont2, res, N;
        public NumeroDesejado()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txbND.Text != String.Empty)
                {
                    final = Convert.ToInt16(txbND.Text);
                    if (final != 0)
                    {
                        ltbND.Items.Clear();
                        ltbND.Items.Add("1");
                        for(cont1 = 0; cont1 <= final; cont1++)
                        {
                            N = 0;
                            for (cont2 = 1; cont2 <= cont1; cont2++)
                            {
                                res = cont1 % cont2;
                                if (res == 0)
                                    N = N + 1;
                            }
                            if (N == 2)
                                ltbND.Items.Add(cont1.ToString());
                        }
                    }
                }
                else
                {
                    txbND.Text = "";
                    ltbND.Items.Clear();
                }
            }
            catch
            {
                if (txbND.Text != String.Empty)
                {
                    txbND.Text = "";
                    ltbND.Items.Clear();
                }
            }
        }

    }
}
