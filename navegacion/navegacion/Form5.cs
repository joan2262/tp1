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
    public partial class Form5 : Form
    {
        Form1 ventanaOrigen;
        public Form5(Form1 origen)
        {
            InitializeComponent();
            ventanaOrigen = origen;
        }

        private void btnForm5Volver_Click(object sender, EventArgs e)
        {
            ventanaOrigen.Show();
            this.Hide();
        }
    }
}
