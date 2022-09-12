using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace turno_voce_estuda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChecar_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void M_CheckedChanged(object sender, EventArgs e)
        {
            lblResp.Text = "BOM DIA!";
            V.Checked = false;
            N.Checked = false;
        }

        private void V_CheckedChanged(object sender, EventArgs e)
        {
            lblResp.Text = "BOA TARDE!";
            N.Checked = false;
            M.Checked = false;
        }
        private void N_CheckedChanged(object sender, EventArgs e)
        {
            lblResp.Text = "BOA Noite!";
            M.Checked = false;
            V.Checked = false;
        }
    }
}
