using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vogal_consoante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            char resp;
            resp = Convert.ToChar(txtL.Text);

            if ((resp == 'a') || (resp == 'A') || (resp == 'e') || (resp == 'E') || (resp == 'i') || (resp == 'I') || (resp == 'O') || (resp == 'o') || (resp == 'U') || (resp == 'u'))
            {
                lblR.Text = "Vogal";
            }
            else if ((resp == 'q') || (resp == 'w') || (resp == 'r') || (resp == 't') || (resp == 'y') || (resp == 'p') || (resp == 's') || (resp == 'd') || (resp == 'f') || (resp == 'g') || (resp == 'h') || (resp == 'j') || (resp == 'k') || (resp == 'l') || (resp == 'z') || (resp == 'x') || (resp == 'c') || (resp == 'v') || (resp == 'b') || (resp == 'n') || (resp == 'm') || (resp == 'Q') || (resp == 'W') || (resp == 'R') || (resp == 'T') || (resp == 'Y') || (resp == 'P') || (resp == 'S') || (resp == 'D') || (resp == 'F') || (resp == 'G') || (resp == 'H') || (resp == 'J') || (resp == 'K') || (resp == 'L') || (resp == 'Z') || (resp == 'X') || (resp == 'C') || (resp == 'V') || (resp == 'B') || (resp == 'N') || (resp == 'M'))
            {
                lblR.Text = "Consoante";
            }
            else
            {
                lblR.Text = "Carater por favor.";
            }
        }
    }
}
