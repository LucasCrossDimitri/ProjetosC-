using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabClassesClawer
{
    public partial class Classe2 : Form
    {
        public Classe2()
        {
            InitializeComponent();
        }

       Produtos novoProdutos = new Produtos();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                novoProdutos.setNome(txtNome.Text);
                novoProdutos.setTipo(txtTipo.Text);
                novoProdutos.setMarca(txtMarca.Text);
                novoProdutos.setIDP(float.Parse(txtIDP.Text));
                novoProdutos.setVaVenda(int.Parse(txtVV.Text));
                novoProdutos.setVaCompra(float.Parse(txtVC.Text));
                MessageBox.Show("Produto Cadastrado !!");
            }
            catch (FormatException)
            { 

                MessageBox.Show("ERRO DE CONVERSÃO !!");
            }
        }
    }
}
