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
    public partial class FormPreguntas : Form
    {
        public FormPreguntas()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FormOpciones f = new FormOpciones();
            f.Show();
            this.Close();
        }
        public string conseguirIdPregunta()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cineq;";
            string query = "SELECT * FROM pregunta";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            string id = "";
            try
            {
                // Abrir la base de datos
                databaseConnection.Open();

                // Ejecutar la sentencia
                reader = commandDatabase.ExecuteReader();

 
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //va guardando en el string el id de pregunta
                        //para en la ultima vuelta quedarse con el ultimo
                        id = reader.GetString(0);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                // Cerrar la conexion
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                //Mostrar mensajes de error
                MessageBox.Show(ex.Message);
            }
            return id+1;
        }

        public void afegirPregunta(string textPregunta, string textResposta1, string textResposta2, string textResposta3,
            string textResposta4)
        {
            //bool usuarioCorrecto = false;
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cineq;";
            string query = "INSERT INTO pregunta VALUES (@id, @textPregunta, @textResposta1, @textResposta2, @textResposta3 ,@textResposta4)";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            string id = conseguirIdPregunta();
            try
            {
                // Abrir la base de datos
                databaseConnection.Open();
                
                commandDatabase.Parameters.AddWithValue("@id", id);
                commandDatabase.Parameters.AddWithValue("@textPregunta", textPregunta);
                commandDatabase.Parameters.AddWithValue("@textResposta1", textResposta1);
                commandDatabase.Parameters.AddWithValue("@textResposta2", textResposta2);
                commandDatabase.Parameters.AddWithValue("@textResposta3", textResposta3);
                commandDatabase.Parameters.AddWithValue("@textResposta4", textResposta4);

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

        private void buttonAñadirPregunta_Click(object sender, EventArgs e)
        {
            afegirPregunta(textBoxPregunta.Text, textBoxRespuesta1.Text, textBoxRespuesta2.Text, textBoxRespuesta3.Text, textBoxRespuesta4.Text);
        }
    }
}
