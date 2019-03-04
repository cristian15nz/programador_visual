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
    public partial class NuevosControles : Form
    {
        public NuevosControles()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Ir a google.com
            System.Diagnostics.Process.Start("https://www.google.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Abrir calculadora
            new Calculadora().Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();

            // Otras formas
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Variables
            int red   = Convert.ToInt32(numericUpDown2.Value);
            int green = Convert.ToInt32(numericUpDown3.Value);
            int blue  = Convert.ToInt32(numericUpDown4.Value);

            // Cambiar fondo al formulario
            this.BackColor = Color.FromArgb(red, green, blue);

            // Cambiar fondo a la pestaña
            tabControl1.TabPages[3].BackColor = Color.FromArgb(red, green, blue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Increment(10);

            label4.Text = progressBar1.Value.ToString() + "%";

            if (progressBar1.Value == progressBar1.Maximum)
            {
                MessageBox.Show("Completado");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Chinola");
            comboBox1.Items.Add("Naranja");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboBox1.SelectedIndex;
            label5.Text = indice.ToString();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Guardar en una variable el texto
            string texto = txtItem.Text;

            // Agregar el texto al ListBox, al ComboBox y al CheckListBox
            listBox1.Items.Add(texto);
            comboBox1.Items.Add(texto);
            checkedListBox1.Items.Add(texto);
            
        }
    }
}
