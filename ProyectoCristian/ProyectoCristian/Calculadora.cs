using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProyectoCristian
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        // Funcion para agregar texto en el Textbox
        private void agregarTxt(string texto)
        {
            textBox1.Text += texto;
            // Esto equivale a: textBox1.Text = textBox1.Text + texto

            if (texto == "1") {
                // Se va a ejecutar este codigo
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // textBox1.Text = textBox1.Text + "1";
            agregarTxt("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //textBox1.Text = textBox1.Text + "2";
            agregarTxt("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // textBox1.Text = textBox1.Text + "3";
            agregarTxt("3");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            // textBox1.Text = textBox1.Text + "0";
            agregarTxt("0");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // textBox1.Text = textBox1.Text + "7";
            agregarTxt("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // textBox1.Text = textBox1.Text + "8";
            agregarTxt("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // textBox1.Text = textBox1.Text + "9";
            agregarTxt("9");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // textBox1.Text = textBox1.Text + "4";
            agregarTxt("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // textBox1.Text = textBox1.Text + "5";
            agregarTxt("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // textBox1.Text = textBox1.Text + "6";
            agregarTxt("6");
        }

        private void buttonPunto_Click(object sender, EventArgs e)
        {
            // textBox1.Text = textBox1.Text + ".";
            agregarTxt(".");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // textBox1.Text = textBox1.Text + "/";
            agregarTxt("/");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // textBox1.Text = textBox1.Text + "*";
            agregarTxt("*");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // textBox1.Text = textBox1.Text + "-";
            agregarTxt("-");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // textBox1.Text = textBox1.Text + "+";
            agregarTxt("+");
        }

        private void Calculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Calculadora_KeyUp(object sender, KeyEventArgs e)
        {
            // Mostrar por consola de programador el valor de la tecla presionada
            Trace.WriteLine("La tecla presionada es: " + e.KeyValue);

            /*
            if (e.KeyValue == 96) // 0
            {
                textBox1.Text = textBox1.Text + "0";
            } 
            else if (e.KeyValue == 97) // 1
            {
                textBox1.Text = textBox1.Text + "1";
            }
            else if (e.KeyValue == 98) // 2
            {
                textBox1.Text = textBox1.Text + "2";
            }
            else if (e.KeyValue == 99) // 3
            {
                textBox1.Text = textBox1.Text + "3";
            }
            else if (e.KeyValue == 100) // 4
            {
                textBox1.Text = textBox1.Text + "4";
            }
            else if (e.KeyValue == 101) // 5
            {
                textBox1.Text = textBox1.Text + "5";
            }
            else if (e.KeyValue == 102) // 6
            {
                textBox1.Text = textBox1.Text + "6";
            }
            else if (e.KeyValue == 103) // 7
            {
                textBox1.Text = textBox1.Text + "7";
            }
            else if (e.KeyValue == 104) // 8
            {
                textBox1.Text = textBox1.Text + "8";
            }
            else if (e.KeyValue == 105) // 9
            {
                textBox1.Text = "";
            }
            */

            // Switch
            switch(e.KeyValue)
            {
                case 96: // 0
                    textBox1.Text = textBox1.Text + "0";
                    break;
                case 97: // 1
                    textBox1.Text = textBox1.Text + "1";
                    break;
                default:  // Por defecto se ejecuta esto;
                    // Codigo
                    break;

            }
        }

    }
}
