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
    public partial class Ciclos : Form
    {
        // Propiedades (global)
        int dinero = 555;

        public Ciclos()
        {
            InitializeComponent();
        }

        private void mostrar()
        {
            int iterador = 20;
            //MessageBox.Show("El valor de iterador es: " + iterador);

            // Cambiar el valor de la variable global
            dinero = 1500;
            MessageBox.Show("Ganaste: " + dinero);

            {
                int cantidad = 99;
                //MessageBox.Show("Tienes " + cantidad + " ovejas");
                //MessageBox.Show("Las cuales costaron " + dinero);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // De manera ascedente
            for (int iterador = 1; iterador <= 10; iterador++ )
            {
                // MessageBox.Show("Valor del iterador: " + iterador);
                label2.Text += Convert.ToString(iterador) + "\n";
            }

            // De manera descendente
            for (int ite = 10; ite >= 1; ite--)
            {
                label3.Text += Convert.ToString(ite) + "\n";
            }

            // 
        }
    }
}
