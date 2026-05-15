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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace navegacion
{
    public partial class Form4Editar : Form
    {
        FormMostrar ventanaOrigen;
        int objetivoEdicion;
        public Form4Editar(FormMostrar origen)
        {
            InitializeComponent();
            ventanaOrigen = origen;
        }

        private void btnForm4Volver_Click(object sender, EventArgs e)
        {
            ventanaOrigen.Show();
            this.Hide();
        }

        public void PrepararEditar(int ideditar)
        {
            objetivoEdicion = ideditar;
            this.Show();
            ventanaOrigen.conexion.Open();
            string consulta = "SELECT * FROM personas WHERE id = @id";
            SqliteCommand comando = new SqliteCommand(consulta, ventanaOrigen.conexion);
            SqliteDataReader lector;

            comando.Parameters.Add(new SqliteParameter("@id", objetivoEdicion));

            lector = comando.ExecuteReader();
            DataTable tabla = new DataTable();
            tabla.Load(lector);
            ventanaOrigen.conexion.Close();

            textNombre.Text = tabla.Rows[0]["nombre"].ToString();
            textApellido.Text = tabla.Rows[0]["apellido"].ToString();
            textTelefono.Text = tabla.Rows[0]["telefono"].ToString();
            textDNI.Text = tabla.Rows[0]["dni"].ToString();
            textCargo.Text = tabla.Rows[0]["cargo"].ToString();

            
        }

        private void btnEditar_Click(object sender, EventArgs e)
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


            string consulta = "UPDATE personas SET nombre = @nombre, apellido = @apellido, dni = @dni, telefono = @telefono, cargo = @cargo WHERE id = @id";

            ventanaOrigen.conexion.Open();

            SqliteCommand comando = new SqliteCommand(consulta, ventanaOrigen.conexion);

            comando.Parameters.Add(new SqliteParameter("@nombre", nombre));
            comando.Parameters.Add(new SqliteParameter("@apellido", apellido));
            comando.Parameters.Add(new SqliteParameter("@dni", dni));
            comando.Parameters.Add(new SqliteParameter("@telefono", telefono));
            comando.Parameters.Add(new SqliteParameter("@cargo", cargo));
            comando.Parameters.Add(new SqliteParameter("@id", objetivoEdicion));

            comando.ExecuteNonQuery();

            ventanaOrigen.conexion.Close();

            ventanaOrigen.actualizarDataGrid();
            ventanaOrigen.Show();
            this.Hide();
        }
    }
}
