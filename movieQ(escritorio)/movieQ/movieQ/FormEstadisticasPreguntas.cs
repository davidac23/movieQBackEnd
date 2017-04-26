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
using System.Collections;

namespace movieQ
{
    public partial class FormEstadisticasPreguntas : Form
    {
        public FormEstadisticasPreguntas()
        {
            InitializeComponent();
        }

        public void cargarPreguntas()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cineq;";
            string query = "SELECT id, vecesCorrectas, vecesContestadas FROM pregunta";
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
            dataGridView1.DataSource = miTabla;
            reader.Close();
            databaseConnection.Close();

        }

        private void FormEstadisticasPreguntas_Load(object sender, EventArgs e)
        {
            cargarPreguntas();
        }

        private void buttonMostrarEstadistica_Click(object sender, EventArgs e)
        {
            this.chart1.Series.Clear();
            this.chart1.Series.Add("Preguntas");
            //ArrayList partidas = new ArrayList();
            //int id;
            //string pGanadas = "", pTotales = "", pPerdidas = "", pEmpatadas = "";
            //id = (int)dataGridViewUsuarios.SelectedRows[0].Cells[0].Value;
            //cargarGrafico(id, pGanadas, pTotales, pEmpatadas, pPerdidas);

            this.chart1.Series["Preguntas"].Points.AddXY("Correctas", (int)dataGridView1.SelectedRows[0].Cells[1].Value);           
            this.chart1.Series["Preguntas"].Points.AddXY("Incorrectas", (int)dataGridView1.SelectedRows[0].Cells[2].Value - (int)dataGridView1.SelectedRows[0].Cells[1].Value);
        }
    }
}
