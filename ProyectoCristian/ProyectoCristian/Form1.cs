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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            new DiaSemana().Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            new ExpresionesOperadores().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new Calculadora().Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            new Ciclos().Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            new NuevosControles().Show();
        }
    }
}
