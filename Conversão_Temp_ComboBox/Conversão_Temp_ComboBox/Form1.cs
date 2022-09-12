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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           //Se os campos não estiverem vazios
             if (txtConverte.Text != String.Empty && comboGrausPara.Text != String.Empty)
               {
                   if (comboGraus.Text == "Celsius" && comboGrausPara.Text == "Farenheit")
                   {
                     double result = CParaF(double.Parse(txtConverte.Text));
                     txtResult.Text = result.ToString(String.Format("0.##", result));//formatação da saida
                   }
                  if (comboGraus.Text == "Farenheit" && comboGrausPara.Text == "Celsius") 
                  {
                      double result = FParaC(double.Parse(txtConverte.Text));
                      txtResult.Text = result.ToString(String.Format("0.##",result));
                  }
                  if (comboGraus.Text == "Kelvin" && comboGrausPara.Text == "Celsius")
                  {
                      double result = KParaC(double.Parse(txtConverte.Text));
                      txtResult.Text = result.ToString(String.Format("0.##", result));
                  }
                  if (comboGraus.Text == "Rankine" && comboGrausPara.Text == "Celsius")
                  {
                      double result = RParaC(double.Parse(txtConverte.Text));
                      txtResult.Text = result.ToString(String.Format("0.##", result));
                  }
                  if (comboGraus.Text == "Kelvin" && comboGrausPara.Text == "Farenheit")
                  {
                      double result = KParaF(double.Parse(txtConverte.Text));
                      txtResult.Text = result.ToString(String.Format("0.##", result));
                  }
                  if (comboGraus.Text == "Rankine" && comboGrausPara.Text == "Farenheit")
                  {
                      double result = RParaF(double.Parse(txtConverte.Text));
                      txtResult.Text = result.ToString(String.Format("0.##", result));
                  }
                  if (comboGraus.Text == "Rankine" && comboGrausPara.Text == "Kelvin")
                  {
                      double result = RParaK(double.Parse(txtConverte.Text));
                      txtResult.Text = result.ToString(String.Format("0.##", result));
                  }
                  if (comboGraus.Text == "Celsius" && comboGrausPara.Text == "Kelvin")
                  {
                      double result = CParaK(double.Parse(txtConverte.Text));
                      txtResult.Text = result.ToString(String.Format("0.##", result));
                  }
                  if (comboGraus.Text == "Farenheit" && comboGrausPara.Text == "Kelvin")
                  {
                      double result = FParaK(double.Parse(txtConverte.Text));
                      txtResult.Text = result.ToString(String.Format("0.##", result));
                  }
                  if (comboGraus.Text == "Celsius" && comboGrausPara.Text == "Rankine")
                  {
                      double result = CParaR(double.Parse(txtConverte.Text));
                      txtResult.Text = result.ToString(String.Format("0.##", result));
                  }
                  if (comboGraus.Text == "Farenheit" && comboGrausPara.Text == "Rankine")
                  {
                      double result = FParaR(double.Parse(txtConverte.Text));
                      txtResult.Text = result.ToString(String.Format("0.##", result));
                  }
                  if (comboGraus.Text == "Kelvin" && comboGrausPara.Text == "Rankine")
                  {
                      double result = KParaR(double.Parse(txtConverte.Text));
                      txtResult.Text = result.ToString(String.Format("0.##", result));
                  }

                 //para conversões iguais
                 if (comboGraus.Text == comboGrausPara.Text)
                  {
                     txtResult.Text = txtConverte.Text;
                  }
              }
           }
//métodos das conversões

// Farenheit para Celsius
// °C = (°F − 32) / 1,8
public double FParaC(double tempF)
{
    
return (tempF - 32) / 1.8;
}

//Celsius para Farenheit
//°F = °C × 1,8 + 32
public double CParaF(double tempC)
{
return (tempC * 1.8) + 32;
}
//==============================
//Celsius para Kevin
// K = °C + 273,15
public double CParaK(double tempC)
{
    return (tempC + 273.15);
}


//==============================
//Kelvin para Celsius
//°C = K − 273,15
//Faça sua Função Aqui
public double KParaC(double tempK)
{
    return (tempK - 273.15);
}



//==============================
//Celsius para Rankine	
//°R = (°C + 273,15) × 1,8
//Faça sua Função Aqui
public double CParaR(double tempC)
{
    return (tempC + 273.15) * 1.8;
}

//==============================        
//Rankine	para Celsius	
//°C = (°R ÷ 1,8) – 273,15
//Faça sua Função Aqui
public double RParaC(double tempK)
{
    return (tempK / 1.8) - 273.15;
}

//==============================        
//Rankine	para Kelvin
//
public double RParaK(double tempR)
{
    return (tempR * 5/9);
}
//==============================        
//Rankine	para Farenheit	
//
public double RParaF(double tempR)
{
    return (tempR - 459.67);
}
//==============================        
//Farenheit	para Kelvin	
//
public double FParaK(double tempF)
{
    return (tempF + 459.67) / 1.8;
}
//==============================        
//Farenheit	para Rankine	
//
public double FParaR(double tempF)
{
    return (tempF + 459.67);
}
//==============================        
//Kelvin	para Farenheit	
//
public double KParaF(double tempK)
{
    return (tempK * 1.8) - 459.67;
}
//==============================        
//Kelvin	para Rankine	
//
public double KParaR(double tempK)
{
    return (tempK * 1.8);
}

//método do botão apagar

private void btnApagar_Click(object sender, EventArgs e)
{

}

private void button2_Click(object sender, EventArgs e)
{
    txtConverte.Clear();
    txtResult.Clear();
    comboGraus.Text="";
    comboGrausPara.Text = "";
}

private void comboGraus_SelectedIndexChanged(object sender, EventArgs e)
{

}
        }
    }

