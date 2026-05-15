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
    public partial class FormAgregar : Form
    {
        SqliteConnection conexion;
        string stringConexion = "Datasource = personas.db";
        FormInicio ventanaOrigen;
        public FormAgregar(FormInicio origen)
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
            if (textNombre.Text == "")
            {
                MessageBox.Show("El nombre no contiene caracteres.");
                return;
            }
            apellido = textApellido.Text;
            if (textApellido.Text == "")
            {
                MessageBox.Show("El apellido no contiene caracteres.");
                return;
            }
            dni = textDNI.Text;
            if (textDNI.Text == "")
            {
                MessageBox.Show("El DNI no contiene caracteres.");
                return;
            }
            telefono = textTelefono.Text;
            if (textTelefono.Text == "")
            {
                MessageBox.Show("El telefono no contiene caracteres.");
                return;
            }
            cargo = textCargo.Text;
            if (textCargo.Text == "")
            {
                MessageBox.Show("El cargo no contiene caracteres.");
                return;
            }


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

            ventanaOrigen.ventanaVer.actualizarDataGrid();
            ventanaOrigen.ventanaVer.Show();
            this.Hide();

            textNombre.Text = "";
            textApellido.Text = "";
            textDNI.Text = "";
            textTelefono.Text = "";
            textCargo.Text = "";

        }



    }
}
