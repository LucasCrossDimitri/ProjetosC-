using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Dois = new Form2();
            Dois.Show();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
