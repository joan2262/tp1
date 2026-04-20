using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_forms_crud_db
{
    
    public partial class Form2 : Form
    {
        Form1 ventanaOrigen;
        public Form2(Form2 origen)
        {
            InitializeComponent();
            ventanaOrigen = origen;
        }
    }


}
