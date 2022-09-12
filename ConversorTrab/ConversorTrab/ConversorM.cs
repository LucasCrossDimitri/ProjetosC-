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
    public partial class ConversorM : Form
    {
        public ConversorM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Quilómetros - Centímetros - Metros
            //Se os campos não estiverem vazios
            if (txtConverte.Text != String.Empty && comboGrausPara.Text != String.Empty)
            {
                if (comboGraus.Text == "Quilómetros" && comboGrausPara.Text == "Centímetros")
                {
                    double result = QParaC(double.Parse(txtConverte.Text));
                    txtResult.Text = result.ToString(String.Format("0.#######", result));//formatação da saida
                }
                if (comboGraus.Text == "Quilómetros" && comboGrausPara.Text == "Metros")
                {
                    double result = QParaM(double.Parse(txtConverte.Text));
                    txtResult.Text = result.ToString(String.Format("0.#######", result));//formatação da saida
                }
                if (comboGraus.Text == "Centímetros" && comboGrausPara.Text == "Quilómetros")
                {
                    double result = CParaQ(double.Parse(txtConverte.Text));
                    txtResult.Text = result.ToString(String.Format("0.#######", result));//formatação da saida
                }
                if (comboGraus.Text == "Centímetros" && comboGrausPara.Text == "Metros")
                {
                    double result = CParaM(double.Parse(txtConverte.Text));
                    txtResult.Text = result.ToString(String.Format("0.#######", result));//formatação da saida
                }
                if (comboGraus.Text == "Metros" && comboGrausPara.Text == "Centímetros")
                {
                    double result = MParaC(double.Parse(txtConverte.Text));
                    txtResult.Text = result.ToString(String.Format("0.#######", result));//formatação da saida
                }
                if (comboGraus.Text == "Metros" && comboGrausPara.Text == "Quilómetros")
                {
                    double result = MParaQ(double.Parse(txtConverte.Text));
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

        // Quilómetros para Centímetros
        public double QParaC(double medQ)
        {
            return (medQ * 100000 );
        }
        // Quilómetros para Metros
        public double QParaM(double medQ)
        {
            return (medQ * 1000);
        }
        // Centímetros para Quilómetros
        public double CParaQ(double medQ)
        {
            return (medQ * 0.00001);
        }
        // Centímetros para Metros
        public double CParaM(double medQ)
        {
            return (medQ * 0.01);
        }
        // Metros para Centímetros
        public double MParaC(double medQ)
        {
            return (medQ * 100);
        }
        // Metros para Quilómetros
        public double MParaQ(double medQ)
        {
            return (medQ * 0.001);
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
