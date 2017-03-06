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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            
            if(textBoxContraseña.Text.Equals(""))
            {
                MessageBox.Show("La contraseña no puede estar vacía");
            }
            else if(textBoxUsuario.Text.Equals(""))
            {
                MessageBox.Show("El usuario no puede estar vacío");
            }
            else
            {
                //comprobar usuario base de datos
                bool validar = validarUsuari(textBoxUsuario.Text, textBoxContraseña.Text);
                if (validar == true)
                {
                    FormOpciones f = new FormOpciones(textBoxUsuario.Text);
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario con la contraseña introducida no existe");
                }
            }
        }
        public bool validarUsuari(string nom, string password)
        {
            bool usuarioCorrecto = false;
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cineq;";
            string query = "SELECT * FROM users";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                // Abrir la base de datos
                databaseConnection.Open();

                // Execute la sentencia
                reader = commandDatabase.ExecuteReader();




                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //guardar cada fila en el vector
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                        if (nom == reader.GetString(1) && password == reader.GetString(3))
                        {
                            usuarioCorrecto = true;
                            //falta desencriptar la contrasenya de la taula usuaris
                            //nomes entra si poses la contrasenya encriptada
                        }
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
                // Mostrar cualquier mensaje de error
                MessageBox.Show(ex.Message);
            }
            return usuarioCorrecto;
        }
    }
}
