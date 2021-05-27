using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        private Calculadora Num = new Calculadora();
        private int op;
        public int Op { get => op; set => op = value; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void limpiar()
        {
            txtOperaciones.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtOperaciones.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtOperaciones.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtOperaciones.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtOperaciones.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtOperaciones.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtOperaciones.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtOperaciones.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtOperaciones.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtOperaciones.Text += "3";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtOperaciones.Text += "0";
        }

        private void buttonPunto_Click(object sender, EventArgs e)
        {
            txtOperaciones.Text += ",";
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            Num.Numero1 = Convert.ToSingle(txtOperaciones.Text);
            Op = 1;
            limpiar();

        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            Num.Numero1 = Convert.ToSingle(txtOperaciones.Text);
            Op = 2;
            limpiar();
        }

        private void buttonMultiplicacion_Click(object sender, EventArgs e)
        {
            Num.Numero1 = Convert.ToSingle(txtOperaciones.Text);
            Op = 3;
            limpiar();
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            Num.Numero1 = Convert.ToSingle(txtOperaciones.Text);
            Op = 4;
            limpiar();
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            Num.Numero2 = Convert.ToSingle(txtOperaciones.Text);
            switch (Op)
            {
                case 1:
                    {
                        txtOperaciones.Text =Convert.ToString( Num.Sumar(Num.Numero1, Num.Numero2));
                    }
                    break;
                case 2:
                    {
                        txtOperaciones.Text = Convert.ToString(Num.Restar(Num.Numero1, Num.Numero2));
                    }
                    break;
                case 3:
                    {
                        txtOperaciones.Text = Convert.ToString(Num.Multiplicar(Num.Numero1, Num.Numero2));
                    }
                    break;
                case 4:
                    {
                        if (Num.Numero2 != 0)
                        {
                            txtOperaciones.Text = Convert.ToString(Num.Dividir(Num.Numero1, Num.Numero2));
                        }
                        else txtOperaciones.Text = "ERROR";
                        
                    }
                    break;
            }

        }

        private void C_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txtOperaciones_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    
}
