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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var edad = 23;
            //MessageBox.Show("Su edad es: " + edad);
            edad = 15;
            //MessageBox.Show("Su edad es: " + edad);

            // Constantes
            const int impuesto = 18;
            //MessageBox.Show("El impuesto es: " + impuesto);

            // Tipos de datos Numericos
            //-- NUMEROS ENTEROS
            byte numeroByte = 255;
            
            short numeroShort = -32768; // Convert.toInt16
            short numeroShort2 = 32767;
            
            int numeroInt = -2147483648; // Convert.toInt32
            int numeroInt2 = 2147483647;

            long numeroLong = -9223372036854775808; // Convert.toInt64
            long numeroLong2 = 9223372036854775807;

            //-- NUMEROS CON PUNTOS FLOTANTES
            float porciento = 11111111111111111111;
            double herencia = 10.55789;

            // Tipos de datos String
            char caracter = '@';
            string nombre = "Cristian Nunez";

            //char simbolo = "@"; // Incorrecto
            //string nacionalidad = 'Dominicano'; // Incorrecto

            // Tipos de datos Booleanos
            bool estaCasado = false;
            bool poseeTarjetaCredito = true;


            var precio = 150;
            int precio22 = 150;

            MessageBox.Show("Valor: " + precio);
            MessageBox.Show("Valor: " + (precio22 == 150));

        }
    }
}
