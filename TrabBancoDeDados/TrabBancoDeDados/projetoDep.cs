using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabBancoDeDados
{
    public partial class projetoDep : Form
    {
        public projetoDep()
        {
            InitializeComponent();
        }

        private void projetoDep_Load(object sender, EventArgs e)
        {
            datProjDep.Fill(dsProjDep1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dsProjDep1.HasChanges())
            {
                datProjDep.Update(dsProjDep1);
                dsProjDep1.AcceptChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Pos = this.BindingContext[dsProjDep1, "ProjetoDept"].Position;
            dsProjDep1.ProjetoDept.Rows[Pos].Delete();
        }
    }
}
