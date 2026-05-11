using Microsoft.Data.Sqlite;
using System.Data;

namespace navegacion
{
    public partial class FormInicio : Form
    {

        SqliteConnection conexion;
        string stringConexion = "Datasource = personas.db";


        public FormMostrar ventanaVer;
        FormAgregar ventanaAgregar;
        Form4Editar ventanaEditar;
        Form5 ventanaEditar2;

        public Form4Editar VentanaEditar
        {
            get
            {
                return ventanaEditar;
            }
        }


        public FormInicio()
        {
            InitializeComponent();
            conexion = new SqliteConnection(stringConexion);

            ventanaVer = new FormMostrar(this);
            ventanaAgregar = new FormAgregar(this);
            
            ventanaEditar2 = new Form5(this);






        }

        private void btnFormVerEmpleados_Click(object sender, EventArgs e)
        {
            ventanaVer.Show();
            this.Hide();
        }

        private void btnFormAgregarEmpleados_Click(object sender, EventArgs e)
        {
            ventanaAgregar.Show();
            this.Hide();

        }
    }
}
