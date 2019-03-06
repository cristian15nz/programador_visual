using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            string pais = comboBox1.SelectedIndex.ToString();
            string estado = comboBox2.SelectedIndex.ToString();

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

            // Preparar el insert
            //var string_conexion = "server=localhost; user id=cristian; password=123; database=proyecto_c# ";
            //var conexion = new MySqlConnection(string_conexion);

            //conexion.Open();

            //var sql = "INSERT INTO usuarios(id, nombre, apellido, usuario) VALUES(1, '" + nombre + "', '" + apellido + "', '" + usuario + "') ";

            //insertarDatos(sql, conexion);

            /*Guardar en la base de datos */
            //var sql = "INSERT INTO usuarios(campos,de,la) VALUES ("","","","")";
            //var sql2 = "INSERT INTO usuarios(campos,de,la) VALUES ('"+nombre+"','','','')";
            var sql3 = "INSERT INTO usuarios(nombre, apellido, usuario) VALUES (\"{0}\",\"{1}\",\"{2}\")";

            var query = String.Format(sql3, nombre, apellido, usuario);
             
            // Insertarlo en la base de datos
            var string_conexion = "server=localhost; user id=cristian; password=123; database=proyecto_c# ";
            var conexion = new MySqlConnection(string_conexion);
            conexion.Open();

            insertarDatos(query, conexion);

            
        }

        private void baseDeDatos()
        {
            MySqlConnection conexion = null;

            try
            {
                // Preparar la conexion
                conexion = new MySqlConnection("server=localhost; user id=root; password=; database=proyecto_c#;");
                conexion.Open();
            }
            catch (MySqlException exception)
            {
                // Mostrar mensaje de error
                MessageBox.Show("Error al conectarse: \n\n" + exception.Message);
            }

            // Preparar el query
            // var sql = "SELECT * FROM usuarios";
            var sql = String.Format("SELECT {0} FROM {1}", "*", "usuarios");

            // Preparar el adaptador para ejecutar el query
            var adapter = new MySqlDataAdapter(sql, conexion);

            // Almacenar los datos resultantes en el DataSet
            var datos = new DataSet();
            adapter.Fill(datos);

            // Obtener la primera tabla
            var tabla = datos.Tables[0];

            // Mostrar los datos en el DataGridView
            dataGridView1.DataSource = tabla;

            conexion.Close();
        }

        private void __insertarDatos(string sql, MySqlConnection conexion)
        {
            try
            {
                // Preparar el comando para ejecutar el query
                var comando = new MySqlCommand(sql, conexion);
                comando.ExecuteNonQuery();

                // Almacenar los datos resultantes en el DataSet
                var datos = new DataSet();

                MessageBox.Show("Datos guardados");
            }
            catch (MySqlException exception)
            {
                MessageBox.Show("Error al insertar: \n\n" + exception);
            }
        }

        private void buttonMostrarUsuarios_Click(object sender, EventArgs e)
        {
            // Conexion a la base de datos
            try
            {
                var string_conexion = "server=localhost; user id=cristian; password=123; database=proyecto_c# ";
                var conexion = new MySqlConnection(string_conexion);

                conexion.Open();

                var sql = "SELECT * FROM usuarios";
                seleccionarDatos(sql, conexion);

            }
            catch (MySqlException error)
            {
                MessageBox.Show("Error conexion: \n\n " + error.Message);
            }
        }

        private void seleccionarDatos(string sql, MySqlConnection conexion)
        {
            try
            {
                var adaptador = new MySqlDataAdapter(sql, conexion);

                // Almacenar los datos
                var datos = new DataSet();

                adaptador.Fill(datos);

                // Mostrar los datos en el dataGridView
                dataGridView1.DataSource = datos.Tables[0];

            }
            catch (MySqlException error)
            {
                MessageBox.Show("Error en select: \n\n" + error.Message);
            }
        }

        // Insertar datos
        private void insertarDatos(string sql, MySqlConnection conexion)
        {
            try
            {
                var comando = new MySqlCommand(sql, conexion);

                var insertado = comando.ExecuteNonQuery();

                if (insertado > 0)
                {
                    MessageBox.Show("Datos insertados");
                }
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Error en el insert: \n\n" + error.Message);
            }
        }

        // Borrrar datos
        private void borrarDatos(string sql, MySqlConnection conexion)
        {
            // 
        }

        // Actualizar
        private void actualizarDatos(string sql, MySqlConnection conexion)
        {
            // 
        }
    }
}
