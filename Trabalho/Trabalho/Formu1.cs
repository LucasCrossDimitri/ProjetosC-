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
    public partial class Formu1 : Form
    {
        public Formu1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formu2 Dois = new Formu2();
            Dois.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formu3 treis = new Formu3();
            treis.Show();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formu2 Dois = new Formu2();
            Dois.Show();
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formu3 treis = new Formu3();
            treis.Show();
        }
    }
}
