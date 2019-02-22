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
    public partial class ExpresionesOperadores : Form
    {
        public ExpresionesOperadores()
        {
            InitializeComponent();
        }

        private void ExpresionesOperadores_Load(object sender, EventArgs e)
        {
            // Operadores de Texto
            // Unir (concatenar texto)
            MessageBox.Show("Cristian " + "Nuñez");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener el nombre
            string nombre = textBox1.Text;

            // Mostrar el nombre en el label
            //labelSaludo.Text = nombre; // Se reemplaza
            labelSaludo.Text = labelSaludo.Text + nombre;
        }

        private void labelSaludo_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Suma
            int numero1 = Convert.ToInt32(textBox2.Text);
            int numero2 = Convert.ToInt32(textBox3.Text);

            // Mostrar el mensaje
            int resultado = numero1 + numero2;
            MessageBox.Show("La suma es: " + resultado);
        }
    }
}
