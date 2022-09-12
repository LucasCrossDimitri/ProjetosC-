using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoBiblioteca
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //caso houverem alterações no DataSet
            if (dataSet1.HasChanges())
            { 
                //grava as alterações na base de dados
                oleDbDataAdapter1.Update(dataSet1);
                //aceita as alterações na estrutura do DataSet
                dataSet1.AcceptChanges();
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            oleDbDataAdapter1.Fill(dataSet1);
            dataGrid1.DataSource = dataSet1;
            dataGrid1.DataMember = "Estado";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //deleta a linha corrente do DataSet
            dataSet1.Tables["Estado"].Rows[dataGrid1.CurrentRowIndex].Delete();
        }
    }
}
