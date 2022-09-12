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
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }

        private void txbfibo_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                if (txbfibo.Text != string.Empty)
                {
                    ltbFibo.Items.Clear();
                    int x = 0, y = 1, sequencia = 0, limite = 0, i;
                    limite = Convert.ToInt32(txbfibo.Text);
                    ltbFibo.Items.Add("0");
                    ltbFibo.Items.Add("1");
                    for (i = 0; i < limite; i++)
                    {
                        sequencia = (x + y);
                        ltbFibo.Items.Add(sequencia.ToString());
                        x = y;
                        y = sequencia;
                    }
                }
                else
                {
                    txbfibo.Text = "";
                    ltbFibo.Items.Clear();
                }
            }
            catch
            {
                if (txbfibo.Text != string.Empty)
                {
                    txbfibo.Text = "";
                    ltbFibo.Items.Clear();
                }
            }
        }

        private void ltbFibo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
