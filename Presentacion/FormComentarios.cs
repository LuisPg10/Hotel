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
    public partial class FormComentarios : Form
    {
        public FormComentarios()
        {
            InitializeComponent();
        }

        private void BotonRegresar_MouseClick(object sender, MouseEventArgs e)
        {
            Cambiar.AbrirFormulario<FormBienvenida>();
        }

        private void botonCerrar_MouseClick(object sender, MouseEventArgs e)
        {
            Cambiar.AbrirFormulario<FormInicioSesion>();
        }


        private void FormComentarios_Load(object sender, EventArgs e)
        {

        }
    }
}
