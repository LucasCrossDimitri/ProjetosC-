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
    public partial class Classe1 : Form
    {
        public Classe1()
        {
            InitializeComponent();
        }

        Usuario novoUsuario = new Usuario();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                novoUsuario.setNome(txtNome.Text);
                novoUsuario.setCpf(float.Parse(txtCpf.Text));
                novoUsuario.setEndereco(txtEnd.Text);
                novoUsuario.setEmail(txtMail.Text);
                novoUsuario.setTelefone(int.Parse(txtFone.Text));
                novoUsuario.setDataNasc(dateTimePicker1.Value);
                MessageBox.Show("Usuario Cadastrado !!");
            }
            catch (FormatException)
            {
                MessageBox.Show("ERRO DE CONVERSÃO !!");
            }

        }
}
}