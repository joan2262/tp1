using Microsoft.Data.Sqlite;
using System.Data;

namespace proyecto_forms_crud_db
{
    public partial class Form1 : Form
    {
        Form2 ventanaVer;
        SqliteConnection conexion;
        string stringConexion = "Datasource = restaurante.db";



        public Form1()
        {
            InitializeComponent();
            ventanaVer = new Form2(this);
        }












        private void btnFormVer_Click(object sender, EventArgs e)
        {
            ventanaVer.Show();
            this.Hide();

        }




    }
}
