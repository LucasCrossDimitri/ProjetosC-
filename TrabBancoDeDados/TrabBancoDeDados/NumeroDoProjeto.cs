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
    public partial class NumeroDoProjeto : Form
    {
        public NumeroDoProjeto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dsNumero2.HasChanges())
            {
                datNumero.Update(dsNumero2);
                dsNumero2.AcceptChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Pos = this.BindingContext[dsNumero2, "NumeroDoProjeto"].Position;
            dsNumero2.NumeroDoProjeto.Rows[Pos].Delete();
        }

        private void NumeroDoProjeto_Load(object sender, EventArgs e)
        {
            datNumero.Fill(dsNumero2);
        }

        private void oleDbConnection1_InfoMessage(object sender, System.Data.OleDb.OleDbInfoMessageEventArgs e)
        {

        }
    }
}
