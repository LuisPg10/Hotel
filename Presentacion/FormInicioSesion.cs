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
    public partial class FormInicioSesion : Form
    {
        public FormInicioSesion()
        {
            InitializeComponent();
        }


        private void botonEntrar_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void botonCrear_MouseClick(object sender, MouseEventArgs e)
        {
            Cambiar.AbrirFormulario<FormRegistrar>();
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {

            Cambiar.AbrirFormulario<FormBienvenida>();
        }

        private void FormInicioSesion_Load(object sender, EventArgs e)
        {

        }

        
    }
}
