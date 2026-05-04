using Microsoft.Data.Sqlite;
using System.Data;

namespace navegacion
{
    public partial class Form1 : Form
    {

        SqliteConnection conexion;
        string stringConexion = "Datasource = personas.db";


        Form2 ventanaVer;
        Form3 ventanaAgregar;
        Form4Editar ventanaEditar;
        Form5 ventanaEditar2;

        public Form4Editar VentanaEditar
        {
            get
            {
                return ventanaEditar;
            }
        }


        public Form1()
        {
            InitializeComponent();
            conexion = new SqliteConnection(stringConexion);

            ventanaVer = new Form2(this);
            ventanaAgregar = new Form3(this);
            ventanaEditar = new Form4Editar(this);
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
