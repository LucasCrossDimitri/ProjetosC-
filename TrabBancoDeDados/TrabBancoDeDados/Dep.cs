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
    public partial class Dep : Form
    {
        public Dep()
        {
            InitializeComponent();
        }

        private void dataGrid1_Navigate(object sender, NavigateEventArgs ne)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void oleDbDataAdapter1_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //carrega os dados do banco de dados
            DatDep.Fill(dsDep1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //se houverem alteracoes no dataset
            if (dsDep1.HasChanges())
            {
                //atualiza os dados no banco de dados
                DatDep.Update(dsDep1);
                //aceita as alteracoes do dataSet
                dsDep1.AcceptChanges();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //recupera a posicao do registro selecionado
            int Pos = this.BindingContext[dsDep1, "Departamento"].Position;
            dsDep1.Departamento.Rows[Pos].Delete();

        }

        private void oleDbConnection1_InfoMessage(object sender, System.Data.OleDb.OleDbInfoMessageEventArgs e)
        {

        }
    }
}
