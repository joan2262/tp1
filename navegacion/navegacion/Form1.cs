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
        Form4 ventanaBorrar;
        Form5 ventanaEditar;




        public Form1()
        {
            InitializeComponent();
            conexion = new SqliteConnection(stringConexion);

            ventanaVer = new Form2(this);
            ventanaAgregar = new Form3(this);
            ventanaBorrar = new Form4(this);
            ventanaEditar = new Form5(this);






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

        private void btnFormBorrarEmpleados_Click(object sender, EventArgs e)
        {
            ventanaBorrar.Show();
            this.Hide();
        }


        private void btnFormEditarEmpleados_Click(object sender, EventArgs e)
        {
            ventanaEditar.Show();
            this.Hide();
        }


    }
}
