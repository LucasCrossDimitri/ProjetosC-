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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Departamento_Click(object sender, EventArgs e)
        {
            Dep um = new Dep();
            um.Show();
        }

        private void FunProj_Click(object sender, EventArgs e)
        {
            FunProjeto dois = new FunProjeto();
            dois.Show();
        }

        private void MatFunc_Click(object sender, EventArgs e)
        {
            MatFuncionario tre = new MatFuncionario();
            tre.Show();
        }

        private void NumProj_Click(object sender, EventArgs e)
        {
            NumeroDoProjeto quatro = new NumeroDoProjeto();
            quatro.Show();
        }

        private void ProjDep_Click(object sender, EventArgs e)
        {
            projetoDep cinco = new projetoDep();
            cinco.Show();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
