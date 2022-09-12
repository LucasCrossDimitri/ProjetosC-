using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppMasterDetail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //carrega os dados da tabela TipoProduto do banco de dados
            datTipoProduto.Fill(dsProduto1);
            //carrega os dados da tabela Produto do banco de dados
            datProduto.Fill(dsProduto1);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if(dsProduto1.HasChanges())
            {
                datProduto.Update(dsProduto1);
                dsProduto1.AcceptChanges();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //recupera a posição do registro selecionado
            int Pos = this.BindingContext[dsProduto1, "Produto"].Position;
            //deleta a linha selecionada
            dsProduto1.produto.Rows[Pos].Delete();
        }
    }
}
