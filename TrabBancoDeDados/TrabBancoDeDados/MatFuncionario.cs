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
    public partial class MatFuncionario : Form
    {
        public MatFuncionario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dsFunc1.HasChanges())
            {
                DatFunc.Update(dsFunc1);
                dsFunc1.AcceptChanges();
            }
        }

        private void dataGrid1_Navigate(object sender, NavigateEventArgs ne)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Pos = this.BindingContext[dsFunc1, "MatFuncionario"].Position;
            dsFunc1.MatFuncionario.Rows[Pos].Delete();
        }

        private void MatFuncionario_Load(object sender, EventArgs e)
        {
            DatFunc.Fill(dsFunc1);
        }
    }
}
