using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoPadaria
{
    public partial class Form1 : Form
    {
        double t1 = 0, t2 = 0, t3 = 0, t4 = 0, t5 = 0,Paga = 0,Ttl = 0;
        double total = 0,troco = 0;
        int Padaria; 


        public Form1()
        {
            InitializeComponent();
        }

        private void tx1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (tx1.Text != String.Empty)
                {

                    Padaria = Convert.ToInt16(tx1.Text);
                    t1 = Padaria * 2;
                    tr1.Text = t1.ToString();
                    total = t1 + t2 + t3 + t4 + t5;
                    lbltotal.Text = total.ToString();

                }

            }
            catch{ }
        }

        private void tx2_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (tx2.Text != String.Empty)
                {

                    Padaria = Convert.ToInt16(tx2.Text);
                    t2 = Padaria * 0.50;
                    tr2.Text = t2.ToString();
                    total = t1 + t2 + t3 + t4 + t5;
                    lbltotal.Text = total.ToString();

                }

            }
            catch { }

        }

        private void tx3_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (tx3.Text != String.Empty)
                {

                    Padaria = Convert.ToInt16(tx3.Text);
                    t3 = Padaria * 0.75;
                    tr3.Text = t3.ToString();
                    total = t1 + t2 + t3 + t4 + t5;
                    lbltotal.Text = total.ToString();

                }

            }
            catch { }
        }

        private void tx4_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (tx4.Text != String.Empty)
                {

                    Padaria = Convert.ToInt16(tx4.Text);
                    t4 = Padaria * 15;
                    tr4.Text = t4.ToString();
                    total = t1 + t2 + t3 + t4 + t5;
                    lbltotal.Text = total.ToString();

                }

            }
            catch { }
        }

        private void tx5_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (tx5.Text != String.Empty)
                {

                    Padaria = Convert.ToInt16(tx5.Text);
                    t5 = Padaria * 12;
                    tr5.Text = t5.ToString();
                    total = t1 + t2 + t3 + t4 + t5;
                    lbltotal.Text = total.ToString();

                }

            }
            catch { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

            try
            {
                Paga = Convert.ToInt16(lbltotal.Text);
                Ttl = Convert.ToInt16(TxPag.Text);

                if (TxPag.Text != String.Empty)
                {
                    if (Ttl >= Paga)
                    {
                        troco = Ttl - Paga;
                        lblTrc.Text = troco.ToString();
                    }
                    else
                    {
                        lblTrc.Text = "Você não tem dinheiro suficiente \n para finalizar a compra.";
                    }
                }
            }
            catch { 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image i = Image.FromFile("E:\\Lucas Patrick Casara IN-222\\imagens\\pao.jpg");
            Foto.BackgroundImage = i;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Image i = Image.FromFile("E:\\Lucas Patrick Casara IN-222\\imagens\\paoF.jpg");
            Foto.BackgroundImage = i;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Image i = Image.FromFile("E:\\Lucas Patrick Casara IN-222\\imagens\\paoP.jpg");
            Foto.BackgroundImage = i;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Image i = Image.FromFile("E:\\Lucas Patrick Casara IN-222\\imagens\\Nm.jpg");
            Foto.BackgroundImage = i;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Image i = Image.FromFile("E:\\Lucas Patrick Casara IN-222\\imagens\\Limao.jpg");
            Foto.BackgroundImage = i;
        }
    }
}
