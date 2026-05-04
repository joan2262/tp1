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
    public partial class Form4Editar : Form
    {
        Form1 ventanaOrigen;
        int objetivoEdicion;
        public Form4Editar(Form1 origen)
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


        }
    }
}
