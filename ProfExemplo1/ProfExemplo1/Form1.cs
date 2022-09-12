using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfExemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
                  //Evento do FormClosing
         // vamos interceptar o fechamento do formulário e
         // perguntar se o usuário deseja mesmo fechar
         

 DialogResult res = MessageBox.Show("Deseja mesmo fechar o programa?", "Fechar" , MessageBoxButtons.YesNo);
        

    // se o usuário responder "Não" nós cancelamento o fechamento
        

     if( res == DialogResult.No)
          
         e.Cancel = true;
        }
    }
}
