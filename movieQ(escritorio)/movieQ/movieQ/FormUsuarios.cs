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

namespace movieQ
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void toolStripButtonVolver_Click(object sender, EventArgs e)
        {
            FormOpciones fo = new FormOpciones();
            fo.Show();
            this.Hide();      
        }

        public void cargarUsuarios()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cineq;";
            string query = "SELECT id, name, email FROM users";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            DataTable miTabla = new DataTable();

            //SqlConnection conexion = new SqlConnection();
            //SqlCommand sentencia = new SqlCommand();
            //SqlDataReader datos;
            

            //conexion.ConnectionString = "Data Source=172.16.48.128\\sqlexpress;Initial Catalog=hoteles_basico;" +
            //    "Persist Security Info=True;User ID=sa;Password=cep";

            //sentencia.Connection = conexion;
            //sentencia.CommandText =
            //    "select * from hoteles where id_ciudad = @ciudad; ";
            //sentencia.Parameters.Clear();
            //sentencia.Parameters.AddWithValue("@ciudad", comboBoxCiutats.SelectedValue);

            databaseConnection.Open();
            miTabla = new DataTable();
            reader = commandDatabase.ExecuteReader();//solo para selects
            miTabla.Load(reader);
            dataGridViewUsuarios.DataSource = miTabla;

            databaseConnection.Close();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
        }

        private void borrarUsuari(int id_usuari)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cineq;";
            string query = "delete from users where id = @id_usuari";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                // Abrir la base de datos
                databaseConnection.Open();

                commandDatabase.Parameters.AddWithValue("@id_usuari", id_usuari);

                commandDatabase.ExecuteNonQuery();

                // Cerrar la conexion
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Mostrar mensajes de error
                MessageBox.Show(ex.Message);
            }

        }

        public void altaUsuari(string nom_usuari, string password)//falta encriptar password
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cineq;";
            string query = "insert into users (name, password) values (@nom_usuari, @password)";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                // Abrir la base de datos
                databaseConnection.Open();

                commandDatabase.Parameters.AddWithValue("@nom_usuari", nom_usuari);
                commandDatabase.Parameters.AddWithValue("@password", password);

                commandDatabase.ExecuteNonQuery();

                // Cerrar la conexion
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Mostrar mensajes de error
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            borrarUsuari((int)dataGridViewUsuarios.SelectedRows[0].Cells[0].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            altaUsuari(textBoxNombre.Text, textBoxContraseña.Text);
        }

      
    }
}
