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

        private void mostrarMensaje(string mensaje)
        {
            MessageBox.Show("El dia de la semana es: " + mensaje);
        }

        private void saludar(string nombre)
        {
            MessageBox.Show("Hola, " + nombre);
        }

        private void sumar(double numero1, double numero2)
        {
            MessageBox.Show("El numero1 es: " + numero1);
            MessageBox.Show("El numero2 es: " + numero2);
        }

        private void verificarGenero(string sexo)
        {
            // Swith
            switch (sexo)
            {
                case "m": MessageBox.Show("Masculino"); break;
                case "M": MessageBox.Show("Masculino"); break;
                case "f": MessageBox.Show("Femenino"); break;
                case "F": MessageBox.Show("Femenino"); break;
                default: MessageBox.Show("Sexo invalido"); break;
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            // Validar que el usuario no digite un texto vacio
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Debe digitar un texto");
                return;
            }

            // Listado de dias
            string[] dias = {"Domingo",   // Indice: 0
                             "Lunes",     // Indice: 1
                             "Martes",    // Indice: 2
                             "Miércoles", // Indice: 3
                             "Jueves",    // Indice: 4
                             "Viernes",   // Indice: 5
                             "Sábado",    // Indice: 6
                             "Numero de dias nuevo"
                            };

            // Numero digitado por el usuario
            byte diaDigitado = Convert.ToByte(textBox1.Text);
            
            // Mostrar el dia digitado
            MessageBox.Show( dias[diaDigitado] );

            return;

            /*
            MessageBox.Show("El array posee " + dias.Length + " elementos");

            // MessageBox.Show( dias[8] );
            for (int day = 0; day < 7; day++)
            {
                MessageBox.Show(dias[day]);
            }

            MessageBox.Show(dias[100]);
            */


                return;

            // Obtener el dia digitado
            byte dia = Convert.ToByte(textBox1.Text);

            // Con el Switch
            switch (dia)
            {
                case 1: mostrarMensaje("Domingo"); break;
                case 2: mostrarMensaje("Lunes"); break;
                case 3: mostrarMensaje("Martes"); break;
                case 4: mostrarMensaje("Miercoles"); break;
                case 5: mostrarMensaje("Jueves"); break;
                case 6: mostrarMensaje("Viernes"); break;
                case 7: mostrarMensaje("Sabado"); break;
                default: mostrarMensaje("Dia invalido"); break;
            }

            /*
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
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Declarar la variable sexo
            string sexo = textBox2.Text;

            // Verificar el sexo
            verificarGenero(sexo);
        }

        private void DiaSemana_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string genero_persona = textBox3.Text;

            verificarGenero(genero_persona);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Listado de dias
            string[] dias = {"Domingo",   // Indice: 0
                             "Lunes",     // Indice: 1
                             "Martes",    // Indice: 2
                             "Miércoles", // Indice: 3
                             "Jueves",    // Indice: 4
                             "Viernes",   // Indice: 5
                             "Sábado"    // Indice: 6
                            };

            // Foreach
            foreach (string dia in dias)
            {
                label4.Text += "\n" + dia;
            }

            // For
            for (int posicion = 0; posicion < 7; posicion++ )
            {
                label4.Text += "\n" + dias[posicion];
            }

        }
    }
}
