using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorTrab
{
    public partial class ConversorP : Form
    {
        public ConversorP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Kilograma - Grama
            //Se os campos não estiverem vazios
            if (txtConverte.Text != String.Empty && comboGrausPara.Text != String.Empty)
            {
                if (comboGraus.Text == "Kilograma" && comboGrausPara.Text == "Grama")
                {
                    double result = KParaG(double.Parse(txtConverte.Text));
                    txtResult.Text = result.ToString(String.Format("0.#######", result));//formatação da saida
                }
                if (comboGraus.Text == "Grama" && comboGrausPara.Text == "Kilograma")
                {
                    double result = GParaK(double.Parse(txtConverte.Text));
                    txtResult.Text = result.ToString(String.Format("0.#######", result));//formatação da saida
                }
                //para conversões iguais
                if (comboGraus.Text == comboGrausPara.Text)
                {
                    txtResult.Text = txtConverte.Text;
                }
            }
        }

        //métodos das conversões

        // Kilograma para Grama
        public double KParaG(double medK)
        {
            return (medK / 0.0010000);
        }
        // Grama para Kilograma
        public double GParaK(double medK)
        {
            return (medK / 1000.0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtConverte.Clear();
            txtResult.Clear();
            comboGraus.Text = "";
            comboGrausPara.Text = "";
        }
    }
}
