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
    public partial class FunProjeto : Form
    {
        public FunProjeto()
        {
            InitializeComponent();
        }

        private void FunProjeto_Load(object sender, EventArgs e)
        {
            datFun.Fill(dsFunProj1);
        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            if(dsFunProj1.HasChanges())
            {
                datFun.Update(dsFunProj1);
                dsFunProj1.AcceptChanges();
            }
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            int Pos = this.BindingContext[dsFunProj1, "FunProjeto"].Position;
            dsFunProj1.FunProjeto.Rows[Pos].Delete();
        }
    }
}
