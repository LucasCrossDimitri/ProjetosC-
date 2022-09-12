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
    public partial class ConversorH : Form
    {
        public ConversorH()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Hora - Minuto - Segundo
            //Se os campos não estiverem vazios
            if (txtConverte.Text != String.Empty && comboGrausPara.Text != String.Empty)
            {
                if (comboGraus.Text == "Hora" && comboGrausPara.Text == "Minuto")
                {
                    double result = HParaM(double.Parse(txtConverte.Text));
                    txtResult.Text = result.ToString(String.Format("0.#######", result));//formatação da saida
                }
                if (comboGraus.Text == "Hora" && comboGrausPara.Text == "Segundo")
                {
                    double result = HParaS(double.Parse(txtConverte.Text));
                    txtResult.Text = result.ToString(String.Format("0.#######", result));//formatação da saida
                }
                if (comboGraus.Text == "Minuto" && comboGrausPara.Text == "Hora")
                {
                    double result = MParaH(double.Parse(txtConverte.Text));
                    txtResult.Text = result.ToString(String.Format("0.#######", result));//formatação da saida
                }
                if (comboGraus.Text == "Minuto" && comboGrausPara.Text == "Segundo")
                {
                    double result = MParaS(double.Parse(txtConverte.Text));
                    txtResult.Text = result.ToString(String.Format("0.#######", result));//formatação da saida
                }
                if (comboGraus.Text == "Segundo" && comboGrausPara.Text == "Minuto")
                {
                    double result = SParaM(double.Parse(txtConverte.Text));
                    txtResult.Text = result.ToString(String.Format("0.#######", result));//formatação da saida
                }
                if (comboGraus.Text == "Segundo" && comboGrausPara.Text == "Hora")
                {
                    double result = SParaH(double.Parse(txtConverte.Text));
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
        public double HParaM(double medK)
        {
            return (medK * 60);
        }
        public double HParaS(double medK)
        {
            return (medK * 3600);
        }
        public double MParaH(double medK)
        {
            return (medK / 60);
        }
        public double MParaS(double medK)
        {
            return (medK * 60);
        }
        public double SParaM(double medK)
        {
            return (medK / 60);
        }
        public double SParaH(double medK)
        {
            return (medK / 3600);
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
