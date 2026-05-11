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
    public partial class FormMostrar : Form
    {
        public SqliteConnection conexion;
        string stringConexion = "Datasource = personas.db";
        FormInicio ventanaOrigen;
        Form4Editar ventanaEditar;
        public FormMostrar(FormInicio origen)
        {
            InitializeComponent();
            conexion = new SqliteConnection(stringConexion);
            ventanaOrigen = origen;
            ventanaEditar = new Form4Editar(this);
        }

        
        private void btnCambiarForm2_Click(object sender, EventArgs e)
        {
            ventanaOrigen.Show();
            this.Hide();
        }


        public void actualizarDataGrid()
        {
            conexion.Open();
            string consulta = "SELECT * FROM personas";
            SqliteCommand comando = new SqliteCommand(consulta, conexion);
            SqliteDataReader lector;
            lector = comando.ExecuteReader();
            DataTable tabla = new DataTable();
            tabla.Load(lector);
            conexion.Close();
            dgvEmpleados.Rows.Clear();

            foreach (DataRow fila in tabla.Rows)
            {
                dgvEmpleados.Rows.Add(int.Parse(fila["id"].ToString()),
                    fila["nombre"].ToString(),
                    fila["apellido"].ToString(),
                    fila["telefono"].ToString(),
                    fila["dni"].ToString(),
                    fila["cargo"].ToString());
                    
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            actualizarDataGrid();
        }

        private void buttonEditarForm3_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count <= 0)
                return;

            ventanaEditar.Show();
            this.Hide();



            int idSel = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["id"].Value);
            ventanaEditar.PrepararEditar(idSel);
            this.Hide();
        }
    }

      
}
