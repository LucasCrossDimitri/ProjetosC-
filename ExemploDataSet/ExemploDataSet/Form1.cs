using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploDataSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGrid1_Navigate(object sender, NavigateEventArgs ne)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Carrega os dados do banco de dados
            datEstado.Fill(dsEstado1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //se houverem alterações no dataSet
            if (dsEstado1.HasChanges())
            {
                //atualiza os dados no banco de dados
                datEstado.Update(dsEstado1);
                //aceita as alterações do dataSet
                dsEstado1.AcceptChanges();

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //recupera a posição do registro selecionado
            int Pos = this.BindingContext[dsEstado1, "Estado"].Position;
            //delete a linha selecionada
            dsEstado1.estado.Rows[Pos].Delete();
        }
    }
}
