using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploDeClasse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Aluno novoAluno = new Aluno();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                novoAluno.setNome(txtNome.Text);
                novoAluno.setEndereco(txtEnd.Text);
                novoAluno.setNota1(float.Parse(txtNota1.Text));
                novoAluno.setNota2(float.Parse(txtNota2.Text));
                novoAluno.setNota3(float.Parse(txtNota3.Text));
                novoAluno.setDataNasc(dateTimePicker1.Value);
                novoAluno.setSalario(float.Parse(txtS.Text));
                novoAluno.setNomemae(txtNomeM.Text);
                novoAluno.setNomepai(txtNomeP.Text);
                novoAluno.setAdvertencias(int.Parse(txtAD.Text));
                MessageBox.Show("Aluno Cadastrado !!");
                button2.Enabled = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("ERRO DE CONVERSÃO !!");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float test;
                test = float.Parse(txtNota1.Text);
                if (test > 10)
                {
                    MessageBox.Show("ERRO NOTA ERRADA");
                    MessageBox.Show("DIGITE NOVEMENTE");
                    txtNota1.Text = "";
                }
                if (test < 0)
                {
                    MessageBox.Show("ERRO NOTA ERRADA");
                    MessageBox.Show("DIGITE NOVAMENTE");
                    txtNota1.Text = "";
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("ERRO DE CONVERSÃO");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float media;
            media = novoAluno.calculaMedia();
            MessageBox.Show("Media do auluno: " + media.ToString());
        }
    }
}
