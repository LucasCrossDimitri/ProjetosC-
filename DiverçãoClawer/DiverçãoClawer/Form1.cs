using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiverçãoClawer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btDv1_Click(object sender, EventArgs e)
        {
            btDv1.Enabled = true;
            txtNumero.Enabled = true;
            bt2Dv.Enabled = true;
        }

        private void bt2Dv_Click(object sender, EventArgs e)
        {
            int limite;

            limite = Convert.ToInt16(txtNumero.Text);
            for(int i=0;i<limite;i++)
            {
                MessageBox.Show(i.ToString(), "Paciência");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btDv1.Enabled = true;
            txtNumero.Enabled = false;
            bt2Dv.Enabled = false;
        }
    }
}
