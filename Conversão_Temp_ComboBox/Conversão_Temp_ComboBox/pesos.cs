using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversão_Temp_ComboBox
{
    public partial class pesos : Form
    {
        public pesos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
              if (txtConverte.Text != String.Empty && comboGrausPara.Text != String.Empty)
               {
                   if (comboGraus.Text == "kg" && comboGrausPara.Text == "g")
                   {
                     double result = KParaG(double.Parse(txtConverte.Text));
                     txtResult.Text = result.ToString(String.Format("0.##", result));//formatação da saida
                   }
                   if (comboGraus.Text == "g" && comboGrausPara.Text == "kg")
                   {
                       double result = GParaK(double.Parse(txtConverte.Text));
                       txtResult.Text = result.ToString(String.Format("0.##", result));//formatação da saida
                   }
                   //para conversões iguais
                   if (comboGraus.Text == comboGrausPara.Text)
                   {
                       txtResult.Text = txtConverte.Text;
                   }
               }
        }

        public double KParaG(double G)
        {

            return (G * 1000);
        }
        public double GParaK(double G)
        {

            return (G / 0.001);
        }



    }
}
