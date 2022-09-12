using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppExemploCadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //carrega os registros da tabela Estado
            datEstado.Fill(dsEstado1);
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            //vai para o primeiro registro
            this.BindingContext[dsEstado1, "Estado"].Position = 0;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            //vai para o registro anterior
            this.BindingContext[dsEstado1, "Estado"].Position--;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            //vai para o proximo registro
            this.BindingContext[dsEstado1, "Estado"].Position++;
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            //vai para o ultimo registro
            this.BindingContext[dsEstado1, "Estado"].Position = dsEstado1.estado.Count - 1;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //adiciona um novo registro
            this.BindingContext[dsEstado1, "Estado"].AddNew();
            //manda o foco para o primeiro campo
            txtSigla.Focus();
        }
        
        private void Atualizar()
        {
            //força final da edicao corrente e tranfere os dados para o DataSet
            this.BindingContext[dsEstado1, "Estado"].EndCurrentEdit();
            //se existem alterações no DataSet
            if (dsEstado1.HasChanges())
            { 
                //grava no banco as alterações do DataSet
                datEstado.Update(dsEstado1.GetChanges());
                //aceita as alterações
                dsEstado1.AcceptChanges();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //a condição do if esta comparando se o retorno da messageBox foi 
            //Yes ou seja se o botão YES foi clicado
            if (DialogResult.Yes == MessageBox.Show(
                "Confirma Exclusão ?",
                "Confirma Exclusão ?",
            MessageBoxButtons.YesNo))
            {
                //deleta o registro corrente
                int Pos = this.BindingContext[dsEstado1,"Estado"].Position;
                dsEstado1.estado.Rows[Pos].Delete();
                Atualizar();
            }
        }
    }
}
