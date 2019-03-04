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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Almacenar en variables los valores
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            string fechaNacimiento = dateTimePicker1.Value.ToString();
            string correo = textBox3.Text;
            string usuario = textBox4.Text;
            string contrasena = textBox5.Text;
            string repitaContrasena = textBox6.Text;

            bool genero = radioButton1.Checked;
            bool terminos = checkBox1.Checked;


            //int pais = comboBox1.SelectedIndex;
            //int estado = comboBox2.SelectedIndex;
            string pais = comboBox1.SelectedItem.ToString();
            string estado = comboBox2.SelectedItem.ToString();

            // Validar datos


            // Agregar los datos al ListView
            ListViewItem columna = new ListViewItem();

            columna.Text = nombre;
            //columna.SubItems.Add(nombre);
            columna.SubItems.Add(apellido);
            columna.SubItems.Add(fechaNacimiento);
            columna.SubItems.Add(correo);
            columna.SubItems.Add(usuario);
            columna.SubItems.Add(contrasena);
            columna.SubItems.Add(genero.ToString());
            columna.SubItems.Add(pais.ToString());
            columna.SubItems.Add(estado.ToString());

            // Agregar la columna al ListView
            listView1.Items.Add(columna);
        }
    }
}
