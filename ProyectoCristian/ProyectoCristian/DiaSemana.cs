using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCristian
{
    public partial class DiaSemana : Form
    {
        public DiaSemana()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            // Obtener el dia digitado
            byte dia = Convert.ToByte(textBox1.Text);

            if (dia == 1)
            {
                MessageBox.Show("Domingo");
            }

            if (dia == 2)
            {
                MessageBox.Show("Lunes");
            }

            if (dia == 3)
            {
                MessageBox.Show("Martes");
            }

            if (dia == 4)
            {
                MessageBox.Show("Miercoles");
            }

            if (dia == 5)
            {
                MessageBox.Show("Jueves");
            }

            if (dia == 6)
            {
                MessageBox.Show("Viernes");
            }

            if (dia == 7)
            {
                MessageBox.Show("Sabado");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Declarar la variable sexo
            string sexo = textBox2.Text;

            /* if/else */
            if (sexo == "m")
            {
                MessageBox.Show("Hombre");
            }
            else
            {
                MessageBox.Show("Mujer");
            }

            /* if/else/else if */
            if (sexo == "m" || sexo == "M")
            {
                MessageBox.Show("Masculino");
            }
            else if (sexo == "f" || sexo == "F")
            {
                MessageBox.Show("Femenino");
            }
            else
            {
                MessageBox.Show("Sexo invalido");
            }


        }
    }
}
