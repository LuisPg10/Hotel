using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormHabitacion : Form
    {
        public FormHabitacion()
        {
            InitializeComponent();
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            Cambiar.AbrirFormulario<FormInicioSesion>();
        }

        private void botonRegresar_MouseClick(object sender, MouseEventArgs e)
        {
            Cambiar.AbrirFormulario<FormBienvenida>();
        }

        private void FormHabitacion_Load(object sender, EventArgs e)
        {

        }
    }
}
