using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace navegacion
{
    public partial class Form3 : Form
    {
        SqliteConnection conexion;
        string stringConexion = "Datasource = personas.db";
        Form1 ventanaOrigen;
        public Form3(Form1 origen)
        {
            InitializeComponent();
            conexion = new SqliteConnection(stringConexion);
            ventanaOrigen = origen;
        }

        private void btnForm3Volver_Click(object sender, EventArgs e)
        {
            ventanaOrigen.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre;
            string apellido;
            string dni;
            string telefono;
            string cargo;

            nombre = textNombre.Text;
            apellido = textApellido.Text;
            dni = textDNI.Text;
            telefono = textTelefono.Text;
            cargo = textCargo.Text;
            

            string consulta = "INSERT INTO personas ('nombre', 'apellido', 'dni', 'telefono', 'cargo') VALUES (@nombre, @apellido, @dni, @telefono, @cargo)";

            conexion.Open();

            SqliteCommand comando = new SqliteCommand(consulta, conexion);

            comando.Parameters.Add(new SqliteParameter("@nombre", nombre));
            comando.Parameters.Add(new SqliteParameter("@apellido", apellido));
            comando.Parameters.Add(new SqliteParameter("@dni", dni));
            comando.Parameters.Add(new SqliteParameter("@telefono", telefono));
            comando.Parameters.Add(new SqliteParameter("@cargo", cargo));

            comando.ExecuteNonQuery();

            conexion.Close();

        }



    }
}
